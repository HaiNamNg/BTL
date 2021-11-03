namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        HoVaTen = c.String(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        MaLop = c.String(),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhVien");
        }
    }
}
