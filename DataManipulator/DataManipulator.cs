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
                try
                {
                    user = new SoftUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
                catch (SoftUserInvalidInputDataException)
                {
                }
            }

            connection.Close();

            return user;
        }



        public static List<Doctor> getDoctorsByCondition(string condition)
        {
            List<Doctor> doctors = new List<Doctor>();

            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            NpgsqlCommand command = new NpgsqlCommand("select * from doctor " + condition, connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    doctors.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                           reader.GetString(3), reader.GetString(4), reader.GetString(5), 
                                           reader.GetChar(6), reader.GetDateTime(7), reader.GetString(8), 
                                           reader.GetString(9)));
                }
                catch (DoctorInvalidCategoryException) 
                {
                    break;
                }
            }

            connection.Close();

            return doctors;
        }



        public static List<Doctor> getDoctorsByConditionAndName(string query, string condition, string firstName, 
                                                                string middleName, string lastName)
        {
            List<Doctor> doctors = new List<Doctor>();

            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            string fullQuery = query + condition;

            if (condition != " where ")
            {
                condition += " and ";
            }

            fullQuery += "first_name = :first_name and middle_name = :middle_name" +
                         "last_name = :last_name;";

            NpgsqlCommand command = new NpgsqlCommand(fullQuery, connection);

            command.Parameters.Add("first_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("middle_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("last_name", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = firstName;
            command.Parameters[1].Value = middleName;
            command.Parameters[2].Value = lastName;

            NpgsqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                try
                {
                    doctors.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                           reader.GetString(3), reader.GetString(4), reader.GetString(5), 
                                           reader.GetChar(6), reader.GetDateTime(7), reader.GetString(8), 
                                           reader.GetString(9)));
                }
                catch (PatientInvalidPolisException)
                {
                    break;
                }
                catch (PatientInvalidSnilsException)
                {
                    break;
                }
            }

            connection.Close();

            return doctors;
        }



        public static List<Patient> getPatientByCondition(string condition)
        {
            List<Patient> patients = new List<Patient>();

            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            NpgsqlCommand command = new NpgsqlCommand("select * from patient " + condition, connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    patients.Add(new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                             reader.GetString(3), reader.GetChar(4), reader.GetDateTime(5), 
                                             reader.GetString(6), reader.GetString(7), reader.GetString(8), 
                                             reader.GetString(9)));
                }
                catch (PatientInvalidPolisException)
                {
                    break;
                }
                catch (PatientInvalidSnilsException)
                {
                    break;
                }
            }

            connection.Close();

            return patients;
        }



        public static int insertIntoPatient(Patient patient)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into patient values (default, :first_name, :middle_name," + 
                                                                                 ":last_name, :gender, :date_of_birth," +
                                                                                 ":passport, :inn, :polis, :snils)", 
                                                     connection);

            command.Parameters.Add("first_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("middle_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("last_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("gender", NpgsqlDbType.Char);
            command.Parameters.Add("date_of_birth", NpgsqlDbType.Date);
            command.Parameters.Add("passport", NpgsqlDbType.Varchar);
            command.Parameters.Add("inn", NpgsqlDbType.Varchar);
            command.Parameters.Add("polis", NpgsqlDbType.Varchar);
            command.Parameters.Add("snils", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = patient.FirstName;
            command.Parameters[1].Value = patient.MiddleName;
            command.Parameters[2].Value = patient.LastName;
            command.Parameters[3].Value = patient.Gender;
            command.Parameters[4].Value = patient.DateOfBirth;
            command.Parameters[5].Value = patient.Passport;
            command.Parameters[6].Value = patient.INN;
            command.Parameters[7].Value = patient.Polis;
            command.Parameters[8].Value = patient.Snils;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int insertIntoDoctor(Doctor doctor)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into doctor values (default, :first_name, :middle_name," +
                                                                                ":last_name, :specialization, :category,"+
                                                                                ":gender, :date_of_birth, :passport, :inn)", 
                                                       connection);

            command.Parameters.Add(new NpgsqlParameter("first_name", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("middle_name", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("last_name", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("specialization", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("category", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("gender", NpgsqlDbType.Char));
            command.Parameters.Add(new NpgsqlParameter("date_of_birth", NpgsqlDbType.Date));
            command.Parameters.Add(new NpgsqlParameter("passport", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("inn", NpgsqlDbType.Varchar));

            command.Prepare();
            
            command.Parameters[0].Value = doctor.FirstName;
            command.Parameters[1].Value = doctor.MiddleName;
            command.Parameters[2].Value = doctor.LastName;
            command.Parameters[3].Value = doctor.Specialization;
            command.Parameters[4].Value = doctor.Category;
            command.Parameters[5].Value = doctor.Gender;
            command.Parameters[6].Value = doctor.DateOfBirth;
            command.Parameters[7].Value = doctor.Passport;
            command.Parameters[8].Value = doctor.INN;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static List<Schedule> getSchedule(string query)
        {
            List<Schedule> schedule = new List<Schedule>();
           
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);
            
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            
            connection.Open();
            
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    schedule.Add(new Schedule(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2),
                                              new TimeSpan(reader.GetTime(3).Hours, reader.GetTime(3).Minutes, 
                                                           reader.GetTime(3).Seconds),
                                              reader.GetInt32(4), reader.GetBoolean(5)));
                }
                catch (ScheduleInvalidIdException)
                {
                    break;
                }
            }
            connection.Close();

            return schedule;
        }



        public static int insertIntoSoftUsers(SoftUser user)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into soft_users values (default, :login, :hpwd", connection);

            command.Parameters.Add("login", NpgsqlDbType.Varchar);
            command.Parameters.Add("hpwd", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = user.Login;
            command.Parameters[1].Value = user.HPWD;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int insertIntoSchedule(Schedule schedule)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into schedule values (default, :doctor_id," +
                                                                                   ":date_of_receipt, :time_of_receipt,"+ 
                                                                                   ":patient_id, :busy);", 
                                                      connection);

            command.Parameters.Add("doctor_id", NpgsqlDbType.Integer);
            command.Parameters.Add("date_of_receipt", NpgsqlDbType.Date);
            command.Parameters.Add("time_of_receipt", NpgsqlDbType.Time);
            command.Parameters.Add("patient_id", NpgsqlDbType.Integer);
            command.Parameters.Add("busy", NpgsqlDbType.Boolean);

            command.Prepare();

            command.Parameters[0].Value = schedule.DoctorID;
            command.Parameters[1].Value = schedule.DateOfReceipt;
            command.Parameters[2].Value = new NpgsqlTime(schedule.TimeOfReceipt.Hours,
                                                         schedule.TimeOfReceipt.Minutes,
                                                         schedule.TimeOfReceipt.Seconds);
            command.Parameters[3].Value = schedule.PatientID;
            command.Parameters[4].Value = schedule.Busy;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int deleteRecordFromTable(string tableName, int id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("delete from " + tableName + " where id = :id ", connection);

            command.Parameters.Add("id", NpgsqlDbType.Integer);

            command.Prepare();

            command.Parameters[0].Value = id;

            int deletedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return deletedOrAddedRows;
        }



        public static int getPatientIdByPolis(int polis)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("select id from patient where polis = :polis", connection);

            command.Parameters.Add("polis", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = polis;

            int id;

            try
            {
                id = (int)command.ExecuteScalar();
            }
            finally
            {
                connection.Close();
            }

            return id;
        }



        public static int updateSchedule(int id, int polis, bool busy)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("update schedule set polis = :polis, busy = :busy where " +
                                                      "id = :id);", connection);

            command.Parameters.Add("polis", NpgsqlDbType.Integer);
            command.Parameters.Add("busy", NpgsqlDbType.Boolean);
            command.Parameters.Add("id", NpgsqlDbType.Integer);

            command.Prepare();

            command.Parameters[0].Value = polis;
            command.Parameters[1].Value = busy;
            command.Parameters[2].Value = id;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int deleteFromSoftUsers(string login)
        {
            NpgsqlConnection connection = new NpgsqlConnection(stringOfConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("delete from soft_users where login = :login ", connection);

            command.Parameters.Add("login", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = login;

            int deletedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return deletedOrAddedRows;
        }
    }
}
