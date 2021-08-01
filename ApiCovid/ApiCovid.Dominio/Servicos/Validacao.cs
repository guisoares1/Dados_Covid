using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCovid.Dominio.Servicos
{
   public class Validacao
    {
        public static void ValidaId(int IdSemana)
        {
            if (IdSemana <= 0)
                throw new Exception("Digite um Id de semana válido");
        }

        public static void ValidaInsercao(DateTime Data)
        {
            if (Data == DateTime.MinValue)
                throw new Exception("Data Não preenchida");
        }
    }
}
