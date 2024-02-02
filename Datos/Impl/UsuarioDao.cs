using Example_julian.Datos.Interfaces;
using Example_julian.Dominio;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Example_julian.Datos.Impl
{
    public class UsuarioDao : IUsuariosDao
    {
        HelperDao helperDao = new HelperDao();


        public List<Usuario> getAllUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                DataTable tabla = helperDao.Consultar("SP_ALL_USUARIOS");

                foreach (DataRow row in tabla.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(row["Id"]);
                    usuario.Name = (string)row["Name"];
                    usuario.Email = (string)row["Email"];
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, registrarla)
                Console.WriteLine($"Error al obtener usuarios: {ex.Message}");
                throw; // Puedes decidir si quieres propagar la excepción o manejarla de otra manera
            }

            return usuarios;
        }

        public Usuario getUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

        public bool saveUsuario(Usuario usuario)
        {
            bool flag = true;
            Usuario usuario1 = new Usuario();

            try
            {
                List<Parametro> lista_parametros = new List<Parametro>();
                lista_parametros.Add(new Parametro("@Nombre", usuario1.Name));
                lista_parametros.Add(new Parametro("@Email", usuario1.Email));

                helperDao.EjecutarSQL("SP_GRABAR_USUARIO", lista_parametros);
            }
            catch(Exception ex)
            {
                Console.WriteLine("error");
                return false;
            }

           

            return true;
        }
    }
}
