using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace MedicalClinic
{
    static class DataManipulator
    {
        public static List<SoftUser> getAllUsers()
        {
            List<SoftUser> users = new List<SoftUser>();
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;" +
                                              "Password=84116520231;Database=MedicalClinic;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from soft_users");
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    users.Add(new SoftUser(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2)));
                }
                catch { }
            }
            connection.Close();
            return users;
        }

        public static SoftUser getUser(string login)
        {
            SoftUser user = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;" +
                                              "Password=84116520231;Database=MedicalClinic;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from soft_users where login = " + "'" + login + "';", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    user = new SoftUser(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2));
                }
                catch { }
            }
            connection.Close();
            return user;
        }
    }
}
