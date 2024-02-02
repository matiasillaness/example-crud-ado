using Example_julian.Dominio;

namespace Example_julian.Service
{
    public interface IServicio
    {
        List<Usuario> getAllUsuario();
        Usuario getUsuarioById(int id);
        bool saveUsuario(Usuario usuario);
    }
}
