using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCovid.Dominio.Objetos_base
{
    public class MediaSemana
    {
        public int Media { get; set; }
        public string Semana { get; set; }
        public string Periodo { get; set; }


        public MediaSemana(int IdSemana, int MediaDaSemana, DataInicioFim DataInicioFim)
        {
            this.Semana = "Semana "+ IdSemana.ToString();
            this.Media = MediaDaSemana;
            this.Periodo = "("+DataInicioFim.GetDataInicioComecoMedia().Date.ToString("dd/MM/yyyy") +" - "+ DataInicioFim.DataFim.Date.ToString("dd/MM/yyyy") +")";
    }
    }
}
