using SI_Cafeteria_Oruro.Contex;
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
    }
}
