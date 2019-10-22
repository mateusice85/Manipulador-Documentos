using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String Mensagem { get; set; }

        public Cadastro (String nome, String telefone, String email)
        {
            //1. Comando Sql -- SqlCommand
            cmd.CommandText = "insert into transmissoes (nome,telefone,email) values (@nome, @telefone, @email)";
            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            
            try
            {
                //conectar com o banco de dados -- Conexao
                cmd.Connection = conexao.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();//Só envia dados
                //desconectar
                conexao.Desconectar();
                //mostrar mensagem de erro ou sucesso
                Mensagem = "Cadastrado com sucesso!!!";
            }
            catch (SqlException e)
            {
                Mensagem = "Erro ao tentar se conectar com o banco de dados";
            }

        }
    }
}
