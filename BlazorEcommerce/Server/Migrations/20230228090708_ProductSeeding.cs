using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "手镯（bracelet; bangle [1]  ），是用金、银、玉等制的戴在手腕上的环形装饰品 [1]  。按结构，一般可分为两种：一是封闭形圆环，以玉石材料为多；二是有端口或数个链片，以金属材料居多。按制作材料，可分为金手镯、银手镯、玉手镯、镶宝石手镯等。手镯不同于手链，手镯一般是整块的结构，手链的话可以多个小件组合成链状环绕佩戴在手上", "https://img12.360buyimg.com/n1/jfs/t1/36933/30/17994/35055/634e0a65Ed7556de9/2fcca8a8053ba6ec.jpg", 100m, "千载一玉 冰种玉髓玉镯 女士俏色冰透玛瑙玉手镯" },
                    { 2, "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘", "https://img11.360buyimg.com/seckillcms/s500x500_jfs/t1/112659/11/33650/22014/63fc6259F2b2afbb0/ab026b47388de623.jpg", 100m, "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘" },
                    { 3, "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘", "https://img11.360buyimg.com/n1/s450x450_jfs/t1/63578/19/21832/100681/638eb995Ec2dc6918/9f61807ce6a93287.jpg", 100m, "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
