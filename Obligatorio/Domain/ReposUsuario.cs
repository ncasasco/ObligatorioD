using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ReposUsuario
    {
        private List<Usuario> usuarios;

        public ReposUsuario()
        {
            usuarios = new List<Usuario>();
        }

        public void Add(Usuario usuario)
        {
            if(usuarios.Any(u => u.Nombre == usuario.Nombre))
            {
                throw new UsuarioExisteException("El usuario ya existe");
            }
            usuarios.Add(usuario);
        }

        public bool IsEmpty()
        {
            return !usuarios.Any();
        }

        public bool Exists(string nombre)
        {
            return usuarios.Any(u => u.Nombre == nombre);
        }

        public Usuario Get(string nombre)
        {
            Usuario result = usuarios.FirstOrDefault(u => u.Nombre == nombre);
            if (result == null)
            {
                throw new UsuarioNoEncontradoException("Usuario no encontrado");
            }
            return result;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarios.AsEnumerable();
        }

        public void Delete (string nombre)
        {
            int deleted = usuarios.RemoveAll(u => u.Nombre == nombre);
            if (deleted == 0)
            {
                throw new UsuarioNoEncontradoException("Usuario no encontrado");
            }
        }
    }
}
