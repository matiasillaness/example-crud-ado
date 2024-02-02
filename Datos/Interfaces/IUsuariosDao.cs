using Example_julian.Dominio;

namespace Example_julian.Datos.Interfaces
{
    public interface IUsuariosDao
    {
        List<Usuario> getAllUsuario();
        Usuario getUsuarioById(int id);
        bool saveUsuario(Usuario usuario);
    }
}
