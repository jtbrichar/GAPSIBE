using e_commerce.Models;
using e_commerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    [Route("api/proveedor")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public dynamic Lista()
        {
            ProveedoresService clase = new ProveedoresService();
            List<Proveedores> Result = clase.ListaProveedores();
            return Result;
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public void Nuevo(Proveedores nuevo)
        {
            ProveedoresService clase = new ProveedoresService();
            List<Proveedores> Result = clase.ListaProveedores();

            clase.AgregarProveedor(nuevo);
            
        }

        [Microsoft.AspNetCore.Mvc.HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("{Id}")]
        public void Borrar(int Id)
        {
            ProveedoresService clase = new ProveedoresService();

            clase.EliminarProveedores(Id);

        }
    }
}
