using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Servicos;
using ApiCovid.Infra.BancoDeDados;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ApiCovid.Api
{
    public class Program
    {
        public async static Task Main(string[] args)
        {

        //    await AtualizaDadosComRepositorioExterno();
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        /*
          private static async Task AtualizaDadosComRepositorioExterno()
          {
              var atualiza = new CovidResponseService();
            /  await atualiza.AtualizaBaseDadosApiExternaCasos(new CasosBanco());
              await atualiza.AtualizaBaseDadosApiExternaMortes(new MorteBanco());
          }
        */
    }
}
