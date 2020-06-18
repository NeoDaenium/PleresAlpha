using Dapper;
using Pleres.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pleres
{
    public class SqliteDataAccess
    {
        public static List<UserModel> GetUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT Username, Password FROM Users", new DynamicParameters());
                return output.ToList();
            }
        }
        /* DATABASE - Table name Users
         * FIELDS, Userid int, Username String, Password String, Permissions int
         * Firstname String, Lastname String
         * Dateadded String, Birthday String 
         */

          
    public Boolean ValidateUser(string _username, string _password)
        {
            DataTable selectedValues;
            string query = "SELECT * FROM Users WHERE Username = @User And Password = @Pass";
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand command = new SQLiteCommand(query,cnn);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                command.Parameters.AddWithValue("@User", _username);
                command.Parameters.AddWithValue("@Pass", _password);
                selectedValues = new DataTable();
                dataAdapter.Fill(selectedValues);
            }
            if (selectedValues.Rows.Count > 0)
                return true;
            else
                return false;
        }
    private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
