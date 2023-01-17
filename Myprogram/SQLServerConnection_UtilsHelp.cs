using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myprogram
{
    /// <summary>
    /// SQL
    /// </summary>
    public class SQLServerConnection_UtilsHelp
    {

        public void SQLConnection() 
        {
            string ConnString = @"Data Source = localhost; Initial Catalog = PerformanceAppraisalDb;User ID = YYC ;Password = 123456 ";
            SqlConnection connection = new SqlConnection(ConnString);
            try
            {
                connection.Open();
                Console.WriteLine("数据库连接成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine("连接失败！" + ex.Message);
            }
            finally 
            {
                connection.Close();
                Console.WriteLine("数据库成功关闭！");


            }
        }
        
        
    }
}
