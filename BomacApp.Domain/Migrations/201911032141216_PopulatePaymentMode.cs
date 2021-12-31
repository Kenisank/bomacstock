namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePaymentMode : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PaymentModes (Name) VALUES ('Bank Deposit')");
            Sql("INSERT INTO PaymentModes (Name) VALUES ('Bank Transfer')");
            Sql("INSERT INTO PaymentModes (Name) VALUES ('Cash')");
            Sql("INSERT INTO PaymentModes (Name) VALUES ('Cheque')");
            Sql("INSERT INTO PaymentModes (Name) VALUES ('POS')");
          
        }
        
        public override void Down()
        {
        }
    }
}
