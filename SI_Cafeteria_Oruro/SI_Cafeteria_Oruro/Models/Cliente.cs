using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Cafeteria_Oruro.Models
{
    public class Cliente
    {
        [Key]
        public int IdClient { get; set; }

        [Required]
        public String NomClient { get; set; }
    }
}
