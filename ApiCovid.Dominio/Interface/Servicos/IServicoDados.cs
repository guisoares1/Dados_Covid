using ApiCovid.Dominio.Interface.Objeto_base;

namespace ApiCovid.Dominio.Interface.Servicos
{
    public interface IServicoDados
    {
        public void Inserir(IDados Dados);
        public int MediaMovelSemanal(int IdSemana);
    }
}
