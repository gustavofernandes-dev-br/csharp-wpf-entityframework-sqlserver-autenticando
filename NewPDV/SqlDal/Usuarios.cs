using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

namespace NewPDV
{
    [Table("USUARIOS")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ConcurrencyCheck]
        public int USU_CODIGO { get; set; }

        [Required(ErrorMessage = "Necessário usuário!!!")]
        [StringLength(30)]
        public string USU_USUARIO { get; set; }
        [Required(ErrorMessage = "Senha invalida!!!")]
        public string USU_SENHA { get; set; }
        public DateTime? USU_CADASTRO { get; set; }
        public DateTime? USU_ATUALIZACAO { get; set; }
        public bool? USU_INATIVO { get; set; }

        public bool ValidarUsuario(string usuario, string senha, Usuarios parUser)
        {
            Usuarios sClsUsuarios = new Usuarios();
            parUser = sClsUsuarios;
            using (var us = new Model())
            {
                var retorno = new List<Usuarios>();
                if (senha == "")
                    retorno = (from x in us.TabUsuarios where x.USU_USUARIO == usuario select x).ToList();
                else
                    retorno = (from x in us.TabUsuarios where x.USU_USUARIO == usuario && x.USU_SENHA == senha select x).ToList();

                if (retorno.Count == 0)
                {
                    parUser = null;
                    return false;
                }
                else
                {
                    parUser = retorno[0];
                    return true;
                }
            }
        }
        public List<Usuarios> lista()
        {
            using (var us = new Model())
            {
                return (from x in us.TabUsuarios where x.USU_INATIVO == false select x).ToList();
            }
        }

    }
}
