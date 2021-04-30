using Microsoft.EntityFrameworkCore.Migrations;

namespace XtremaxInterviewWebApp.Data.Migrations
{
    public partial class AddStatusSeedsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Statuses(Name) Values ('Open')");
            migrationBuilder.Sql("Insert Into Statuses(Name) Values ('In Progress')");
            migrationBuilder.Sql("Insert Into Statuses(Name) Values ('Done')");
            migrationBuilder.Sql("Insert Into Statuses(Name) Values ('Closed')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
