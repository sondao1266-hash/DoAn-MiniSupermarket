using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Data
{
    // DbContext đại diện cho phiên làm việc với cơ sở dữ liệu SQL Server
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(DbContextOptions<SupermarketDbContext> options) : base(options) { }

        // Khai báo các bảng dữ liệu ánh xạ từ Model
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // Cấu hình dữ liệu mồi ban đầu (Data Seeding) cho Kitchen Express
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Nạp sẵn 5 danh mục đồ gia dụng nhà bếp
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Nồi và Chảo", Description = "Các loại nồi, chảo chống dính, nồi áp suất" },
                new Category { CategoryId = 2, CategoryName = "Thiết bị Điện nhà bếp", Description = "Nồi chiên, máy xay, lò vi sóng, ấm siêu tốc" },
                new Category { CategoryId = 3, CategoryName = "Dụng cụ nấu nướng & Cắt thái", Description = "Bộ dao, thớt, dụng cụ hỗ trợ nấu ăn" },
                new Category { CategoryId = 4, CategoryName = "Hộp đựng & Bảo quản thực phẩm", Description = "Hộp thủy tinh, hộp giữ nhiệt" },
                new Category { CategoryId = 5, CategoryName = "Dụng cụ pha chế & Dùng bàn ăn", Description = "Bình giữ nhiệt, ấm chén" }
            );

            // 2. Nạp sẵn 15 sản phẩm đồ gia dụng nhà bếp Kitchen Express (Liên kết với CategoryId)
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Nồi chiên không dầu Philips 5L", CategoryId = 2, Price = 2490000m, StockQuantity = 15 },
                new Product { ProductId = 2, ProductName = "Máy xay sinh tố đa năng Sunhouse", CategoryId = 2, Price = 650000m, StockQuantity = 25 },
                new Product { ProductId = 3, ProductName = "Nồi cơm điện cao tần Panasonic 1.8L", CategoryId = 2, Price = 1850000m, StockQuantity = 10 },
                new Product { ProductId = 4, ProductName = "Lò vi sóng điện tử Sharp 20L", CategoryId = 2, Price = 1790000m, StockQuantity = 8 },
                new Product { ProductId = 5, ProductName = "Ấm siêu tốc điện giữ nhiệt Lock&Lock 1.7L", CategoryId = 2, Price = 520000m, StockQuantity = 30 },
                new Product { ProductId = 6, ProductName = "Bộ nồi inox 5 đáy Elmich (3 chiếc)", CategoryId = 1, Price = 1250000m, StockQuantity = 12 },
                new Product { ProductId = 7, ProductName = "Chảo chống dính sâu lòng Sunhouse 28cm", CategoryId = 1, Price = 280000m, StockQuantity = 40 },
                new Product { ProductId = 8, ProductName = "Nồi áp suất lẩu điện đa năng Kasuma", CategoryId = 1, Price = 790000m, StockQuantity = 18 },
                new Product { ProductId = 9, ProductName = "Bộ dao nhà bếp cao cấp 6 món thép không gỉ", CategoryId = 3, Price = 450000m, StockQuantity = 20 },
                new Product { ProductId = 10, ProductName = "Thớt gỗ kháng khuẩn cao cấp (Cỡ lớn)", CategoryId = 3, Price = 180000m, StockQuantity = 50 },
                new Product { ProductId = 11, ProductName = "Bộ dụng cụ nấu nướng silicone chịu nhiệt (5 món)", CategoryId = 3, Price = 150000m, StockQuantity = 35 },
                new Product { ProductId = 12, ProductName = "Bộ hộp đựng cơm giữ nhiệt văn phòng Lock&Lock", CategoryId = 4, Price = 390000m, StockQuantity = 22 },
                new Product { ProductId = 13, ProductName = "Hộp đựng thực phẩm thủy tinh chịu nhiệt (Bộ 4 món)", CategoryId = 4, Price = 290000m, StockQuantity = 30 },
                new Product { ProductId = 14, ProductName = "Bình giữ nhiệt thể thao inox 304 (750ml)", CategoryId = 5, Price = 220000m, StockQuantity = 45 },
                new Product { ProductId = 15, ProductName = "Bộ ấm chén trà gốm sứ Bát Tràng cao cấp", CategoryId = 5, Price = 680000m, StockQuantity = 14 }
            );

            // Giá trị mặc định cho khách hàng
            modelBuilder.Entity<Customer>().Property(c => c.RewardPoints).HasDefaultValue(0);
            modelBuilder.Entity<Customer>().Property(c => c.MembershipRank).HasDefaultValue("Chuẩn");

            // 3. Nạp sẵn 15 khách hàng mẫu
            modelBuilder.Entity<Customer>().HasData(
     new Customer { CustomerId = 1, CustomerName = "Nguyen Van An", PhoneNumber = "0901122334", Address = "123 Nguyen Trai, Q.1, TP.HCM", MembershipRank = "Vang", RewardPoints = 150 },
     new Customer { CustomerId = 2, CustomerName = "Tran Thi Binh", PhoneNumber = "0918877665", Address = "45 Le Loi, Q.Hai Chau, Da Nang", MembershipRank = "Bac", RewardPoints = 50 },
     new Customer { CustomerId = 3, CustomerName = "Le Van Cuong", PhoneNumber = "0983344556", Address = "78 CMT8, Q.3, TP.HCM", MembershipRank = "Chuan", RewardPoints = 10 },
     new Customer { CustomerId = 4, CustomerName = "Pham Thi Dung", PhoneNumber = "0932233445", Address = "12 Hoang Van Thu, Bien Hoa", MembershipRank = "Vang", RewardPoints = 220 },
     new Customer { CustomerId = 5, CustomerName = "Hoang Van Em", PhoneNumber = "0977889900", Address = "56 Le Duan, Q.Ninh Kieu, Can Tho", MembershipRank = "Chuan", RewardPoints = 5 },
     new Customer { CustomerId = 6, CustomerName = "Vu Thi Phuong", PhoneNumber = "0912345678", Address = "90 Tran Phu, TP.Nha Trang", MembershipRank = "Bac", RewardPoints = 80 },
     new Customer { CustomerId = 7, CustomerName = "Dang Van Giang", PhoneNumber = "0988776655", Address = "15 Dinh Tien Hoang, Q.1, TP.HCM", MembershipRank = "Vang", RewardPoints = 310 },
     new Customer { CustomerId = 8, CustomerName = "Bui Thi Hoa", PhoneNumber = "0905544332", Address = "34 Pho Hue, Q.Hoan Kiem, Ha Noi", MembershipRank = "Chuan", RewardPoints = 20 },
     new Customer { CustomerId = 9, CustomerName = "Ngo Van Hung", PhoneNumber = "0966112233", Address = "88 Nguyen Van Linh, Q.Thanh Khe, Da Nang", MembershipRank = "Bac", RewardPoints = 95 },
     new Customer { CustomerId = 10, CustomerName = "Duong Thi Lan", PhoneNumber = "0944332211", Address = "22 Le Van Viet, TP.Thu Duc", MembershipRank = "Vang", RewardPoints = 180 },
     new Customer { CustomerId = 11, CustomerName = "Ly Van Minh", PhoneNumber = "0922334455", Address = "67 Phan Chu Trinh, Buon Ma Thuot", MembershipRank = "Chuan", RewardPoints = 15 },
     new Customer { CustomerId = 12, CustomerName = "Do Thi Nga", PhoneNumber = "0933445566", Address = "102 Nguyen Thi Minh Khai, Q.3, TP.HCM", MembershipRank = "Bac", RewardPoints = 65 },
     new Customer { CustomerId = 13, CustomerName = "Ho Van Quan", PhoneNumber = "0977112233", Address = "55 Hung Vuong, TP.Hue", MembershipRank = "Vang", RewardPoints = 250 },
     new Customer { CustomerId = 14, CustomerName = "Phan Thi Suong", PhoneNumber = "0909988776", Address = "43 Quang Trung, TP.Da Lat", MembershipRank = "Chuan", RewardPoints = 0 },
     new Customer { CustomerId = 15, CustomerName = "Trinh Van Tung", PhoneNumber = "0911223344", Address = "79 Ly Thuong Kiet, Q.Tan Binh, TP.HCM", MembershipRank = "Bac", RewardPoints = 110 }
 );
        }
    }
}