using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace toDo_v2
{
    public static class DBModule
    {
        private static string url = "maxonmvi.beget.tech";
        private static string user = "maxonmvi_db";
        private static string pass = "edq22E";
        private static string database_name = "maxonmvi_db";
        private static string table_name = "prepod";

        public static MySqlConnection connection;

        public static Exception Connect() 
        {
            try
            {
                string connectionString = $"server={url};uid={user};pwd={pass};database={database_name}";
                connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                return null;
            }
            catch (MySqlException ex)
            {
                return ex;
            }
        
        }

        public static List<Task> getAllTasks() 
        {
            string sql = $"SELECT * FROM `{table_name}`";
            MySqlCommand com = new MySqlCommand(sql,connection);
            MySqlDataReader data = com.ExecuteReader();

            List<Task> lt = new List<Task> { };
            while (data.Read()) 
            {
                Task t = new Task(
                    data.GetString("title"), 
                    data.GetString("text"),
                    data.GetBoolean("isDone"),
                    data.GetInt32("timeStamp")
                    );
                lt.Add(t);
            }
            data.Close();
            return lt;
        }

        internal static void AddNew(Task t)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                return;
            string sql = $"INSERT INTO `{table_name}` (`title`, `text`, `isDone`, `timeStamp`) "
                + $" VALUES ('{t.title}', '{t.text}', '{Convert.ToInt32(t.isDone)}', '{t.timeStamp}')";

            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader data = com.ExecuteReader();
            data.Close();

        }
    }
}
