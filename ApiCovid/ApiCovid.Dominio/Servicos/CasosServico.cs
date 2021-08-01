using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Interface.Servicos;
using ApiCovid.Dominio.Metodos;
using ApiCovid.Dominio.Objetos_base;
using System;
using System.Collections.Generic;

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
            Validacao.ValidaInsercao(Dados.GetData());
            _banco.Inserir(Dados);
        }

        public List<MediaSemana> MediaMovelSemanal(int IdSemana)
        {
            Validacao.ValidaId(IdSemana);

            var PeriodoSolicitado = new DataInicioFim(IdSemana);
            var Dados = _banco.RegistrosPorPeriodo(PeriodoSolicitado);
            int Media = MediaSemanalMortes.CalculaMediaSemanaCasos(Dados);
            List<MediaSemana> Retorno = new List<MediaSemana>();
            Retorno.Add(new MediaSemana(IdSemana, Media, PeriodoSolicitado));

            return (Retorno);
        }
    }
}
