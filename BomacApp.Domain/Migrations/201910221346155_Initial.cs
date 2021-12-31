namespace BomacApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BankId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.BankId, cascadeDelete: true)
                .Index(t => t.BankId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Acr = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BusinessPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Acr = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(),
                        StateId = c.Int(nullable: false),
                        UniqueNumber = c.String(),
                        Contact_PPhoneNo = c.String(),
                        Contact_Email = c.String(),
                        Contact_Web = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessPersons", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.PersonRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        ReceiptId = c.Int(nullable: false),
                        ReceiptNumber = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessPersons", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.ReceiptTypes", t => t.ReceiptId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.ReceiptId);
            
            CreateTable(
                "dbo.ReceiptTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity_NoOfSheets = c.Int(nullable: false),
                        Quantity_Reams = c.Int(nullable: false),
                        Quantity_Sheets = c.Int(nullable: false),
                        Balance_NoOfSheets = c.Int(nullable: false),
                        Balance_Reams = c.Int(nullable: false),
                        Balance_Sheets = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        isCredit = c.Boolean(nullable: false),
                        isDamaged = c.Boolean(nullable: false),
                        Destination = c.String(),
                        ItemId = c.Int(nullable: false),
                        StaffNo = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAdded = c.DateTime(nullable: false),
                        RecordId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockItems", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.PersonRecords", t => t.RecordId)
                .Index(t => t.ItemId)
                .Index(t => t.RecordId);
            
            CreateTable(
                "dbo.StockItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        isAvalible = c.Boolean(nullable: false),
                        NoOfSheets = c.Int(nullable: false),
                        NoOfStock_NoOfSheets = c.Int(nullable: false),
                        NoOfStock_Reams = c.Int(nullable: false),
                        NoOfStock_Sheets = c.Int(nullable: false),
                        Manufactuturer = c.String(),
                        CategoryId = c.Int(nullable: false),
                        StaffNo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.StockCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StaffNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        StartService = c.DateTime(nullable: false),
                        EndService = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        StaffNo = c.String(),
                        Contact_PPhoneNo = c.String(),
                        Contact_Email = c.String(),
                        Contact_Web = c.String(),
                        LocationId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.LocationId)
                .Index(t => t.BranchId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        SPhoneNo = c.String(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Staffs", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "StateId", "dbo.States");
            DropForeignKey("dbo.Staffs", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.BusinessPersons", "StateId", "dbo.States");
            DropForeignKey("dbo.StockRecords", "RecordId", "dbo.PersonRecords");
            DropForeignKey("dbo.StockRecords", "ItemId", "dbo.StockItems");
            DropForeignKey("dbo.StockItems", "CategoryId", "dbo.StockCategories");
            DropForeignKey("dbo.PersonRecords", "ReceiptId", "dbo.ReceiptTypes");
            DropForeignKey("dbo.PersonRecords", "PersonId", "dbo.BusinessPersons");
            DropForeignKey("dbo.Payments", "PersonId", "dbo.BusinessPersons");
            DropForeignKey("dbo.BankAccounts", "BankId", "dbo.Banks");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Locations", new[] { "StateId" });
            DropIndex("dbo.Staffs", new[] { "User_Id" });
            DropIndex("dbo.Staffs", new[] { "BranchId" });
            DropIndex("dbo.Staffs", new[] { "LocationId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.StockItems", new[] { "CategoryId" });
            DropIndex("dbo.StockRecords", new[] { "RecordId" });
            DropIndex("dbo.StockRecords", new[] { "ItemId" });
            DropIndex("dbo.PersonRecords", new[] { "ReceiptId" });
            DropIndex("dbo.PersonRecords", new[] { "PersonId" });
            DropIndex("dbo.Payments", new[] { "PersonId" });
            DropIndex("dbo.BusinessPersons", new[] { "StateId" });
            DropIndex("dbo.BankAccounts", new[] { "BankId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Locations");
            DropTable("dbo.Staffs");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PaymentModes");
            DropTable("dbo.States");
            DropTable("dbo.StockCategories");
            DropTable("dbo.StockItems");
            DropTable("dbo.StockRecords");
            DropTable("dbo.ReceiptTypes");
            DropTable("dbo.PersonRecords");
            DropTable("dbo.Payments");
            DropTable("dbo.BusinessPersons");
            DropTable("dbo.Branches");
            DropTable("dbo.Banks");
            DropTable("dbo.BankAccounts");
        }
    }
}
