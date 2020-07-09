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
    public static class PleresSecurity
    {
        public static String previousUid;
        public static String previousHash;
        public static string WriteHash()
        {
            Console.WriteLine(previousHash);

            return previousHash;
        }
        public static string WriteUid()
        {
            Console.WriteLine(previousUid);
            return previousUid;
        }
        public static string Season(string _toSeason)//Requires to be run first
        {
            String uid = CreateUniqueIdentifier(5);
            previousUid = uid;
            String hashBrown = GenerateHash(_toSeason, uid);
            previousHash = hashBrown;
            return hashBrown;
        }
        private static String CreateUniqueIdentifier(int _size)
        {
            var randomNumberGenerator = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buffer = new byte[_size];
            randomNumberGenerator.GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }
        public static String GenerateHash(String _input, String _uid)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(_input + _uid);
            System.Security.Cryptography.SHA256Managed hashString = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashString.ComputeHash(bytes);

            return BitConverter.ToString(hash).Replace("-", "");
        }
        public static bool CompareHash(String _inputString, String _uid, String _originHash)
        {
            if (GenerateHash(_inputString, _uid).Equals(_originHash))
                return true;
            else
                return false;
        }
    }

    public static class SqliteDataAccess
    {
        public static List<UserModel> GetLoginData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT Username, Password, Uid FROM Users", new DynamicParameters());
                return output.ToList();
            }
        }
        /* DATABASE - Table name Users
         * FIELDS, Userid int, Username String, Password String, Permissions int
         * Firstname String, Lastname String
         * Dateadded String, Birthday String 
         */

    public static void AddUser(string _username, string _password)
        {

        }
    public static Boolean AuthenticateUser(string _username, string _password)
        {
            DataTable selectedValues;
            string _Uid, _internalPassword;

        string query = "SELECT Password, Uid FROM Users WHERE Username = @User";

            //query = "SELECT * FROM Users WHERE Username = @User And Password = @Pass";
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand command = new SQLiteCommand(query,cnn);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                command.Parameters.AddWithValue("@User", _username);//Next Time hash user
                //command.Parameters.AddWithValue("@Pass", _password);
                selectedValues = new DataTable();
                dataAdapter.Fill(selectedValues);
            }
            if (selectedValues.Rows.Count > 0) {
                /*
                foreach (DataRow dataRow in selectedValues.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.WriteLine(item);
                    }
                }*/
                DataRow[] selectedRow = selectedValues.Select();
                _internalPassword = selectedRow[0]["Password"].ToString();
                _Uid = selectedRow[0]["Uid"].ToString();
                //Console.WriteLine("The input Password is:"+_password+" while the internal UID is:"+_Uid);
                //Console.WriteLine("The Hashed Password is:" +PleresSecurity.GenerateHash(_password,_Uid) + " while the internal hashed pass is:" + _internalPassword);
                if (PleresSecurity.CompareHash(_password, _Uid, _internalPassword))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
