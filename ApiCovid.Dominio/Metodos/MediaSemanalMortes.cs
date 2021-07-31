using ApiCovid.Dominio.Interface.Servicos;
using System;
using System.Data;

namespace ApiCovid.Dominio.Metodos
{
    public class MediaSemanalMortes
    {
        public static int CalculaMediaSemana(DataTable Dados)
        {
            int Somatorio = 0;
            string data;
            for (int i = 1; i < Dados.Rows.Count; i++) // Vai percorrer o DataTable linha a linha.
            {
                Somatorio += Convert.ToInt32(Dados.Rows[i]["quantidade_mortes"].ToString());
                data = Dados.Rows[i]["data_dado"].ToString();
            }
            return (Somatorio / 7);
        }
    }
}
