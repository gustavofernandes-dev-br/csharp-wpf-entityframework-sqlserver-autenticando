using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NewPDV
{
    [Table("USUARIOACESSO")]
    public class UsuarioAcesso
    {
        [Key,Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UAC_USUARIO { get; set; }
                
        //[StringLength (100)]
        public string UAC_ACESSO { get; set; }

    }
}
