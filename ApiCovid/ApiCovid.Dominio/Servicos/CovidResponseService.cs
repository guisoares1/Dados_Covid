using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Objetos_base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiCovid.Dominio.Servicos
{
    public class CovidResponseService
    {
        public async Task AtualizaBaseDadosApiExternaCasos(IBancoDados _banco)
        {   
            var DataUltimoRegistroInserido = _banco.DataUltimoRegistroInserido().AddDays(1);
            var client = new HttpClient();
            var url = "https://api.covid19api.com/total/country/brazil/status/confirmed?from=" + DataUltimoRegistroInserido.ToString("yyyy-MM-ddTHH:mm:ss") + "&to=" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") + "Z";
            
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            List<CovidResponse> Casos = JsonConvert.DeserializeObject<List<CovidResponse>>(result);

            Casos casos = new Casos();
            foreach (CovidResponse CasosDado in Casos)
            {
                casos.data_dado = CasosDado.Date;
                casos.quantidadeCasos = CasosDado.Cases;
                Validacao.ValidaInsercao(casos.GetData());
                _banco.Inserir(casos);

            }
        }

        public async Task AtualizaBaseDadosApiExternaMortes(IBancoDados _banco)
        {   
            var DataUltimoRegistroInserido = _banco.DataUltimoRegistroInserido().AddDays(1);
            var client = new HttpClient();
            var url = "https://api.covid19api.com/total/country/brazil/status/deaths?from=" + DataUltimoRegistroInserido.ToString("yyyy-MM-ddTHH:mm:ss") + "&to=" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") + "Z";
            
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            List<CovidResponse> Casos = JsonConvert.DeserializeObject<List<CovidResponse>>(result);

            Mortes Mortes = new Mortes();
            foreach (CovidResponse CasosDado in Casos)
            {
                Mortes.data_dado = CasosDado.Date;
                Mortes.quantidade_mortes = CasosDado.Cases;
                Validacao.ValidaInsercao(Mortes.GetData());
                _banco.Inserir(Mortes);

            }
        }
    }
}
