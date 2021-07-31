using System.Collections.Generic;
using System.Data;
using ApiCovid.Dominio.Interface.Banco;
using ApiCovid.Dominio.Interface.Objeto_base;
using ApiCovid.Dominio.Objetos_base;
using MySql.Data.MySqlClient;
using SysPed.Infra.Dados;

namespace ApiCovid.Infra.BancoDeDados
{
    public class MorteBanco : IBancoDados
    {  
        public void Inserir(IDados Dados)
        {
            var sql = "INSERT INTO mortos_covid (quantidade_mortes, data_dado) VALUES (@quantidade_vitimas, @data)";
            var comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("@quantidade_vitimas", Dados.GetTotal());
            comando.Parameters.AddWithValue("@data", Dados.GetData());

            comando.Connection = Conexao.ObterConexao();
            comando.ExecuteNonQuery();
        }

        public DataTable RegistrosPorPeriodo(DataInicioFim periodo)
        {
            var sql = "SELECT quantidade_mortes FROM mortos_covid WHERE (data_dado BETWEEN @inicio AND @fim)";
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
    }
}
