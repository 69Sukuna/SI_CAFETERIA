using SI_Cafeteria_Oruro.Contex;
using SI_Cafeteria_Oruro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Cafeteria_Oruro.Controller
{
    internal class ProductoController
    {
        ModelCafeteria _context = new ModelCafeteria();
        //Devolucion de todo
        public List<Producto> GetAll()
        {
            return _context.Producto.ToList();
        }

        //Dvuelve 1
        public Producto Get(String nombeProducto)
        {
            return _context.Producto.Find(nombeProducto);
        }

        //Busqueda
        public List<Producto> Search(String par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetAll();
            }
            else
            {
                return _context.
                    Producto.Where(x => x.NomProduct.Contains(par)).ToList();
            }
        }

        //Crear, Actualizar, Eliminar
        public bool Create(Producto producto)
        {
            String texto = producto.NomProduct;
            producto.NomProduct = string.Join(" ", texto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            _context.Producto.Add(producto);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Producto producto)
        {
            _context.Producto.Attach(producto);
            //Modificacion de registro
            _context.Entry(producto).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(Producto producto)
        {
            _context.Producto.Remove(producto);
            return _context.SaveChanges() > 0; //Guarda los cambios en BDD
        }


    }
}


