using ApiCovid.Dominio.Interface.Servicos;
using ApiCovid.Dominio.Objetos_base;
using ApiCovid.Dominio.Servicos;
using ApiCovid.Infra.BancoDeDados;
using Microsoft.AspNetCore.Mvc;

namespace ApiCovid.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasosController : Controller
    {
        private IServicoDados _servico;

        public CasosController()
        {
            _servico = new CasosServico(new CasosBanco());
        }

        [HttpPost]
        public IActionResult Post(Casos Caso)
        {
            _servico.Inserir(Caso);
            return Ok();
        }

        [HttpGet("{idSemana}")]
        public JsonResult PegaMediaMovelSemanal(int idSemana) // trocar, n funciona mais assim
        {

            return new JsonResult(_servico.MediaMovelSemanal(idSemana));
        }
    }
}
