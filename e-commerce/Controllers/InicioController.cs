
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using e_commerce.Services;
using e_commerce.Models;
using System.Web.Http.Cors;

namespace e_commerce.Controllers
{

    [Microsoft.AspNetCore.Mvc.Route("api/principal")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InicioController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public dynamic Lista()
        {
            InicioService clase = new InicioService();

            Inicio Result = clase.Informacion();
            return Result;
        }
    }
}
