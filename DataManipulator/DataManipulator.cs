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
        static string stringOfConnection = "Server=localhost;Port=5432;User Id=postgres;" +
                                           "Password=;Database=MedicalClinic";
        public static SoftUser getUserByName(string login)
        {
            SoftUser user = null;
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select * from soft_users where login = :login", connection);
            command.Parameters.Add("login", NpgsqlDbType.Varchar);
            command.Prepare();
            command.Parameters[0].Value = login;
            NpgsqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                user = new SoftUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }

            connection.Close();
            return user;
        }

        public static List<Doctor> getDoctors(string specialization)
        {
            List<Doctor> doctors = new List<Doctor>();
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);
            NpgsqlCommand command = new NpgsqlCommand("select * from doctor where specialization = '" + 
                                                      specialization + "';", connection);
            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                doctors.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                            reader.GetString(3), reader.GetChar(4), reader.GetDateTime(5), reader.GetString(6),
                            reader.GetString(7), reader.GetString(8), reader.GetString(9)));
            }

            connection.Close();
            return doctors;
        }
    }
}
