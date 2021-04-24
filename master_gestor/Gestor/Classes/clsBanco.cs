using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor.Classes
{
    class clsBanco
    {
        private static string sStringConexao = "";

        public static void Fu_MontaConexao()
        {
            NpgsqlConnectionStringBuilder strConnection = new NpgsqlConnectionStringBuilder();

            strConnection.Host = "otto.db.elephantsql.com";
            strConnection.Database = "rhvlvipc";
            strConnection.Port = 5432;
            strConnection.Username = "rhvlvipc";
            strConnection.Password = "0hOdNFJ9ymoTLk_i7MxVGla6oy3LCd3u";
            //strConnection.Pooling = false;
            //strConnection.Encoding = "windows-1252";
            //strConnection.ClientEncoding = "UTF8";
            sStringConexao = strConnection.ConnectionString;
        }

        public static bool FU_TestaConexao()
        {
            string connectionString = sStringConexao;
            bool bRetorno = false;
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        bRetorno = true;
                    }
                    else
                    {
                        bRetorno = false;
                    }
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                bRetorno = false;
            }
            return bRetorno;
        }

        public static int Fu_RetornaVersaoBanco()
        {
            string sScript = "select versaobd from versaobd;";
            string sResultado = "";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sStringConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            sResultado = dr[0].ToString();
                        }
                    }
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            if (sResultado != string.Empty) return Convert.ToInt32(sResultado);
            else return 0;
        }

        public static bool ExecutaScript(string sScript)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(clsBanco.sStringConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                        }
                    }
                    {
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
