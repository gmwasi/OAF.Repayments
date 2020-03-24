using Microsoft.EntityFrameworkCore.Migrations;

namespace Repayments.Web.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO Customers(Id,CustomerName) VALUES (1,'Fred Barasa');
INSERT INTO Customers(Id,CustomerName) VALUES (2,'Imelda Kundu');
INSERT INTO Customers(Id,CustomerName) VALUES (3,'Leah Kundu');
INSERT INTO Customers(Id,CustomerName) VALUES (4,'Beatrice Wafula Machuma');
INSERT INTO Customers(Id,CustomerName) VALUES (5,'John Juma Shitoshe');
INSERT INTO Customers(Id,CustomerName) VALUES (7,'Donald Masika');
INSERT INTO Customers(Id,CustomerName) VALUES (8,'Bilasio Masinde');
INSERT INTO Customers(Id,CustomerName) VALUES (9,'Peter Masinde');
INSERT INTO Customers(Id,CustomerName) VALUES (10,'Francis S. Misiko');
INSERT INTO Customers(Id,CustomerName) VALUES (11,'Peter Wechuli Nakitare');
INSERT INTO Customers(Id,CustomerName) VALUES (12,'Mwanaisha Nekesa');
INSERT INTO Customers(Id,CustomerName) VALUES (13,'John Nyongesa');
            ");

            migrationBuilder.Sql(@"
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (110,'2012, Short Rain','2012-8-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (120,'2013, Long Rain','2013-3-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (130,'2013, Short Rain','2013-8-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (140,'2014, Long Rain','2014-3-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (150,'2014, Short Rain','2014-8-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (160,'2015, Long Rain','2015-3-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (170,'2015, Short Rain','2015-8-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (180,'2016, Long Rain','2016-3-1',0);
INSERT INTO Seasons(Id,SeasonName,StartDate,EndDate) VALUES (190,'2016, Short Rain','2016-8-1',0);
            ");

            migrationBuilder.Sql(@"
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,110,7900,7900);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,110,7900,7900);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,110,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,110,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,120,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,120,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,120,7050,7050);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,120,7050,7000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,120,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,120,5250,5250);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,120,6950,6950);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,120,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,120,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,120,5250,5250);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,120,5250,5250);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,130,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,130,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,130,0,0);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,130,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,130,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,130,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,130,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,130,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,130,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,130,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,130,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,140,4500,4000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,140,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,140,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,140,7900,7900);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,140,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,140,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,140,7900,7900);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,140,7900,7900);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,140,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,140,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,140,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,150,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,150,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,150,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,150,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,150,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,150,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,150,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,150,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,150,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,150,6200,6000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,150,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,160,4500,4000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,160,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,160,6200,5200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,160,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,160,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,170,6200,6000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,170,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,170,4500,4000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,170,4500,4500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,170,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (1,180,6200,600);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (2,180,6200,3000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (3,180,6200,900);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (4,180,6200,4000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (5,180,6200,400);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (7,180,6200,620);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (8,180,6200,6200);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (9,180,4500,500);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (10,180,4500,450);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (11,180,4500,4000);
INSERT INTO CustomerSummaries(CustomerId,SeasonID,TotalCredit,TotalRepaid) VALUES (12,180,4500,450);
            ");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE Customers;");

            migrationBuilder.Sql("TRUNCATE Seasons;");

            migrationBuilder.Sql("TRUNCATE CustomerSummaries;");
        }
    }
}
