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
            conex.ConnectionString = @"workstation id=Server666.mssql.somee.com;packet size=4096;user id=mateusice85_SQLLogin_1;pwd=zj9s13t57e;data source=Server666.mssql.somee.com;persist security info=False;initial catalog=Server666";
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
