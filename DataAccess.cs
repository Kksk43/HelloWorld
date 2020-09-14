using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace BookManage
{//使用using可以不用加Close关闭数据库，结束后它会自动清理资源
    class DataAccess//数据库辅助类
    {
        //private static string ConnectString = "user=root;pwd=1a2b3c4d;server=127.0.0.1;database=book";
        private static string ConnectString = "user=lab_1393230619;" +
            "pwd=33eeb8245e74_#@Aa;" +
            "server=dmslab-polardb-mysql-1.rwlb.rds.aliyuncs.com;" +
            "database=polardb_mysql_4711asc";

        ///<summary>
        ///根据SQL语句查询表对象是否存在
        /// </summary>
        public static bool TableExistOrNot(string data_in)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(data_in, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        ///<summary>
        ///*查*根据表名获取数据集的表
        /// </summary>
        public static DataTable GetDataByTNameAndID(string table, string id)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectString))//连接数据库(拿到数据库的地址)
            {
                try
                {
                    con.Open();//打开数据库
                    string data_in;
                    if (table == "bookinfo")
                    {
                        data_in = $"select *from bookinfo where BookID="+id;//选择要打开的表(查询操作)
                    }
                    else if(table == "userinfo")
                    {
                        data_in = $"select *from userinfo where UBookID=" + id;
                    }
                    else
                    {
                        data_in = $"select *from issueinfo where IssBookID=" + id;
                    }
                    MySqlCommand cmd = new MySqlCommand(data_in, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);//创建适配器

                    DataSet ds = new DataSet();//相当于建立前台虚拟数据库
                    adapter.Fill(ds, "table");//将查询的结果存储到虚拟数据库中的虚拟表中
                    //DataTable dtable = ds.Tables["table"];
                    //return dtable;
                    return ds.Tables[0];//效果相当于前两行，返回虚拟数据库中存着的表
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        ///<summary>
        ///*查*根据SQL语句获取数据集(库)对象
        /// </summary>
        public static DataSet GetDataSetBySql(string data_in)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(data_in, con);//data_in存放有相关的数据库地址
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    con.Close();
                    return ds;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        ///<summary>
        ///*查*根据书本ID获取DateReader对象(已废弃)
        /// </summary>
        //public static MySqlDataReader GetDataReaderByID(int id, string info)
        //{
        //    using (MySqlConnection con = new MySqlConnection(ConnectString))
        //    {
        //        try
        //        {
        //            con.Open();
        //            string data_in = "select *from bookinfo where BookID=" + id;
        //            //if (info == "bookinfo")
        //            //{
        //            //    data_in = "select *from bookinfo where BookID=" + id;
        //            //}
        //            //else if (info == "userinfo")
        //            //{
        //            //    data_in = "select *from userinfo where UBookID=" + id;
        //            //}
        //            //else
        //            //{
        //            //    MessageBox.Show("connect error");
        //            //    return null;
        //            //}
        //            MySqlCommand cmd = new MySqlCommand(data_in, con);

        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            reader.Read();//读取数据
        //            con.Close();

        //            return reader;
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //}

        ///<summary>
        ///*增/删/改*根据SQL语句更新数据
        /// </summary>
        public static bool UADDataTable(string data_in)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(data_in, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("增/删/改数据出错" + ex.Message);
                }
            }
        }

        ///<summary>
        ///*改*根据数据集和sql语句来更新数据集(库)对象
        /// </summary>
        public static void UpdataDataSet(DataSet ds, string data_in)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(data_in, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);//创建适配器
                    MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(adapter);//根据适配器自动生成表单
                    adapter.Update(ds, "table");//更新数据库
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
