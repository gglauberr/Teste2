using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Nome { get; set; }
        [Required, MaxLength(50)]
        public string Telefone { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
    }
}
