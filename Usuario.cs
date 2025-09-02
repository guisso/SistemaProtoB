using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaProtoB
{
    [Table("tbl_usuario")]
    public class Usuario
    {
        // [Key] ... UsuarioId ...
        public Int64 Id { get; set; }

        [Required]
        [MaxLength(45)]
        public String? Nome { get; set; }

        //public Credencial Credencial { get; set; }

        public override String ToString()
        {
            return Id
                + ", " + Nome;
        }
    }
}
