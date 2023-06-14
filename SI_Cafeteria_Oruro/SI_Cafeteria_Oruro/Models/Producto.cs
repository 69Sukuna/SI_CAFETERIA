using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Cafeteria_Oruro.Models
{
    public class Producto
    {
        [Key]
        public String NomProduct { get; set; }

        [Required]
        public int CantProduct { get; set; }

        [Required]
        public float PrecioProduct { get; set; }

        //Integridad Referencial
        //un Producto tiene muchos HistorialesVenta

        public List<HistorialVenta> HistorialVenta { get; set; }

    }
}
