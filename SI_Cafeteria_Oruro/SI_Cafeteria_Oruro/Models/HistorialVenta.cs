using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Cafeteria_Oruro.Models
{
    public class HistorialVenta
    {
        [Key]
        public int IdVenta { get; set; }

        [Required]
        public DateTime FechVenta { get; set; }

        [Required]
        public float TotalVenta { get; set; }

        //FORENKEY
        //Muchos historiales de venta tienen 1 usuario
        public Usuario Usuario { get; set; }

        //Muchos Historiales de venta tienen 1 cliente
        public Cliente Cliente { get; set; }

        //Muchos Historiales de venta tienen 1 cliente
        public Producto Producto { get; set; }
    }
}
