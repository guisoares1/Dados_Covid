using Xunit;
using ApiCovid.Dominio.Objetos_base;
using System;

namespace ApiCovid.Test.TesteDominio
{
    public class TesteDataInicioFim
    {
        [Fact]
        public void TesteCriaDataInicioFim()
        {
            DateTime DataInicio = DateTime.Today.AddDays(-6); 
            DateTime DataFim = DateTime.Today.AddDays(0); 

            var Data = new DataInicioFim(1);

            Assert.True(Data.DataInicio.Equals(DataInicio));
            Assert.True(Data.DataFim.Equals(DataFim));
        }
    }
}
