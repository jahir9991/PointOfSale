using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PointOfSale.DataBase
{

    class DataAccess
    {







        //  public static string _ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=../db\sosnok_pos_db.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //  static string db_file_path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\db\sosnok_pos_db.mdf";


        public static string _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\pROJECT\c#\PointOfSale\db\sosnok_pos_db.mdf;Integrated Security=True;Connect Timeout=30";
        static SqlConnection _Connection = null;
        public static SqlConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new SqlConnection(_ConnectionString);
                    _Connection.Open();

                    return _Connection;
                }
                else if (_Connection.State != System.Data.ConnectionState.Open)
                {
                    _Connection.Open();

                    return _Connection;
                }
                else
                {
                    return _Connection;
                }
            }
        }

        public static DataSet GetDataSet(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            Connection.Close();

            return ds;
        }

        public static DataTable GetDataTable(string sql)
        {
            try
            {
                DataSet ds = GetDataSet(sql);

                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("sql exception");
                return null;
            }
        }

        public static int ExecuteSQL(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql exception" + ex);
                return 0;
            }
        }

        public static int ExecuteSQL(string sql, SqlParameter p)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.Add(p);
            return cmd.ExecuteNonQuery();
        }


    }

}

