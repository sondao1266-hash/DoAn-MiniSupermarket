using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.WinForms
{
    public static class ApiClient
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7054/api/") // Đảm bảo đúng Port của Backend API nhé
        };

        public static HttpClient GetClient()
        {
            // Xóa sạch các authorization cũ trước đó để tránh trùng lặp
            _client.DefaultRequestHeaders.Authorization = null;

            // Nếu SessionManager đã có Token (đã đăng nhập), tự động gắn vào Header
            if (!string.IsNullOrEmpty(SessionManager.JwtToken))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.JwtToken);
            }

            return _client;
        }

        // Hiển thị thông báo lỗi phù hợp khi API trả về mã lỗi. Trả về true nếu response thành công.
        public static async Task<bool> CheckAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            string message;
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                message = "Phiên làm việc hết hạn hoặc chưa đăng nhập!";
            }
            else if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                message = "Bạn không đủ quyền thực hiện thao tác này (cần quyền Admin)!";
            }
            else
            {
                string body = await response.Content.ReadAsStringAsync();
                message = "Lỗi từ Server (" + (int)response.StatusCode + "): " + body;
            }

            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
