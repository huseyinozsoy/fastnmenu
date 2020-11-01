using System;
using System.Collections.Generic;
using FastnMenu.Models;
using Microsoft.EntityFrameworkCore;

namespace FastnMenu.Repositories
{
    public class FastNMenuContext:DbContext
    {
        public FastNMenuContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<MenuCategory>().HasKey(mc => new {mc.CategoryId,mc.MenuId});
            modelBuilder.Entity<MenuCategory>().HasOne(mc => mc.Menu).WithMany(m => m.MenuCategories).HasForeignKey(mc => mc.MenuId);
            modelBuilder.Entity<MenuCategory>().HasOne(mc => mc.Category).WithMany(m => m.MenuCategories).HasForeignKey(mc => mc.CategoryId);
*/
            modelBuilder.Entity<Category>().HasData(
                new Category{ Id=1,CategoryName = "Kahvaltı"},
                new Category{ Id=2, CategoryName= "Soğuk İçeçekler" },
                new Category{ Id=3, CategoryName= "Sıcak İçeçekler" },
                new Category{ Id=4, CategoryName= "Ana Yemekler" },
                new Category{ Id=5, CategoryName= "Tatlılar" }
            );
            List<Menu> menus = new List<Menu>{
                new Menu{ Id=1,CompanyId=1, Name="Sahanda Yumurta",Discount=0,Price=10,
                ShortDescription="Tereyağlı sahanda yumurta",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=2,CompanyId=1, Name="Didi Soğuk Çay",Discount=0,Price=4,
                ShortDescription="Kutu Didi Soğuk Çay",
                Picture="https://www.caykursatis.com/didi-500-ml-seftali-aromali-soguk-cay-caykur-soguk-cay-soguk-cay-caykur-soguk-cay-618-13-O.jpg" },
                new Menu{ Id=3,CompanyId=1, Name="Bardak Çay",Discount=0,Price=2,
                ShortDescription="İnce belli bardak çay",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=4,CompanyId=1, Name="Fincan Çay",Discount=0,Price=4,
                ShortDescription="Fincan Çay",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=5,CompanyId=1, Name="Fırında Çöp Şiş",Discount=0,Price=30,
                ShortDescription="Fırında Tavuk Çöp Şiş",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=6,CompanyId=1, Name="Pilav",Discount=0,Price=7.5,
                ShortDescription="Pirinç Pilavı",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=7,CompanyId=1, Name="Adana Kebap",Discount=0,Price=10,
                ShortDescription="Nefis Adana Kebap",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=8,CompanyId=1, Name="Sütlaç",Discount=0,Price=10,
                ShortDescription="Sütlaç",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=9,CompanyId=1, Name="Magnolia",Discount=0,Price=10,
                ShortDescription="Kat kat puding ve bisküvi parçacıkları",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" },
                new Menu{ Id=10,CompanyId=1, Name="Tavuklu Patates Yemeği",Discount=0,Price=10,
                ShortDescription="Nefis Tavuklu Patates Yemeği",
                Picture="https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg" }
            };
            modelBuilder.Entity<Menu>().HasData(
                menus
            );
            modelBuilder.Entity<CompanyType>().HasData(
                new CompanyType{Id=1,TypeName="Restoran"},
                new CompanyType{Id=2,TypeName="Kafe"}
            );
            modelBuilder.Entity<Company>().HasData(
                new Company{Id=1,CompanyName="Feramuz Restoran",Picture="https://g7.pngresmi.com/preview/524/137/77/gluten-free-diet-logo-celiac-disease-wheat-vector-restaurant-logo.jpg",
                Description="Uygun Fiyat Kaliteli Yemek",CompanyTypeId= 1,
                Address="Pendik/İstanbul",Email="feramuzrestoran@gmail.com",IsActive=true,Phone="02164999999",
                QRCode="5f3d7a4f29acbf385a539ee6",WorkHour="8-20",SubscriptionStartDate=DateTime.Now,SubscriptionExpiryDate=DateTime.Now.AddHours(1)}
            );
            /*
            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory{CategoryId=1,MenuId=1},
                new MenuCategory{CategoryId=2,MenuId=2},
                new MenuCategory{CategoryId=3,MenuId=3}, 
                new MenuCategory{CategoryId=3,MenuId=4},
                new MenuCategory{CategoryId=4,MenuId=5},
                new MenuCategory{CategoryId=4,MenuId=6},
                new MenuCategory{CategoryId=4,MenuId=7},
                new MenuCategory{CategoryId=4,MenuId=10},
                new MenuCategory{CategoryId=5,MenuId=8},
                new MenuCategory{CategoryId=5,MenuId=9}
            );
            */
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<MenuCategory> MenuCategories { get; set; }
    }
}