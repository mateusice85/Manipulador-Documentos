using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class RecepcaoDeDados
    {
        public List<string> ListaString = new List<string>();
        public void BuscarNaBase()
        {
            try
            {
                Conexao conn = new Conexao();

                //using (SqlCommand cmd = new SqlCommand("SELECT * from transmissoes (nolock)", conn.Conectar()))
                using (SqlCommand cmd = new SqlCommand($"select e.str_descricao, mt.str_transmissao from modulo_transmissao as mt (nolock)" +
                    $"join transmissao_data as td (nolock)on td.id_transmissao = mt.id_transmissao " +
                    $"join equipamento as e (nolock)on e.id = td.id_equipamento and e.id_empresa = 5" +
                    $"order by e.str_descricao", conn.Conectar()))

                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                string str_juntar = "";
                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    str_juntar += Convert.ToString(rd[i]);
                                    str_juntar += " ";
                                }
                                string[] entrada = str_juntar.Split(';');
                                string[] entradaEquip = entrada[0].Split(' ');

                                if (entrada[14].Length == 6) ListaString.Add(entradaEquip[0] + "/" + entrada[14]);
                                else if (entrada[15].Length == 6) ListaString.Add(entradaEquip[0] + "/" + entrada[15]);
                                else ListaString.Add("Erro");
                            }
                        }
                    }
                    conn.Desconectar();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Conexão com problema");
            }
        }
    }
}
