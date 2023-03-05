using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myprogram
{
    public class SQLServer_UtilsHelp
    {

        /// <summary>
        /// SQL数据库的连接
        /// </summary>
        public void SQLConnection() 
        {
            string ConnString = @"Data Source = localhost; Initial Catalog = PerformanceAppraisalDb;User ID = YYC ;Password = 123456 ";
            //string ConnString = @"Data Source = localhost; Initial Catalog = PerformanceAppraisalDb;Integrated Security = SSPI ";

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
            //finally 
            //{
            //    connection.Close();
            //    Console.WriteLine("数据库成功关闭！");
            //}
        }

        public void SQLCommand() 
        {
        
        }

    }
}
