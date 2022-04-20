using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;

namespace Backend.Database
{
    public class DbOperations
    {
        public static bool InitializeDB()
        {

            SQLiteConnection conn = GetOpenDBConnection();
            bool creationDone = false;
            int retryCtr = 3;
            while (!creationDone && retryCtr > 0)
            {
                creationDone = CreateTables(conn);
                retryCtr--;
            }
            conn.Close();
            return creationDone;
        }

        private static SQLiteConnection GetOpenDBConnection()
        {

            //create db file if it doesn't exist
            if (!File.Exists(Apphost.DB_PATH))
                using (File.Create(Apphost.DB_PATH)) { };

            SQLiteConnection conn = new SQLiteConnection(
                $"Data Source = '{Apphost.DB_PATH}';Version=3;");
            conn.Open();
            return conn;
        }


        private static bool CreateTables(SQLiteConnection conn)
        {

            using (var transaction = conn.BeginTransaction())
            {
                var cmd = conn.CreateCommand();

                executeCmd(cmd, "CREATE TABLE IF NOT EXISTS `BookingInformation` (`id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, `roomId` INT, `boardId` INT, `residentId` INT, `startDate` INT, `endDate` INT, `totalPrice` REAL)");
                
                transaction.Commit();
            }
            return CheckTableExists(conn, "BookingInformation") == 1;
        }
        private static void executeCmd(SQLiteCommand command, string cmdString)
        {
            command.CommandText = cmdString;
            command.ExecuteNonQuery();
        }
        private static int CheckTableExists(SQLiteConnection conn, string tableName)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='{tableName}';";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return int.Parse(reader[0].ToString());
            }
            return 0;
        }
    }
}