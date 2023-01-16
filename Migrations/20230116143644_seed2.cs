using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelExam2022.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.InsertData("Articles", new[] { "Id", "Title", "Content", "Date", "CategoryId" },
                new object[,]
                {
                    {
                        1,
                        "Art1",
                        "Content 1",
                        DateTime.Now.AddSeconds(700000),
                        1
                    },
                    {
                        2,
                        "Art2",
                        "Content 2",
                        DateTime.Now.AddSeconds(60000000),
                        2
                    },
                    {
                        3,
                        "Art3",
                        "Content 3",
                        DateTime.Now.AddSeconds(500000),
                        3
                    },
                     {
                        4,
                        "Art4",
                        "Content 4",
                        DateTime.Now.AddSeconds(300000),
                        2
                    },
                    {
                        5,
                        "Art5",
                        "Content 5",
                        DateTime.Now.AddSeconds(1000000),
                        1
                    }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Articles", keyColumn: "Id", keyValue: 1);
            migrationBuilder.DeleteData("Articles", keyColumn: "Id", keyValue: 2);
            migrationBuilder.DeleteData("Articles", keyColumn: "Id", keyValue: 3);
            migrationBuilder.DeleteData("Articles", keyColumn: "Id", keyValue: 4);
            migrationBuilder.DeleteData("Articles", keyColumn: "Id", keyValue: 5);


        }
    }
}
