namespace PrsEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpurchaseline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseRequestLineItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchasRequestID = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseRequestLineItems", "ProductId", "dbo.Products");
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "ProductId" });
            DropTable("dbo.PurchaseRequestLineItems");
        }
    }
}
