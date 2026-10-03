using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.WinForms
{
    public partial class FormCustomerManagement : Form
    {
        public FormCustomerManagement()
        {
            InitializeComponent();
        }

        private async void FormCustomerManagement_Load(object sender, EventArgs e)
        {
            // Cashier chỉ được thêm / sửa; chỉ Admin được xóa
            btnDelete.Enabled = SessionManager.CurrentRole == "Admin";
            txtCustomerId.ReadOnly = true;
            await LoadDataAsync("customers");
        }

        // GET /api/customers hoặc /api/customers/search?keyword=...
        private async Task LoadDataAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await ApiClient.GetClient().GetAsync(url);
                if (!await ApiClient.CheckAsync(response))
                {
                    return;
                }
                List<CustomerDto> list = await response.Content.ReadFromJsonAsync<List<CustomerDto>>()
                                         ?? new List<CustomerDto>();
                dgvCustomers.DataSource = list;
                if (dgvCustomers.Columns.Contains("CustomerId")) dgvCustomers.Columns["CustomerId"].HeaderText = "Mã KH";
                if (dgvCustomers.Columns.Contains("CustomerName")) dgvCustomers.Columns["CustomerName"].HeaderText = "Họ tên";
                if (dgvCustomers.Columns.Contains("PhoneNumber")) dgvCustomers.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                if (dgvCustomers.Columns.Contains("Address")) dgvCustomers.Columns["Address"].HeaderText = "Địa chỉ";
                if (dgvCustomers.Columns.Contains("RewardPoints")) dgvCustomers.Columns["RewardPoints"].HeaderText = "Điểm";
                if (dgvCustomers.Columns.Contains("MembershipRank")) dgvCustomers.Columns["MembershipRank"].HeaderText = "Hạng thẻ";
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtRewardPoints.Text = "0";
            txtMembershipRank.Text = "Chuẩn";
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            CustomerDto c = dgvCustomers.Rows[e.RowIndex].DataBoundItem as CustomerDto;
            if (c == null) return;

            txtCustomerId.Text = c.CustomerId.ToString();
            txtCustomerName.Text = c.CustomerName;
            txtPhoneNumber.Text = c.PhoneNumber;
            txtAddress.Text = c.Address;
            txtRewardPoints.Text = c.RewardPoints.ToString();
            txtMembershipRank.Text = c.MembershipRank;
        }

        // Đọc dữ liệu nhập vào; trả về null nếu không hợp lệ
        private CustomerDto ReadInput()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return null;
            }
            int points;
            if (!int.TryParse(txtRewardPoints.Text, out points) || points < 0)
            {
                MessageBox.Show("Điểm tích lũy phải là số nguyên không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRewardPoints.Focus();
                return null;
            }

            int id;
            int.TryParse(txtCustomerId.Text, out id);

            return new CustomerDto
            {
                CustomerId = id,
                CustomerName = txtCustomerName.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                RewardPoints = points,
                MembershipRank = string.IsNullOrWhiteSpace(txtMembershipRank.Text)
                    ? "Chuẩn" : txtMembershipRank.Text.Trim()
            };
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            await LoadDataAsync("customers");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword.Length == 0)
            {
                await LoadDataAsync("customers");
                return;
            }
            await LoadDataAsync("customers/search?keyword=" + Uri.EscapeDataString(keyword));
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerDto c = ReadInput();
            if (c == null) return;

            try
            {
                HttpResponseMessage response = await ApiClient.GetClient().PostAsJsonAsync("customers", c);
                if (!await ApiClient.CheckAsync(response)) return;

                await LoadDataAsync("customers");
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustomerDto c = ReadInput();
            if (c == null) return;

            try
            {
                HttpResponseMessage response = await ApiClient.GetClient()
                    .PutAsJsonAsync("customers/" + c.CustomerId, c);
                if (!await ApiClient.CheckAsync(response)) return;

                await LoadDataAsync("customers");
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtCustomerId.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng \"" + txtCustomerName.Text + "\" không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                HttpResponseMessage response = await ApiClient.GetClient().DeleteAsync("customers/" + id);
                if (!await ApiClient.CheckAsync(response)) return;

                await LoadDataAsync("customers");
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class CustomerDto
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public int RewardPoints { get; set; }
            public string MembershipRank { get; set; }
        }
    }
}
