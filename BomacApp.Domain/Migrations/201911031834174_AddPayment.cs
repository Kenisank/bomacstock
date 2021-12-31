namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BankAccounts", "Number", c => c.String());
            AddColumn("dbo.Payments", "ModeId", c => c.Int(nullable: false));
            AddColumn("dbo.Payments", "Ref", c => c.String());
            AddColumn("dbo.Payments", "PaymentNo", c => c.String());
            AddColumn("dbo.Payments", "AccountId", c => c.Int(nullable: false));
            AddColumn("dbo.Payments", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payments", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.StockRecords", "PendingBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Payments", "ModeId");
            CreateIndex("dbo.Payments", "AccountId");
            AddForeignKey("dbo.Payments", "AccountId", "dbo.BankAccounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Payments", "ModeId", "dbo.PaymentModes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "ModeId", "dbo.PaymentModes");
            DropForeignKey("dbo.Payments", "AccountId", "dbo.BankAccounts");
            DropIndex("dbo.Payments", new[] { "AccountId" });
            DropIndex("dbo.Payments", new[] { "ModeId" });
            DropColumn("dbo.StockRecords", "PendingBalance");
            DropColumn("dbo.Payments", "Type");
            DropColumn("dbo.Payments", "DateAdded");
            DropColumn("dbo.Payments", "AccountId");
            DropColumn("dbo.Payments", "PaymentNo");
            DropColumn("dbo.Payments", "Ref");
            DropColumn("dbo.Payments", "ModeId");
            DropColumn("dbo.BankAccounts", "Number");
        }
    }
}
