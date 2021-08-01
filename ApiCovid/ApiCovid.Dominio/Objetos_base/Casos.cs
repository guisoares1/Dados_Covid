using ApiCovid.Dominio.Interface.Objeto_base;
using System;
namespace ApiCovid.Dominio.Objetos_base
{
    public class Casos : IDados
    {
        public int quantidadeCasos {private get;  set; }
        public DateTime data_dado {private get;  set; }

        public DateTime GetData()
        {
            return this.data_dado;
        }

        public int GetTotal()
        {
            return this.quantidadeCasos;
        }
    }
}
