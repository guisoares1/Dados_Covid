using System;

namespace ApiCovid.Dominio.Objetos_base
{
    public class DataInicioFim
    {
        public DateTime DataInicio { get;  set; }
        public DateTime DataFim { get;  set; }

        public  DataInicioFim(int IdSemana)
        {     
            int inicio = (IdSemana * 7) - 1;
            int final = inicio - 6;

            this.DataInicio = DateTime.Today.AddDays(-inicio);
            this.DataFim = DateTime.Today.AddDays(-final);
        }
    }
}
