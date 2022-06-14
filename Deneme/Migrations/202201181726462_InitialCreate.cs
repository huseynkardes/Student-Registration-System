namespace Deneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aka_ders",
                c => new
                    {
                        akaId = c.Int(nullable: false, identity: true),
                        pkod = c.Int(nullable: false),
                        dkod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.akaId)
                .ForeignKey("dbo.Akademik", t => t.pkod)
                .ForeignKey("dbo.Ders", t => t.dkod)
                .Index(t => t.pkod)
                .Index(t => t.dkod);
            
            CreateTable(
                "dbo.Akademik",
                c => new
                    {
                        pkod = c.Int(nullable: false, identity: true),
                        sicilno = c.Int(nullable: false),
                        padi = c.String(nullable: false, maxLength: 50, unicode: false),
                        psoyadi = c.String(nullable: false, maxLength: 50, unicode: false),
                        bolumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pkod)
                .ForeignKey("dbo.Bolumler", t => t.bolumId)
                .Index(t => t.bolumId);
            
            CreateTable(
                "dbo.Bolumler",
                c => new
                    {
                        bolumId = c.Int(nullable: false, identity: true),
                        badi = c.String(nullable: false),
                        bolumbskn = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bolumId)
                .ForeignKey("dbo.Akademik", t => t.bolumbskn)
                .Index(t => t.bolumbskn);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        dkod = c.Int(nullable: false, identity: true),
                        dadi = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.dkod);
            
            CreateTable(
                "dbo.Notlar",
                c => new
                    {
                        notId = c.Int(nullable: false, identity: true),
                        no = c.Int(nullable: false),
                        dkod = c.Int(nullable: false),
                        vize = c.Int(nullable: false),
                        final = c.Int(nullable: false),
                        durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.notId)
                .ForeignKey("dbo.Ders", t => t.dkod)
                .Index(t => t.dkod);
            
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        no = c.Int(nullable: false, identity: true),
                        ad = c.String(),
                        soyadi = c.String(),
                        bolumid = c.Int(nullable: false),
                        dtar = c.DateTime(nullable: false),
                        adres = c.String(),
                        tcno = c.Int(nullable: false),
                        cinsiyet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.no)
                .ForeignKey("dbo.Bolumler", t => t.bolumid)
                .Index(t => t.bolumid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogrenci", "bolumid", "dbo.Bolumler");
            DropForeignKey("dbo.Notlar", "dkod", "dbo.Ders");
            DropForeignKey("dbo.Aka_ders", "dkod", "dbo.Ders");
            DropForeignKey("dbo.Aka_ders", "pkod", "dbo.Akademik");
            DropForeignKey("dbo.Bolumler", "bolumbskn", "dbo.Akademik");
            DropForeignKey("dbo.Akademik", "bolumId", "dbo.Bolumler");
            DropIndex("dbo.Ogrenci", new[] { "bolumid" });
            DropIndex("dbo.Notlar", new[] { "dkod" });
            DropIndex("dbo.Bolumler", new[] { "bolumbskn" });
            DropIndex("dbo.Akademik", new[] { "bolumId" });
            DropIndex("dbo.Aka_ders", new[] { "dkod" });
            DropIndex("dbo.Aka_ders", new[] { "pkod" });
            DropTable("dbo.Ogrenci");
            DropTable("dbo.Notlar");
            DropTable("dbo.Ders");
            DropTable("dbo.Bolumler");
            DropTable("dbo.Akademik");
            DropTable("dbo.Aka_ders");
        }
    }
}
