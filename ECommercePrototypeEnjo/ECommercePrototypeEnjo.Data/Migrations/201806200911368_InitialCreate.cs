namespace ECommercePrototypeEnjo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        InsertedOn = c.DateTime(nullable: false),
                        InsertedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        InsertedOn = c.DateTime(nullable: false),
                        InsertedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Thumbnail = c.String(),
                        Price = c.Double(nullable: false),
                        InsertedOn = c.DateTime(nullable: false),
                        InsertedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCartItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ShoppingCartItems", "CustomerId", "dbo.Customers");
            DropIndex("dbo.ShoppingCartItems", new[] { "ProductId" });
            DropIndex("dbo.ShoppingCartItems", new[] { "CustomerId" });
            DropTable("dbo.Products");
            DropTable("dbo.ShoppingCartItems");
            DropTable("dbo.Customers");
        }
    }
}
