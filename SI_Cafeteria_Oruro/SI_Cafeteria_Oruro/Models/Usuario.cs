using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Cafeteria_Oruro.Models
{
    public class Usuario
    {
        [Key]
        public String NomUser{ get; set; }

        [Required]
        public String PaswordUser{ get; set; }

        [Required]
        public String NombreCompleto{ get; set; }

        [Required]
        public String CargoUser { get; set; }

        [Required]
        public  bool EstadoUser { get; set; }

        //Integridad Referencial
        //un Usuario Registra muchos HistorialesVenta

        public List<HistorialVenta> HistorialVenta { get; set; }
        
    }
}
