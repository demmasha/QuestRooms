namespace QuestRoomsDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(),
                        City_ID = c.Int(),
                        Country_ID = c.Int(),
                        Street_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.City_ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .ForeignKey("dbo.Streets", t => t.Street_ID)
                .Index(t => t.City_ID)
                .Index(t => t.Country_ID)
                .Index(t => t.Street_ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fotoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Room_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.Room_ID)
                .Index(t => t.Room_ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desctiptions = c.String(),
                        Time = c.Time(nullable: false, precision: 7),
                        MinPlayers = c.Int(nullable: false),
                        MaxPlayers = c.Int(nullable: false),
                        MinYears = c.Int(nullable: false),
                        NamberFone = c.Int(nullable: false),
                        Email = c.String(),
                        Rating = c.Int(nullable: false),
                        Fear = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        Logo = c.String(),
                        Address_ID = c.Int(),
                        Company_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID)
                .ForeignKey("dbo.Companies", t => t.Company_ID)
                .Index(t => t.Address_ID)
                .Index(t => t.Company_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fotoes", "Room_ID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Company_ID", "dbo.Companies");
            DropForeignKey("dbo.Rooms", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Street_ID", "dbo.Streets");
            DropForeignKey("dbo.Addresses", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_ID", "dbo.Cities");
            DropIndex("dbo.Rooms", new[] { "Company_ID" });
            DropIndex("dbo.Rooms", new[] { "Address_ID" });
            DropIndex("dbo.Fotoes", new[] { "Room_ID" });
            DropIndex("dbo.Addresses", new[] { "Street_ID" });
            DropIndex("dbo.Addresses", new[] { "Country_ID" });
            DropIndex("dbo.Addresses", new[] { "City_ID" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Fotoes");
            DropTable("dbo.Companies");
            DropTable("dbo.Streets");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
