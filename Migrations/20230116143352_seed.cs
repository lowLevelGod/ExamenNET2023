using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelExam2022.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Categories", new[] { "Id", "Title" },
                new object[,]
                {
                    {
                        1,
                        "C1"
                    },
                    {
                        2,
                        "C2"
                    },
                    {
                        3,
                        "C3"
                    }
                });

         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DeleteData("Categories", keyColumn: "Id", keyValue: 1);
            migrationBuilder.DeleteData("Categories", keyColumn: "Id", keyValue: 2);
            migrationBuilder.DeleteData("Categories", keyColumn: "Id", keyValue: 3);
        }
    }
}
