using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;
namespace project_elevator
{
    public class insert
    {
        database cn = new database();
        MySqlConnection conn = null;
        MySqlCommand command = null;
        MySqlDataAdapter adapter = null;

        public void Insert(string action) // method to insert data
        {
            
            string sql = "INSERT into Elevator (date, time, action) VALUES (@date, @time, @action)";

            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();
            try
            {
                database cn = new database();
                string url = cn.Connection();
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@action", action);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public DataTable ViewData() // view data in datagridView
        {
            
            string sql = "SELECT * FROM Elevator";
            DataSet ds = new DataSet();
            try
            {
                database cn = new database();
                string url = cn.Connection();
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "Elevator");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ds.Tables[0];
        }
        public void remover() // method to delete data
        {
            
            string sql = "DELETE FROM Elevator";
            try
            {
                database cn = new database();
                string url = cn.Connection();
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
}
















    

