namespace MiniSupermarket.WinForms
{
    partial class FormCustomerManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtRewardPoints = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtMembershipRank = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // dgvCustomers
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Location = new System.Drawing.Point(20, 50);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(740, 250);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Từ khóa:";
            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(90, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 2;
            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(320, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(420, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 27);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 320);
            this.lblId.Name = "lblId";
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Mã KH:";
            // txtCustomerId
            this.txtCustomerId.Location = new System.Drawing.Point(120, 317);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(160, 23);
            this.txtCustomerId.TabIndex = 6;
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(310, 320);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Họ tên:";
            // txtCustomerName
            this.txtCustomerName.Location = new System.Drawing.Point(390, 317);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(260, 23);
            this.txtCustomerName.TabIndex = 8;
            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 352);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Số điện thoại:";
            // txtPhoneNumber
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 349);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 23);
            this.txtPhoneNumber.TabIndex = 10;
            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(310, 352);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Địa chỉ:";
            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(390, 349);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 23);
            this.txtAddress.TabIndex = 12;
            // lblPoints
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(20, 384);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.TabIndex = 13;
            this.lblPoints.Text = "Điểm tích lũy:";
            // txtRewardPoints
            this.txtRewardPoints.Location = new System.Drawing.Point(120, 381);
            this.txtRewardPoints.Name = "txtRewardPoints";
            this.txtRewardPoints.Size = new System.Drawing.Size(160, 23);
            this.txtRewardPoints.TabIndex = 14;
            // lblRank
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(310, 384);
            this.lblRank.Name = "lblRank";
            this.lblRank.TabIndex = 15;
            this.lblRank.Text = "Hạng thẻ:";
            // txtMembershipRank
            this.txtMembershipRank.Location = new System.Drawing.Point(390, 381);
            this.txtMembershipRank.Name = "txtMembershipRank";
            this.txtMembershipRank.Size = new System.Drawing.Size(260, 23);
            this.txtMembershipRank.TabIndex = 16;
            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(120, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(230, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(340, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // FormCustomerManagement
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtRewardPoints);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtMembershipRank);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý khách hàng thân thiết";
            this.Load += new System.EventHandler(this.FormCustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtRewardPoints;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox txtMembershipRank;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
