namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Lops");
            DropPrimaryKey("dbo.SinhVien");
            AddColumn("dbo.Lops", "GiaoVien", c => c.String(nullable: false));
            AddColumn("dbo.Lops", "MaMonHoc", c => c.String());
            AddColumn("dbo.SinhVien", "Sdt", c => c.String(nullable: false));
            AlterColumn("dbo.Lops", "MaLop", c => c.String(nullable: false));
            AlterColumn("dbo.Lops", "TenLop", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SinhVien", "MaSinhVien", c => c.String(nullable: false));
            AlterColumn("dbo.SinhVien", "HoVaTen", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Lops", "TenLop");
            AddPrimaryKey("dbo.SinhVien", "HoVaTen");
            DropColumn("dbo.Lops", "GVCN");
            DropColumn("dbo.SinhVien", "MaLop");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SinhVien", "MaLop", c => c.String());
            AddColumn("dbo.Lops", "GVCN", c => c.String(nullable: false));
            DropPrimaryKey("dbo.SinhVien");
            DropPrimaryKey("dbo.Lops");
            AlterColumn("dbo.SinhVien", "HoVaTen", c => c.String(nullable: false));
            AlterColumn("dbo.SinhVien", "MaSinhVien", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Lops", "TenLop", c => c.String(nullable: false));
            AlterColumn("dbo.Lops", "MaLop", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.SinhVien", "Sdt");
            DropColumn("dbo.Lops", "MaMonHoc");
            DropColumn("dbo.Lops", "GiaoVien");
            AddPrimaryKey("dbo.SinhVien", "MaSinhVien");
            AddPrimaryKey("dbo.Lops", "MaLop");
        }
    }
}
