namespace ConsoleApplicationDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UnitsInStock = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Unitprice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CompanyName = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CompanyName);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(maxLength: 128),
                        ProductID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        OrderDetails = c.String(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CompanyName)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CompanyName)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "CompanyName", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "CompanyName" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
