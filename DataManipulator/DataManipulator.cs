using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using MedicalClinicWraps;

namespace MedicalClinic
{
    static class DataManipulator
    {
        static string connectionString = "Server=localhost;Port=5432;User Id=postgres;" +
                                           "Password=;Database=MedicalClinic";



        public static SoftUser getUserByName(string login)
        {
            SoftUser user = null;

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

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

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            NpgsqlCommand command = new NpgsqlCommand("select * from doctors " + condition, connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    doctors.Add(new Doctor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                           reader.GetString(3), reader.GetInt32(4), reader.GetChar(5), 
                                           reader.GetChar(6), reader.GetDateTime(7), reader.GetString(8),
                                           reader.GetString(9), reader.GetString(10), reader.GetString(9)));
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

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

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
                                           reader.GetString(3), reader.GetInt32(4), reader.GetChar(5),
                                           reader.GetChar(6), reader.GetDateTime(7), reader.GetString(8),
                                           reader.GetString(9), reader.GetString(10), reader.GetString(9)));
                }
                catch (DoctorInvalidInputDataException)
                {
                    break;
                }
            }

            connection.Close();

            return doctors;
        }



        public static List<Specialization> getSpecialization()
        {
            List<Specialization> specializations = new List<Specialization>();

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            NpgsqlCommand command = new NpgsqlCommand("select * from specializations", connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    specializations.Add(new Specialization(reader.GetInt32(0), reader.GetString(1)));
                }
                catch (SpecializationInvalidIdException)
                {
                    MessageBox.Show("Неправильный ID при вводе специальностей");
                }
            }

            connection.Close();

            return specializations;
        }



        public static List<Patient> getPatientByCondition(string condition)
        {
            List<Patient> patients = new List<Patient>();

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            NpgsqlCommand command = new NpgsqlCommand("select * from patients " + condition, connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    patients.Add(new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                             reader.GetString(3), reader.GetChar(4), reader.GetDateTime(5),
                                             reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                }
                catch (PatientInvalidPolicyException)
                {
                    break;
                }
                catch (PersonInvalidPassportException)
                {
                    break;
                }
            }

            connection.Close();

            return patients;
        }



        public static List<Cabinet> getCabinets()
        {
            List<Cabinet> cabinets = new List<Cabinet>();

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            NpgsqlCommand command = new NpgsqlCommand("select * from cabinets", connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    cabinets.Add(new Cabinet(reader.GetInt32(0), reader.GetString(1)));
                }
                catch (CabinetInvalidIdException)
                {
                    MessageBox.Show("Неправильный ID при вводе кабинетов");
                }
            }

            connection.Close();

            return cabinets;
        }



        public static List<Schedule> getSchedule(string query)
        {
            List<Schedule> schedule = new List<Schedule>();

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            connection.Open();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    schedule.Add(new Schedule(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2),
                                              reader.GetInt32(3), reader.GetInt32(4), reader.GetBoolean(5)));
                }
                catch (ScheduleInvalidIdException)
                {
                    break;
                }
            }
            connection.Close();

            return schedule;
        }



        public static int getPatientIdByPolicy(int policy)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("select id from patients where policy = :policy", connection);

            command.Parameters.Add("policy", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = policy;

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



        public static void getData(BindingSource bindingSource1, DataGridView scheduleDataGridView, string selectCommand)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(selectCommand, connectionString);

                NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                scheduleDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }



        public static int getLastIdFromTable(string table)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("select max(id) from '" + table + "'", connection);

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



        public static int insertIntoPatients(Patient patient)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into patients values (:id, :first_name, :middle_name," + 
                                                                                 ":last_name, :gender, :date_of_birth," +
                                                                                 ":passport, :policy, :telephoneNumber)", 
                                                     connection);

            command.Parameters.Add("id", NpgsqlDbType.Integer);
            command.Parameters.Add("first_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("middle_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("last_name", NpgsqlDbType.Varchar);
            command.Parameters.Add("gender", NpgsqlDbType.Char);
            command.Parameters.Add("date_of_birth", NpgsqlDbType.Date);
            command.Parameters.Add("passport", NpgsqlDbType.Varchar);
            command.Parameters.Add("policy", NpgsqlDbType.Varchar);
            command.Parameters.Add("telephoneNumber", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = patient.ID;
            command.Parameters[1].Value = patient.FirstName;
            command.Parameters[2].Value = patient.MiddleName;
            command.Parameters[3].Value = patient.LastName;
            command.Parameters[4].Value = patient.Gender;
            command.Parameters[5].Value = patient.DateOfBirth;
            command.Parameters[6].Value = patient.Passport;
            command.Parameters[7].Value = patient.Policy;
            command.Parameters[8].Value = patient.TelephoneNumber;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int insertIntoSpecializations(Specialization specialization)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into specializations values (:id, :title);",
                                                      connection);

            command.Parameters.Add("id", NpgsqlDbType.Integer);
            command.Parameters.Add("title", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = specialization.ID;
            command.Parameters[1].Value = specialization.Title;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int insertIntoDoctor(Doctor doctor)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into doctors values (:id, :first_name, :middle_name," +
                                                                                ":last_name, :specialization, :category,"+
                                                                                ":gender, :date_of_birth, :passport, :inn,"+
                                                                                 ":snils, :telephone_number)", 
                                                       connection);

            command.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer));
            command.Parameters.Add(new NpgsqlParameter("first_name", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("middle_name", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("last_name", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("specialization", NpgsqlDbType.Integer));
            command.Parameters.Add(new NpgsqlParameter("category", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("gender", NpgsqlDbType.Char));
            command.Parameters.Add(new NpgsqlParameter("date_of_birth", NpgsqlDbType.Date));
            command.Parameters.Add(new NpgsqlParameter("passport", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("inn", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("snils", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("telephone_number", NpgsqlDbType.Varchar));

            command.Prepare();

            command.Parameters[0].Value = doctor.ID;
            command.Parameters[1].Value = doctor.FirstName;
            command.Parameters[2].Value = doctor.MiddleName;
            command.Parameters[3].Value = doctor.LastName;
            command.Parameters[4].Value = doctor.Specialization;
            command.Parameters[5].Value = doctor.Category;
            command.Parameters[6].Value = doctor.Gender;
            command.Parameters[7].Value = doctor.DateOfBirth;
            command.Parameters[8].Value = doctor.Passport;
            command.Parameters[9].Value = doctor.INN;
            command.Parameters[10].Value = doctor.Snils;
            command.Parameters[11].Value = doctor.TelephoneNumber;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int insertIntoSoftUsers(SoftUser user)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into soft_users values (default, :login, :hpwd)", connection);

            command.Parameters.Add(new NpgsqlParameter("login", NpgsqlDbType.Varchar));
            command.Parameters.Add(new NpgsqlParameter("hpwd", NpgsqlDbType.Varchar));

            command.Prepare();

            command.Parameters[0].Value = user.Login;
            command.Parameters[1].Value = user.HPWD;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int insertIntoSchedule(Schedule schedule)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into schedule values (:id, :doctor_id," +
                                                                                   ":time_of_receipt, :cabinet_id"+ 
                                                                                   ":patient_id, :busy);", 
                                                      connection);

            command.Parameters.Add("id", NpgsqlDbType.Integer);
            command.Parameters.Add("doctor_id", NpgsqlDbType.Integer);
            command.Parameters.Add("time_of_receipt", NpgsqlDbType.Time);
            command.Parameters.Add("cabinet_id", NpgsqlDbType.Integer);
            command.Parameters.Add("patient_id", NpgsqlDbType.Integer);
            command.Parameters.Add("busy", NpgsqlDbType.Boolean);

            command.Prepare();

            command.Parameters[0].Value = schedule.ID;
            command.Parameters[1].Value = schedule.DoctorID;
            command.Parameters[2].Value = schedule.TimeOfReceipt;
            command.Parameters[3].Value = schedule.CabinetId;
            command.Parameters[4].Value = schedule.PatientID;
            command.Parameters[5].Value = schedule.Busy;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int updateTable(string table, string column, string newValue, string condition)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("update " + table + " set " + column + " = " + 
                                                      newValue + " " + condition, connection);

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int updateTable(string table, string column1, string newValue1,
                                                    string column2, string newValue2, string condition)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("update " + table + " set " + column1 + " = " +
                                                      newValue1 + ", " + column2 + " = " + newValue2 
                                                      + condition, connection);

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }



        public static int deleteRecordFromTable(string tableName, int id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("delete from " + tableName + " where id = :id ", connection);

            command.Parameters.Add("id", NpgsqlDbType.Integer);

            command.Prepare();

            command.Parameters[0].Value = id;

            int deletedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return deletedOrAddedRows;
        }

/*
        public static int updateSchedule(int id, int polis, bool busy)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("update schedule set policy = :policy, busy = :busy where " +
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

*/

        public static int deleteFromSoftUsers(string login)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("delete from soft_users where login = :login ", connection);

            command.Parameters.Add("login", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = login;

            int deletedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return deletedOrAddedRows;
        }



        public static int changeAdminPasswordInSoftUsers(string newPassword)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("update soft_users set hpwd = :hpwd;", connection);

            command.Parameters.Add("hpwd", NpgsqlDbType.Varchar);

            command.Prepare();

            command.Parameters[0].Value = newPassword;

            int changedOrAddedRows = command.ExecuteNonQuery();

            connection.Close();

            return changedOrAddedRows;
        }
    }
}
