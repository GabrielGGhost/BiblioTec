using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackupDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);

        public void GerarBackup()
        {

            try
            {
                cn.Open();

                SqlCommand gerarBackup = new SqlCommand(@"BACKUP DATABASE[Biblioteca]
                                                          TO DISK= '" + "BkpBibliotec(" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ")-(" + DateTime.Now.Hour + "_"+ DateTime.Now.Minute + "-" + DateTime.Now.Second + ')' +"' WITH COPY_ONLY", cn);

                gerarBackup.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar executar o Backup: " + ex.Message);
            }finally
            {
                cn.Close();
            }
        }
    }

}