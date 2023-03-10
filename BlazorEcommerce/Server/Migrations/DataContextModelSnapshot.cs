// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "手镯（bracelet; bangle [1]  ），是用金、银、玉等制的戴在手腕上的环形装饰品 [1]  。按结构，一般可分为两种：一是封闭形圆环，以玉石材料为多；二是有端口或数个链片，以金属材料居多。按制作材料，可分为金手镯、银手镯、玉手镯、镶宝石手镯等。手镯不同于手链，手镯一般是整块的结构，手链的话可以多个小件组合成链状环绕佩戴在手上",
                            ImageUrl = "https://img12.360buyimg.com/n1/jfs/t1/36933/30/17994/35055/634e0a65Ed7556de9/2fcca8a8053ba6ec.jpg",
                            Price = 100m,
                            Title = "千载一玉 冰种玉髓玉镯 女士俏色冰透玛瑙玉手镯"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Apple iPhone 14 Pro (A2892) 256GB 暗紫色 支持移动联通电信5G 双卡双待手机",
                            ImageUrl = "https://img14.360buyimg.com/n1/s450x450_jfs/t1/217635/37/23600/32156/63f89325Fab8cf6e7/633bfc3c587ee7d2.jpg",
                            Price = 100m,
                            Title = "Apple iPhone 14 Pro (A2892) 256GB 暗紫色 支持移动联通电信5G 双卡双待手机"
                        },
                        new
                        {
                            ID = 3,
                            Description = "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘",
                            ImageUrl = "https://img11.360buyimg.com/n1/s450x450_jfs/t1/63578/19/21832/100681/638eb995Ec2dc6918/9f61807ce6a93287.jpg",
                            Price = 100m,
                            Title = "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
