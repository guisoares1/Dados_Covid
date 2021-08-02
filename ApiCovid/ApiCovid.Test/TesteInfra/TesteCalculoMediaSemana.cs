using System.Collections.Generic;
using System.Data;
using Xunit;
using ApiCovid.Dominio.Servicos;

namespace ApiCovid.Test.TesteInfra
{
    public class TesteCalculoMediaSemana
    {
        [Fact]
        public void CalculoMediaSemanaMortes()
        {
            DataTable Data = new DataTable();
            List<string> lista = new List<string>();
            int teste;
            lista.Add("10");
            lista.Add("20");
            lista.Add("30");
            lista.Add("40");
            lista.Add("50");
            lista.Add("60");
            lista.Add("70");
            lista.Add("80");
            Data.Columns.Add("quantidade_mortes", typeof(string));

            foreach (var item in lista)

            {

                Data.Rows.Add(item);

            }
            teste = MediaSemanal.CalculaMediaSemanaMortes(Data);

            Assert.True(teste==10);
        }

        [Fact]
        public void CalculoMediaSemanaCasos()
        {
            DataTable Data = new DataTable();
            List<string> lista = new List<string>();
            int teste;
            lista.Add("10");
            lista.Add("20");
            lista.Add("30");
            lista.Add("40");
            lista.Add("50");
            lista.Add("60");
            lista.Add("70");
            lista.Add("80");
            Data.Columns.Add("quantidade_casos", typeof(string));

            foreach (var item in lista)

            {

                Data.Rows.Add(item);

            }
            teste = MediaSemanal.CalculaMediaSemanaCasos(Data);

            Assert.True(teste == 10);
        }
    }
}
