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
                doctorQuery = "select * from doctor where specialization = '"+specialization +"'";
            }

            if (category != null && specialization != null)
            {
                doctorQuery += "and category = '"+category+"'";
            }
            else if (category != null && specialization == null)
            {
                doctorQuery = "select * from doctor where category = '"+category+"'";
            } 

            scheduleQuery = "where date_of_receipt >= '"+fromDate+"'";

            if (toDate != null)
            {
                scheduleQuery += "and date_of_receipt <= '"+toDate+"'";
            }

            scheduleQuery += "and time_of_receipt >= '"+fromTime+"'";

            if (toTime != null)
            {
                scheduleQuery += "and time_of_receipt <= '"+toTime+"'";
            }

            scheduleQuery += "and busy = 'f';";

            if (doctorQuery != "")
            {
                query += "select * from schedule.id, schedule.doctor_id, schedule.date_of_receipt," +
                         "schedule.time_of_receipt, schedule.patient_id, schdule.busy from " +
                         "schedule inner join (" + doctorQuery + ") as needed_doctor on" +
                         "schedule.doctor_id = needed_doctor.id " + scheduleQuery;
            }
            else
            {
                query += "select * from schedule" + scheduleQuery;
            }

            return DataManipulator.getSchedule(query);
        }
        public static void formNewSchedule(Schedule schedule);
        
        public static void deleteSchedule(Schedule schedule);
        
        public static List<Schedule> getSchedule(string specialization, string category, string fromDate, string toDate, string fromTime, string toTime, string busy = "'f'")
        
        public static List<Doctor> getDoctors(string specialization, string category, string firstName, string middleName, string lastName);
        
        public static List<Patient> getPatients(string firstName, string middleName, string lastName);
        
        public static void addPatient(Patient patient);
        
        public static void addDoctor(Doctor doctor);
            
        public static void addUser(SoftUser user);
        
        public static void getDoctor(int id);
        
        public static void getPatient(int id);
    }
}
