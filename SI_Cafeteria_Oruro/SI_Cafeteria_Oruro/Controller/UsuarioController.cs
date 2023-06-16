using SI_Cafeteria_Oruro.Contex;
using SI_Cafeteria_Oruro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Cafeteria_Oruro.Controller
{
    internal class UsuarioController
    {
        ModelCafeteria _context = new ModelCafeteria();

        public bool Login(string username, string password)
        {
            var UsuarioLogin = _context.Usuario
                .Where(x => x.NomUser == username && x.PaswordUser == password)
                .SingleOrDefault();

            if(UsuarioLogin != null )
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        //Devolucion de todo
        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }

        //Dvuelve 1
        public Usuario Get(String nombeUsuario) 
        {
            return _context.Usuario.Find(nombeUsuario);
        }

        //Busqueda
        public List<Usuario> Search(String par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetAll();
            }
            else
            {
                return _context.
                    Usuario.Where(x => x.NomUser.Contains(par)
                    || x.NombreCompleto.Contains(par)).ToList();
            }
        }

        //Crear, Actualizar, Eliminar
        public bool Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            return _context.SaveChanges() > 0;
        }
        
        public bool Update(Usuario usuario)
        {
            _context.Usuario.Attach(usuario);
            //Modificacion de registro
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(Usuario usuario) 
        {
            _context.Usuario.Remove(usuario);
            return _context.SaveChanges() > 0; //Guarda los cambios en BDD
        }
    }
}
