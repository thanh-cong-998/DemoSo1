namespace DemoSo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoa",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHang = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        ID_HD = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHoaDon = c.String(),
                        NgayMua = c.DateTime(nullable: false),
                        ID = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.ID_HD)
                .ForeignKey("dbo.HangHoa", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "ID", "dbo.HangHoa");
            DropIndex("dbo.HoaDons", new[] { "ID" });
            DropTable("dbo.HoaDons");
            DropTable("dbo.HangHoa");
        }
    }
}
