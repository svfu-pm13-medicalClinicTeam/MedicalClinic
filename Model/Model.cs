using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using MedicalClinicWraps;

namespace MedicalClinic
{
    static class Model
    {
        public static bool userExists(string login, string password)
        {
            string hpwd = GetHashString(GetHashString(password));
            SoftUser user = DataManipulator.getUserByName(login);
            
            return (hpwd == user.HPWD);
        }

        static string GetHashString(string s)
        {
            MD5CryptoServiceProvider md5CSP = new MD5CryptoServiceProvider();

            byte[] byteHash = md5CSP.ComputeHash(Encoding.UTF8.GetBytes(s));

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < byteHash.Length; i++)
            {
                result.Append(byteHash[i].ToString("x2"));
            }

            return result.ToString();
        }



        public static List<Schedule> getSchedule(string specialization, string fromDate, string toDate,
                                                 string busy = "'f'")
        {
            string query = "";
            string scheduleQuery = "";
            string doctorQuery = "";

            if (specialization != "")
            {
                doctorQuery = "select * from doctors where specialization_id = '"+specialization +"' ";
            }

            scheduleQuery = " where date_of_receipt >= '"+fromDate+"' ";

            if (toDate != "")
            {
                scheduleQuery += " and date_of_receipt <= '"+toDate+"' ";
            }

            scheduleQuery += " and busy = " + "'" + busy + "' ";
           
            if (doctorQuery != "")
            {
                query += "select schedule.id, schedule.doctor_id, schedule.date_of_receipt," +
                         "schedule.time_of_receipt, schedule.cabinet, schedule.busy from " +
                         "schedule inner join (" + doctorQuery + ") as needed_doctor on " +
                         "schedule.doctor_id = needed_doctor.id " + scheduleQuery;
            }
            else
            {
                query += " select * from schedule " + scheduleQuery;
            }

            return DataManipulator.getSchedule(query);
        }



        public static void formNewSchedule(Schedule schedule)
        {
            DataManipulator.insertIntoSchedule(schedule);
        }

        

        public static List<Doctor> getDoctors(string specialization, string category, string firstName, 
                                              string middleName, string lastName)
        {
            string query = "select * from doctors ";
            string condition = " where ";

            if (specialization != null)
            {
                condition += "specialization_id = " + "'" + specialization + "' ";
                if (category != null)
                {
                    condition += " and ";
                }
            }

            if (category != null)
            {
                condition += " category = " + "'" + category + "' ";
            }

            if (firstName != null)
            {
                return DataManipulator.getDoctorsByConditionAndName(query, condition, firstName, middleName, lastName);
            }
            else
            {
                return DataManipulator.getDoctorsByCondition(condition);
            }
        }



        public static void addPatient(string firstName, string middleName, string lastName, char gender,
                                      string dateOfBirth, string passport, string polis,
                                      string telephoneNumber)
        {
            DataManipulator.insertIntoPatient(new Patient(1, firstName, middleName, lastName, gender, 
                                                          Convert.ToDateTime(dateOfBirth), passport,
                                                          polis, telephoneNumber));
        }



        public static void addDoctor(string firstName, string middleName, string lastName,
                                     int specialization, char category, char gender, string dateOfBirth,
                                     string passport, string inn,  string snils, string telephoneNumber)
        {
            int id = DataManipulator.getLastIdFromTable("doctors");

            DataManipulator.insertIntoDoctor(new Doctor(id, firstName, middleName, lastName, specialization,
                                                        category, gender, Convert.ToDateTime(dateOfBirth),
                                                        passport,inn, snils, telephoneNumber));
        }


            
        public static void addUser(string login, string password)
        {
            int id = DataManipulator.getLastIdFromTable("soft_users");
            string hpwd = GetHashString(GetHashString(password));
            DataManipulator.insertIntoSoftUsers(new SoftUser(id, login, hpwd));
        }


        public static void deleteUser(string login)
        {
            DataManipulator.deleteFromSoftUsers(login);
        }


        public static void changeAdminPassword(string oldPassword, string newPassword)
        {
            if (Model.userExists("admin", oldPassword))
                DataManipulator.changeAdminPasswordInSoftUsers(GetHashString(GetHashString(newPassword)));
        }


        public static Patient getPatient(string policy)
        {
            string condition = "WHERE policy = '" + policy + "'";

            List<Patient> listPatient = DataManipulator.getPatientByCondition(condition);

            return listPatient[0];
        }



        public static void getData(BindingSource bindingSource1, DataGridView scheduleDataGridView, string specialization,
                          string fromDate, string toDate, string busy)
        {
            string doctorQuery = "";
            string scheduleQuery = "";
            string query = "";

            if (specialization != "")
            {
                doctorQuery = "select * from doctors where specialization_id = '" + specialization + "' ";
            }

            scheduleQuery = " where time_of_receipt::date >= '" + fromDate + "' ";

            if (toDate != "")
            {
                scheduleQuery += " and time_of_receipt::date <= '" + toDate + "' ";
            }

            scheduleQuery += " and busy = " + "'" + busy + "' ";

            if (doctorQuery != "")
            {
                query += "select schedule.id, needed_doctor.first_name, needed_doctor.middle_name,"+ 
                         "needed_doctor.last_name, schedule.time_of_receipt," +
                         "schedule.cabinet_id, schedule.patient_id, schedule.busy from " +
                         "schedule inner join (" + doctorQuery + ") as needed_doctor on " +
                         "schedule.doctor_id = needed_doctor.id " + scheduleQuery;
            }
            else
            {
                query += " select * from schedule " + scheduleQuery;
            }

            DataManipulator.getData(bindingSource1, scheduleDataGridView, query);
        }

    }
}
