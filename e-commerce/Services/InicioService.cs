using e_commerce.Models;
using Newtonsoft.Json;

namespace e_commerce.Services
{
    public class InicioService
    {
        string Ruta= System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Identity\Inicio.json");
        
        public Inicio Informacion()
        {
            string tmp = File.ReadAllText(Ruta);
            Inicio Informacion = new Inicio();
            Informacion = JsonConvert.DeserializeObject<Inicio>(tmp);

            string pausa = "";

            return Informacion;
        }
    }
}
