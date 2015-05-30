using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using NpgsqlTypes;

namespace MedicalClinic
{
    static class DataManipulator
    {
        public static SoftUser getUserByName(string login)
        {
            SoftUser user = null;
            string stringOfConnection = "Server=localhost;Port=5432;User Id=postgres;Password=ajdg54;Database=MedicalClinic";
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);
            NpgsqlCommand command = new NpgsqlCommand("select * from soft_users where login = '"+login+"';",connection);
            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

             if (reader.Read())
             {
                user = new SoftUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
             }

            connection.Close();
            return user;
        }
    }
}
