using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class RecepcaoDeDados
    {
         

        public List<EntradasModulo> BuscarNaBase()
        {
            List<EntradasModulo> ListaObj = new List<EntradasModulo>();
            try
            {
                Conexao conn = new Conexao();

                using (SqlCommand cmd = new SqlCommand("SELECT * from transmissao (nolock)", conn.Conectar()))

                //using (SqlCommand cmd = new SqlCommand($"select top(1) e.str_descricao, mt.str_transmissao from modulo_transmissao as mt (nolock)" +
                //    $"join transmissao_data as td (nolock)on td.id_transmissao = mt.id_transmissao " +
                //    $"join equipamento as e (nolock)on e.id = td.id_equipamento and e.id_empresa = 5 and e.str_descricao = 'AUF1698 - Silas' " +
                //    $"order by e.str_descricao", conn.Conectar()))

                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                string str_juntar_string = "";
                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    str_juntar_string += Convert.ToString(rd[i])+";";
                                }

                                string[] entrada = str_juntar_string.Split(';');
                                int cont = entrada[2].Length;
                                char[] entradasBaseModulo = new char[6];
                                switch (cont)
                                {
                                    case 6:
                                        entradasBaseModulo = entrada[15].ToCharArray();
                                        break;
                                    case 9:
                                        entradasBaseModulo = entrada[16].ToCharArray();
                                        break;
                                    default:
                                        Console.WriteLine("modulo com string nova - ("+str_juntar_string+")");
                                        break;
                                }

                                EntradasModulo entradasDoModulo = new EntradasModulo(entrada[0], entradasBaseModulo);
                                
                                ListaObj.Add(entradasDoModulo);
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
            return ListaObj;
        }
    }
}
