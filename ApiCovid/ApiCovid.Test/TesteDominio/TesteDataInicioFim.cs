using Xunit;
using ApiCovid.Dominio.Objetos_base;
using System;

namespace ApiCovid.Test.TesteDominio
{
    public class TesteDataInicioFim
    {
        [Fact]
        public void TesteCriaDataInicioFimBanco()
        {
            DateTime DataInicio = DateTime.Today.AddDays(-8); 
            DateTime DataFim = DateTime.Today.AddDays(-1); 

            var Data = new DataInicioFim(1);

            Assert.True(Data.GetDataInicioBanco().Equals(DataInicio));
            Assert.True(Data.DataFim.Equals(DataFim));
        }
    }
}
