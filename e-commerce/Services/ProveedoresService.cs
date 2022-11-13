using e_commerce.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace e_commerce.Services
{
    public class ProveedoresService
    {
        string Ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Identity\bd.json");
        public List<Proveedores> ListaProveedores()
        {
            string tmp = File.ReadAllText(Ruta);
            List <Proveedores> Resultado = new List<Proveedores>();
            Resultado = JsonConvert.DeserializeObject<List<Proveedores>>(tmp);
            return Resultado;
        }
        public void AgregarProveedor(Proveedores proveedor)
        {
            string tmp = File.ReadAllText(Ruta);
            List<Proveedores> BD = new List<Proveedores>();
            BD = JsonConvert.DeserializeObject<List<Proveedores>>(tmp);

            int count = (from x in BD where x.Nombre == proveedor.Nombre select x).Count();

            if (count==0)
            {
                int existe = (from x in BD select x).Count();
                if (existe == 0)
                {
                    proveedor.Id = 1;
                }
                else
                {
                    var res = BD.Max(a => a.Id);
                    proveedor.Id = res + 1;
                }
                
                BD.Add(proveedor);
                string info = JsonConvert.SerializeObject(BD);
                File.WriteAllText(Ruta, info);
            }
        }
        public void EliminarProveedores(int Id)
        {
            string tmp = File.ReadAllText(Ruta);
            List<Proveedores> BD = new List<Proveedores>();
            BD = JsonConvert.DeserializeObject<List<Proveedores>>(tmp);

            BD.RemoveAll((x) => x.Id == Id);

            string info = JsonConvert.SerializeObject(BD);
            File.WriteAllText(Ruta, info);

        }
    }
}
