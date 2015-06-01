using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

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

        public static List<Schedule> getSchedule(string specialization, string category, string fromDate, string toDate,
                                              string fromTime, string toTime, string busy = "'f'")
        {
            string query = "";
            string scheduleQuery = "";
            string doctorQuery = "";

            if (specialization != null)
            {
                doctorQuery = "select * from doctor where specialization = '"+specialization +"' ";
            }

            if (category != null && specialization != null)
            {
                doctorQuery += " and category = '"+category+"' ";
            }
            else if (category != null && specialization == null)
            {
                doctorQuery = "select * from doctor where category = '"+category+"' ";
            } 

            scheduleQuery = " where date_of_receipt >= '"+fromDate+"' ";

            if (toDate != null)
            {
                scheduleQuery += " and date_of_receipt <= '"+toDate+"' ";
            }

            scheduleQuery += " and time_of_receipt >= '"+fromTime+"' ";

            if (toTime != null)
            {
                scheduleQuery += " and time_of_receipt <= '"+toTime+"' ";
            }

            scheduleQuery += " and busy = " + "'" + busy + "' ";

            if (doctorQuery != "")
            {
                query += "select schedule.id, schedule.doctor_id, schedule.date_of_receipt," +
                         "schedule.time_of_receipt, schedule.patient_id, schedule.cabinet, schedule.busy from " +
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
            string query = "select * from doctor ";
            string condition = " where ";

            if (specialization != null)
            {
                condition += "specialization = " + "'" + specialization + "' ";
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


        
        public static void addPatient(Patient patient)
        {
            DataManipulator.insertIntoPatient(patient);
        }



        public static void addDoctor(Doctor doctor)
        {
            DataManipulator.insertIntoDoctor(doctor);
        }


            
        public static void addUser(string login, string password)
        {
            string hpwd = GetHashString(GetHashString(password));
            DataManipulator.insertIntoSoftUsers(new SoftUser(1, login, hpwd));
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


        public static Patient getPatient(string polis)
        {
            string condition = "WHERE polis = '" + polis + "'";

            List<Patient> listPatient = DataManipulator.getPatientByCondition(condition);

            return listPatient[0];
        }
    }
}
