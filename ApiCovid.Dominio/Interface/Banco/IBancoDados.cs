using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Objetos_base;
using System.Data;

namespace ApiCovid.Dominio.Interface.Banco
{
    public interface IBancoDados
    {
        public void Inserir(IDados Dados);
        public DataTable RegistrosPorPeriodo(DataInicioFim periodo);
    }
}
