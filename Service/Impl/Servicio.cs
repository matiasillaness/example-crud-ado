using Example_julian.Datos.Impl;
using Example_julian.Datos.Interfaces;
using Example_julian.Dominio;

namespace Example_julian.Service.Impl
{
    public class Servicio : IServicio
    {
        private IUsuariosDao _usuariosDao;
        public Servicio() {
            _usuariosDao = new UsuarioDao();
        }

        public List<Usuario> getAllUsuario()
        {
            return _usuariosDao.getAllUsuario();
        }


        Usuario IServicio.getUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

  

        bool IServicio.saveUsuario(Usuario usuario)
        {
            return _usuariosDao.saveUsuario(usuario);
        }
    }
}
