using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Interface.Servicos;
using ApiCovid.Dominio.Metodos;
using ApiCovid.Dominio.Objetos_base;

namespace ApiCovid.Dominio.Servicos
{
    public class MortesServico : IServicoDados
    {
        private IBancoDados _banco;
        public MortesServico(IBancoDados banco)
        {
            _banco = banco;
        }

        public void Inserir(IDados Dados)
        {
            _banco.Inserir(Dados);
        }

        public int MediaMovelSemanal(int IdSemana)
        {
            // periodo de a cordo com o ID fornecido, ex: 1-> 7 dias atrás até o dia de hj/ 2-> 14 dias atrás até 7 dias 
            // pesquisar no banco o periodo solicitado
            // fazer somatorio com os registros retonados no passo anterior
            var PeriodoSolicitado = new DataInicioFim(IdSemana);
            var Dados = _banco.RegistrosPorPeriodo(PeriodoSolicitado);
            int Media = MediaSemanalMortes.CalculaMediaSemanaMortes(Dados);

            return Media;
        }


    }
}
