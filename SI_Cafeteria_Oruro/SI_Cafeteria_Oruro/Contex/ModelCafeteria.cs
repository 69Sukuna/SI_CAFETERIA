using SI_Cafeteria_Oruro.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SI_Cafeteria_Oruro.Contex
{
    public partial class ModelCafeteria : DbContext
    {
        public ModelCafeteria()
            : base("name=ModelCafeteria")
        {
        }

        //Mapeo de las clases a BBD
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<HistorialVenta> HistorialVenta { get; set; }
        public virtual DbSet<Cliente> Cliente{ get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
    }
}
