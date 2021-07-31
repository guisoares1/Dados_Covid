using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Objetos_base;
using MySql.Data.MySqlClient;
using SysPed.Infra.Dados;
using System;
using System.Collections.Generic;
using System.Data;

namespace ApiCovid.Infra.BancoDeDados
{
    public class CasosBanco : IBancoDados
    {
        public void Inserir(IDados Dados)
        {
            var sql = "INSERT INTO casos_covid (quantidade_casos, data_dado) VALUES (@quantidade_casos, @data)";
            var comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("@quantidade_casos", Dados.GetTotal());
            comando.Parameters.AddWithValue("@data", Dados.GetData());

            comando.Connection = Conexao.ObterConexao();
            comando.ExecuteNonQuery();
            Conexao.FecharConexao(comando.Connection);
        }

        public DataTable RegistrosPorPeriodo(DataInicioFim periodo)
        {
            var sql = "SELECT quantidade_casos FROM casos_covid WHERE (data_dado BETWEEN date(@inicio) AND date(@fim))";
            var comando = new MySqlCommand(sql);
            MySqlDataReader Leitor;
            DataTable table = new DataTable();
            comando.Parameters.AddWithValue("@inicio", periodo.DataInicio);
            comando.Parameters.AddWithValue("@fim", periodo.DataFim);

            comando.Connection = Conexao.ObterConexao();

            Leitor = comando.ExecuteReader();
            table.Load(Leitor);
            Leitor.Close();
            Conexao.FecharConexao(comando.Connection);

            return table;
        }

        public DateTime DataUltimoRegistroInserido()
        {
            var sql = "SELECT data_dado FROM casos_covid ORDER BY id DESC LIMIT 1";
            var comando = new MySqlCommand(sql);
            string UltimaData;
            MySqlDataReader Leitor;
            comando.Connection = Conexao.ObterConexao();

            Leitor = comando.ExecuteReader();
            if (Conexao.TrataSerRegistroExiste(Leitor))
            {

                Leitor.Read();
                UltimaData = Leitor["data_dado"].ToString();
            }
            else
            {
                UltimaData = DateTime.MinValue.ToString();
            }

            Conexao.FecharConexao(comando.Connection);
            return Convert.ToDateTime(UltimaData); ;
        }
    }
}
