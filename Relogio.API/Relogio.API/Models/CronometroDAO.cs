using MySql.Data.MySqlClient;
using Relogio.API.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Relogio.API.Models
{
    public class CronometroDAO
    {
        string conexaoString = "Server=localhost;Database=relogio;Uid=root;Pwd=;";
        string cs = @"Server=localhost;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        //cria database se não existir
        public bool criaDataBase()
        {
            try
            {
                connection = new MySqlConnection(cs);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "create database if not exists Relogio;";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //criar tabela se não existir
        public bool criaTabela()
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "create table if not exists historicos(cro_id int(14) primary key auto_increment," +
                                                                            "cro_data varchar(28) not null," +
                                                                            "cro_horario varchar(28) not null," +
                                                                            "cro_tempo varchar(28) not null)";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool cadastrarCronometro(string cro_data, string cro_horario, string cro_tempo)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into historicos (cro_data,cro_horario,cro_tempo) values ('" + cro_data + "','" + cro_horario + "','" + cro_tempo + "');";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletarHistorico()
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "truncate table historicos;";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Busca todas as empresas na base de dados, ordenando tal lista pelo id.
        /// </summary>
        /// <returns></returns>
        public List<Cronometro> BuscarHistorico()
        {
            try
            {
                var historico = new List<Cronometro>();
                //int qntd = qntdBanco();

                using (connection = new MySqlConnection(conexaoString))
                {
                    using (command = new MySqlCommand("select cro_id,cro_data,cro_horario,cro_tempo from historicos;", connection))
                    {
                        connection.Open(); // abre a conexão
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Cronometro cro = new Cronometro();
                                cro.cro_id = dataReader["cro_id"].ToString();
                                cro.cro_data = dataReader["cro_data"].ToString();
                                cro.cro_horario = dataReader["cro_horario"].ToString();
                                cro.cro_tempo = dataReader["cro_tempo"].ToString();
                                historico.Add(cro);
                            }
                        }
                        return historico;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar a lista de empresas" + ex.Message);
            }
        }
    }
}
