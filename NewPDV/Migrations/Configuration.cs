namespace NewPDV.Migrations
{
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Util;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewPDV.Model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NewPDV.Model context)
        {
            using (var cont = new NewPDV.Model())
            {
                var retorno = new List<Usuarios>();
                retorno = (from x in cont.TabUsuarios where x.USU_CODIGO == 1 select x).ToList();
                if (retorno.Count == 0)
                {
                    IList<Usuarios> us = new List<Usuarios>();
                    us.Add(new Usuarios()
                    {
                        USU_CODIGO = 1,
                        USU_USUARIO = "MASTER",
                        USU_SENHA = "123",
                        USU_ATUALIZACAO = DateTime.Now,
                        USU_CADASTRO = DateTime.Now,
                        USU_INATIVO = false
                    });
                    cont.TabUsuarios.AddRange(us);
                    cont.SaveChanges();
                }


                var retorno2 = new List<UsuarioAcesso>();
                retorno2 = (from x in cont.TabAcessoUsuarios where x.UAC_USUARIO == 1 select x).ToList();
                if (retorno2.Count == 0)
                {
                    IList<UsuarioAcesso> uac = new List<UsuarioAcesso>();
                    uac.Add(new UsuarioAcesso()
                    {
                        UAC_USUARIO = 1,
                        UAC_ACESSO = "***"
                    });
                    cont.TabAcessoUsuarios.AddRange(uac);
                    cont.SaveChanges();
                }
                
            }
            base.Seed(context);
        }
    }
}
