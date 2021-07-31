using ApiCovid.Dominio.Interface.Objeto_base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCovid.Dominio.Interface.Servicos
{
    public interface IServico
    {
        public void Inserir(IDados Dados);
        public int MediaMovelSemanal(int IdSemana);
    }
}
