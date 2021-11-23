namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hehehe : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccountModels", newName: "Accounts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Accounts", newName: "AccountModels");
        }
    }
}
