﻿namespace ApiCovid.Dominio.Objetos_base
{
    public class MediaSemana
    {
        public int Media { get; set; }
        public string Periodo { get; set; }


        public MediaSemana( int MediaDaSemana, DataInicioFim DataInicioFim)
        {
            this.Media = MediaDaSemana;
            this.Periodo = "("+DataInicioFim.GetDataInicioComecoMedia().Date.ToString("dd/MM/yyyy") +" - "+ DataInicioFim.DataFim.Date.ToString("dd/MM/yyyy") +")";
         }
    }
}
