using Example_julian.Datos.Impl;
using Example_julian.Datos.Interfaces;
using Example_julian.Dominio;
using Example_julian.Service;
using Example_julian.Service.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json;
using System.Text.Json;

namespace Example_julian.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosController : Controller
    {
        private IServicio _usuarios;
        private FabricaServicios oFabrica;

        public UsuariosController()
        {
        
            oFabrica = new FabricaServiciosImp();
            _usuarios = oFabrica.CrearServicio();
        }

      

        [HttpGet]
        public String getAll()
        {
            List<Usuario> lst = _usuarios.getAllUsuario();
            string json = JsonConvert.SerializeObject(lst, Formatting.Indented);
            return json;

        }




        //Post user
        //Edit

    }
}
