using System;
using System.Data;

namespace ApiCovid.Dominio.Servicos
{
    public class MediaSemanal
    {
        public static int CalculaMediaSemanaMortes(DataTable Dados)
        {   
            int Somatorio = 0;
            for (int i = 1; i < Dados.Rows.Count; i++) // Vai percorrer o DataTable linha a linha.
                Somatorio += NovosCasos(Convert.ToInt32(Dados.Rows[i - 1]["quantidade_mortes"]), Convert.ToInt32(Dados.Rows[i]["quantidade_mortes"]));

            return (Somatorio / 7);
        }
        public static int CalculaMediaSemanaCasos(DataTable Dados)
        {
            int Somatorio = 0;
            for (int i = 1; i < Dados.Rows.Count; i++) // Vai percorrer o DataTable linha a linha.
                Somatorio += NovosCasos(Convert.ToInt32(Dados.Rows[i - 1]["quantidade_casos"]), Convert.ToInt32(Dados.Rows[i]["quantidade_casos"]));

            return (Somatorio / 7);
        }

        private static int NovosCasos(int DiaAnterior, int DiaAtual) => (DiaAtual - DiaAnterior);
    }
}
