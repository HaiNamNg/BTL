namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1234 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lops", "MaMonHoc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lops", "MaMonHoc", c => c.String());
        }
    }
}
