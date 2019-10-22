using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class Conexao
    {
        //Instancia de sql connection
        SqlConnection conex = new SqlConnection();

        //Construtor
        public Conexao()
        {
            //conex.ConnectionString = @"workstation id=Server666.mssql.somee.com;packet size=4096;user id=mateusice85_SQLLogin_1;pwd=zj9s13t57e;data source=Server666.mssql.somee.com;persist security info=False;initial catalog=Server666";
            //conex.ConnectionString = @"Application Name=sistema.gorilla.com.br;
            //                           Data Source=207.182.132.194;
            //                           Initial Catalog=sistema.gorilla.com.br;
            //                           User ID=sa;
            //                           Password=gorilla2513!;
            //                           Persist Security Info=True;
            //                           Connection Timeout=30;
            //                           pooling=true;
            //                           max pool size=32767;";

            conex.ConnectionString = @"Application Name=alliz.gorilla.com.br;
                                       Data Source=207.182.134.82;
                                       Initial Catalog=alliz.gorilla.com.br;
                                       User ID=sa;
                                       Password=gorilla2513!;
                                       Persist Security Info=True;
                                       Connection Timeout=120;
                                       pooling=true;
                                       max pool size=32767;
                                       Connection Lifetime=180;";
        }
        //Metodo Conectar
        public SqlConnection Conectar()
        {
            if(conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Open();
            }
            return conex;
        }
        //Metodo Desconectar
        public void Desconectar()
        {
            if(conex.State == System.Data.ConnectionState.Open)
            {
                conex.Close();
            }
        }
    }

}
