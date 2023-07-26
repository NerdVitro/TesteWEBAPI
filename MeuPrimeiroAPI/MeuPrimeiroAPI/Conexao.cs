using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Principal;

namespace MeuPrimeiroAPI
{
    public class Conexao
    {
        readonly private SqlConnection _SqlConnection;

        public string ConectionString = @"Data Source=DESKTOP-ARF9MHF" +
                                        ";Initial Catalog=VITORDATABASE" +
                                        ";Integrated Security=True" +
                                        ";TrustServerCertificate=True";
        // -----------------------------------------------------------
        //CREATE DATABASE VITORDATABASE
        //CREATE TABLE TBUSUARIO(
        //    IDUSUARIO INT IDENTITY PRIMARY KEY NOT NULL,
        //    NOMEUSUARIO VARCHAR(100) NOT NULL
        //);
        // -----------------------------------------------------------

        public Conexao()
        {
            _SqlConnection = new SqlConnection()
            {
                ConnectionString = ConectionString
            };
        }


        public SqlConnection Conectar()
        {
            if (_SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                _SqlConnection.Open();
            }
            return _SqlConnection;
        }

        public void Desconectar()
        {
            if (_SqlConnection.State == System.Data.ConnectionState.Open)
            {
                _SqlConnection.Close();
            }
        }
    }
}
