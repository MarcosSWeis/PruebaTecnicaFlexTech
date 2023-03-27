using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaFlexTech.Models;

namespace PruebaTecnicaFlexTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BCRAController :ControllerBase
    {


        [HttpGet("{information}")]
        public IActionResult GetJson(string information)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");

            return Ok(new { fecha = date,informacion = information.ToUpper() });
        }

        //Agrego esta forma proque me parecio una forma mas orderna de plantear el ejercicio, haciendo mencion a lo que hablamos de clases
        //si bien en le otro metodo uso una clase anonima que me devuelve los mismo un string fecha y el string del input en mayuscula
        //en este metodo contamos con el tipo de dato que devuelve eso parametros (InformationJson) y podemos controlar lo que devolvemos

        //[HttpGet("{information}")]
        //public InformationJson GetJsonRefactor(string information)
        //{
        //    InformationJson info = new(DateTime.Now,information.ToUpper());
        //    return info;
        //}
    }
}
