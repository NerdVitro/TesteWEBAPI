using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MeuPrimeiroAPI.Controllers
{
    [ApiController]
    [Route("Api/ObterDadosGerais")]
    public class ObterDadosGeraisController : ControllerBase
    {

        [HttpGet]
        [Route("GetDataAtual")]
        public string GetDataAtual()
        {
            return DateTime.Now.ToLongDateString();
        }

        [HttpGet]
        [Route("GetPrimeiroUsuario")]
        public string GetPrimeiroUsuario()
        {

            Conexao conexao = new();
            SqlCommand sqlcmd = new();
            SqlDataReader? sqldr = null;

            try
            {
                sqlcmd.CommandText =
                    @" SELECT TOP 1
                         USU.IDUSUARIO
                         ,USU.NOMEUSUARIO
                        FROM TBUSUARIO AS USU WITH(NOLOCK)
                        ORDER BY USU.IDUSUARIO ASC";

                sqlcmd.Parameters.Clear();

                sqlcmd.Connection = conexao.Conectar();

                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    if (sqldr.Read())
                    {
                        return sqldr["NOMEUSUARIO"] == DBNull.Value ? "" : Convert.ToString(sqldr["NOMEUSUARIO"]);
                    }
                }
                return "";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }

        [HttpPost]
        [Route("AdicionarUsuario")]
        public string AdicionarUsuario([FromBody]string parNomeUsuario)
        {
            Conexao? conexao = null;
            try
            {
                conexao = new();
                SqlCommand sqlcmd = new()
                {
                    CommandText =
                    @" INSERT INTO TBUSUARIO (NOMEUSUARIO)
                        VALUES
                            (@NOMEUSUARIO)",

                    Connection = conexao.Conectar()
                };

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NOMEUSUARIO", parNomeUsuario);

                sqlcmd.ExecuteNonQuery();
                return "Foi cadastrado o cara: " + parNomeUsuario;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao?.Desconectar();
            }
        }
    }
}
