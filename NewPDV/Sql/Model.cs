namespace NewPDV
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using NewPDV.Sql;
    using NewPDV.Migrations;

    public class Model : DbContext
    {
        public virtual DbSet<Usuarios> TabUsuarios { get; set; }
        public virtual DbSet<UsuarioAcesso> TabAcessoUsuarios { get; set; }

        public Model() : base(ConexaoSql.RetornarConexaoEntity())
        {
            this.Database.Connection.ConnectionString = ConexaoSql.RetornarConexaoEntity();
            //DbMigrationsConfiguration<Model> conf = new DbMigrationsConfiguration<Model>();

            //Desabilita migração
            //Database.SetInitializer<Model>(null);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model, Configuration>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model, conf>);////
            //Database.SetInitializer<Model>(new DropCreateDatabaseIfModelChanges<Model>());

            //descarta o banco
            //Database.SetInitializer<Model>(new DropCreateDatabaseAlways<Model>());

        }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}