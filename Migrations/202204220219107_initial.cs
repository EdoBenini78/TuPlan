namespace TuPlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inmuebles", "Mascota", c => c.Boolean(nullable: false));
            AddColumn("dbo.Inmuebles", "Amueblado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Inmuebles", "Dormitorios", c => c.Int(nullable: false));
            AddColumn("dbo.Inmuebles", "Garantia", c => c.String());
            AddColumn("dbo.Inmuebles", "Propietario", c => c.String());
            AddColumn("dbo.Inmuebles", "MailPropietario", c => c.String());
            AddColumn("dbo.Inmuebles", "Esquina", c => c.String());
            DropColumn("dbo.Inmuebles", "Duenio");
            DropColumn("dbo.Inmuebles", "MailDuenio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inmuebles", "MailDuenio", c => c.String());
            AddColumn("dbo.Inmuebles", "Duenio", c => c.String());
            DropColumn("dbo.Inmuebles", "Esquina");
            DropColumn("dbo.Inmuebles", "MailPropietario");
            DropColumn("dbo.Inmuebles", "Propietario");
            DropColumn("dbo.Inmuebles", "Garantia");
            DropColumn("dbo.Inmuebles", "Dormitorios");
            DropColumn("dbo.Inmuebles", "Amueblado");
            DropColumn("dbo.Inmuebles", "Mascota");
        }
    }
}
