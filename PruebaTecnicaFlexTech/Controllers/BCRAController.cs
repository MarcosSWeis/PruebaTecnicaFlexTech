using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaTecnicaFlexTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BCRAController :ControllerBase
    {


        [HttpGet("{information}")]
        public ActionResult GetJson(string information)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");

            return Ok(new { fecha = date,informacion = information.ToUpper() });
        }
    }
}
