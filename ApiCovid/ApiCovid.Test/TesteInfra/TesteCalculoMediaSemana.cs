using ApiCovid.Dominio.Objetos_base;
using ApiCovid.Dominio.Metodos;
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace ApiCovid.Test.TesteInfra
{
    public class TesteCalculoMediaSemana
    {
        [Fact]
        public void CalculoMediaSemana()
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
            teste = MediaSemanalMortes.CalculaMediaSemanaMortes(Data);

            Assert.True(teste==10);
        }
    }
}
