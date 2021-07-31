using ApiCovid.Dominio.Objetos_base;
using ApiCovid.Dominio.Servicos;
using ApiCovid.Infra.BancoDeDados;
using Microsoft.AspNetCore.Mvc;

namespace ApiCovid.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MortesController : Controller
    {
        private MortesServico _servico;

        public MortesController()
        {
            _servico = new MortesServico(new MorteBanco());
        }

        [HttpPost]
        public IActionResult Post(Mortes Obitos)
        {
            _servico.Inserir(Obitos);
            return Ok();
        }

        [HttpGet("{idSemana}")]
        public JsonResult PegaMediaMovelSemanal(int idSemana) // trocar, n funciona mais assim
        {
                
            return new JsonResult(_servico.MediaMovelSemanal(idSemana));
        }
    }
}
