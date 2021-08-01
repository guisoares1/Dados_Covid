using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Objetos_base;
using System.Collections.Generic;

namespace ApiCovid.Dominio.Interface.Servicos
{
    public interface IServicoDados
    {
        public void Inserir(IDados Dados);
        public List<MediaSemana> MediaMovelSemanal(int IdSemana);
    }
}
