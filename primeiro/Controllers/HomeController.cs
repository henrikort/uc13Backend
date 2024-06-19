using Microsoft.AspNetCore.Mvc;

namespace primeiro.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("HandShake")]
        public string HandShake()
        {
            return "ok";
        }
        [HttpGet]
        [Route("CalculateMedia")]
        public float CalculateMedia(float n1, float n2, float n3)
        {
            float resultado;
            resultado = (n1 + n2 + n3) / 3;
            return resultado;        
        }

        [HttpGet]
        [Route("GetValue")]
        public int GetValue(int initial, int final)
        { 
            return GenerateValue(initial, final);
        }

        // metodo que nao sera exposto na api   x
        [NonAction]
        private int GenerateValue (int initial, int final) 
        {
           Random rnd = new Random();
            return rnd.Next (initial, final+1);
        }

    }
}
