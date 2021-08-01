using System;
using System.Data;

namespace ApiCovid.Dominio.Servicos
{
    public class MediaSemanalMortes
    {
        public static int CalculaMediaSemanaMortes(DataTable Dados)
        {   
            int Somatorio = 0;
            for (int i = 1; i < Dados.Rows.Count; i++) // Vai percorrer o DataTable linha a linha.
            {
                Somatorio += NovosCasos(Convert.ToInt32(Dados.Rows[i - 1]["quantidade_mortes"].ToString()), Convert.ToInt32(Dados.Rows[i]["quantidade_mortes"].ToString()));
            }
            return (Somatorio / 7);
        }
        public static int CalculaMediaSemanaCasos(DataTable Dados)
        {
            int Somatorio = 0;
            for (int i = 1; i < Dados.Rows.Count; i++) // Vai percorrer o DataTable linha a linha.
            {
                Somatorio += NovosCasos(Convert.ToInt32(Dados.Rows[i - 1]["quantidade_casos"].ToString()), Convert.ToInt32(Dados.Rows[i]["quantidade_casos"].ToString()));
            }
            return (Somatorio / 7);
        }

        private static int NovosCasos(int DiaAnterior, int DiaAtual) => (DiaAtual - DiaAnterior);
    }
}
