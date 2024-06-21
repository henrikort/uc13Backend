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
        public string CalculateMedia(float n1, float n2, float frequencia)
        {
           
            float media = (n1 + n2 ) / 2;

            if (media >= 7 && frequencia >= 75)
            {
                return "aprovado";
            }
            else 
            {
                return "reprovado";
            }
        }

        [HttpGet]
        [Route("CalculateMedia3")]
        public string CalculateMedia3(float n1, float n2)
        {

            float media = (n1 + n2) / 2;

            if (media >= 7 )
            {
                return "aprovado";
            }
            if (media <= 6 && media >= 5)
            {
                return "revisao";

            }
            else 
            {
                return "reprovado";
            }
          
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
