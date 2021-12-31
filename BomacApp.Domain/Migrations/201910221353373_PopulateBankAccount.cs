namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBankAccount : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO BankAccounts (BankId, Name) VALUES (1, '5080121958')");
            Sql("INSERT INTO BankAccounts (BankId, Name) VALUES (2, '0731191473')");
        }
        
        public override void Down()
        {
        }
    }
}
