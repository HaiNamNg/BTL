namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoaa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        MaKhoa = c.String(nullable: false, maxLength: 128),
                        TenKhoa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhoa);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(nullable: false),
                        GVCN = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lops");
            DropTable("dbo.Khoas");
        }
    }
}
