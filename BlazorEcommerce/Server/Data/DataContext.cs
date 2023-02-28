using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         //   modelBuilder.Entity<Product>().HasData(
         //new Product
         //{
         //    ID = 1,
         //    Title = "千载一玉 冰种玉髓玉镯 女士俏色冰透玛瑙玉手镯",
         //    Description = "手镯（bracelet; bangle [1]  ），是用金、银、玉等制的戴在手腕上的环形装饰品 [1]  。按结构，一般可分为两种：一是封闭形圆环，以玉石材料为多；二是有端口或数个链片，以金属材料居多。按制作材料，可分为金手镯、银手镯、玉手镯、镶宝石手镯等。手镯不同于手链，手镯一般是整块的结构，手链的话可以多个小件组合成链状环绕佩戴在手上",

         //    ImageUrl = "https://img12.360buyimg.com/n1/jfs/t1/36933/30/17994/35055/634e0a65Ed7556de9/2fcca8a8053ba6ec.jpg",
         //    Price = 100
         //},
         // new Product
         // {
         //     ID = 2,
         //     Title = "Apple iPhone 14 Pro (A2892) 256GB 暗紫色 支持移动联通电信5G 双卡双待手机",
         //     Description = "Apple iPhone 14 Pro (A2892) 256GB 暗紫色 支持移动联通电信5G 双卡双待手机",
         //     ImageUrl = "https://img14.360buyimg.com/n1/s450x450_jfs/t1/217635/37/23600/32156/63f89325Fab8cf6e7/633bfc3c587ee7d2.jpg",
         //     Price = 100
         // },
         //new Product
         //{
         //    ID = 3,
         //    Title = "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘",
         //    Description = "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘",
         //    ImageUrl = "https://img11.360buyimg.com/n1/s450x450_jfs/t1/63578/19/21832/100681/638eb995Ec2dc6918/9f61807ce6a93287.jpg",
         //    Price = 100
         //}
         //);
        }
        public DbSet<Product> Products { get; set; }
    }
}
