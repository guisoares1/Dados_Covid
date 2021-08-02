using ApiCovid.Dominio.Interface.Objeto_base;
using System;
namespace ApiCovid.Dominio.Objetos_base
{
    public class Mortes : IDados
    {
        public int quantidade_mortes { get;  set; }
        public DateTime data_dado { get; set; }

        public DateTime GetData()
        {
            return this.data_dado;
        }

        public int GetTotal()
        {
            return this.quantidade_mortes;
        }
    }
}
