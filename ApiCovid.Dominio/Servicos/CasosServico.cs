using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Interface.Servicos;
using ApiCovid.Dominio.Metodos;
using ApiCovid.Dominio.Objetos_base;
using System;

namespace ApiCovid.Dominio.Servicos
{
    public class CasosServico : IServicoDados
    {
        private IBancoDados _banco;
        public CasosServico(IBancoDados banco)
        {
            _banco = banco;
        }

        public void Inserir(IDados Dados)
        {
            _banco.Inserir(Dados);
        }

        public int MediaMovelSemanal(int IdSemana)
        {
            var PeriodoSolicitado = new DataInicioFim(IdSemana);
            var Dados = _banco.RegistrosPorPeriodo(PeriodoSolicitado);
            int Media = MediaSemanalMortes.CalculaMediaSemanaCasos(Dados);

            return Media;
        }
    }
}
