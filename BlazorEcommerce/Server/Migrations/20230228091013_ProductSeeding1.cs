using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Apple iPhone 14 Pro (A2892) 256GB 暗紫色 支持移动联通电信5G 双卡双待手机", "https://img14.360buyimg.com/n1/s450x450_jfs/t1/217635/37/23600/32156/63f89325Fab8cf6e7/633bfc3c587ee7d2.jpg", "Apple iPhone 14 Pro (A2892) 256GB 暗紫色 支持移动联通电信5G 双卡双待手机" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘", "https://img11.360buyimg.com/seckillcms/s500x500_jfs/t1/112659/11/33650/22014/63fc6259F2b2afbb0/ab026b47388de623.jpg", "NEWQ H2手机直连移动硬盘USB3.0接口iPhone安卓手机平板存储备咖电脑通用外接硬盘" });
        }
    }
}
