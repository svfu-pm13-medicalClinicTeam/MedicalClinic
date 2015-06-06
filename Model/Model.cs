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
        public static List<Schedule> getSchedule(string specialization, string fromDate, string toDate,
                                                 string busy = "'f'")
        {
            string query = "";
            string scheduleQuery = "";
            string doctorQuery = "";

            if (specialization != "")
            {
                doctorQuery = "select * from doctors where specialization_id = '" + specialization + "' ";
            }

            scheduleQuery = " where date_of_receipt >= '" + fromDate + "' ";

            if (toDate != "")
            {
                scheduleQuery += " and date_of_receipt <= '" + toDate + "' ";
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



        public static Patient getPatient(string policy)
        {
            string condition = "WHERE policy = '" + policy + "'";

            List<Patient> listPatient = DataManipulator.getPatientByCondition(condition);

            return listPatient[0];
        }



        public static void getData(BindingSource bindingSource1, DataGridView scheduleDataGridView, string specializationId,
                          string fromDate, string toDate, string busy)
        {
            string doctorQuery = "select * from doctors";
            string scheduleQuery = "";
            string query = "";

            if (specializationId != "")
            {
                doctorQuery += " where specialization_id = '" + specializationId + "' ";
            }

            scheduleQuery = " where time_of_receipt::date >= '" + fromDate + "' ";

            if (toDate != "")
            {
                scheduleQuery += " and time_of_receipt::date <= '" + toDate + "' ";
            }

            if (busy != "")
            {
                scheduleQuery += " and busy = " + "'" + busy + "' ";
            }

            query += "select timing.id as ID, timing.Доктор, timing.Время_приема, cabinets.title as Кабинет, " +
                            "timing.Пациент " +
                     "from (select timetable.id as id, timetable.Доктор, timetable.Время_приема," +
                           "timetable.cabinet_id, "+
                           "concat(patients.first_name, ' ', patients.middle_name, ' ', patients.last_name) " +
                           "as Пациент "+
                                  "from (select schedule.id, concat(needed_doctor.first_name, ' ', needed_doctor.middle_name, ' '," +
                                               "needed_doctor.last_name) as Доктор, schedule.time_of_receipt as Время_приема," +
                                               "schedule.cabinet_id, schedule.patient_id " +
                                         "from schedule inner join (" + doctorQuery + ") as needed_doctor " +
                                         "on schedule.doctor_id = needed_doctor.id " + scheduleQuery + ") as timetable " +
                                               "left join patients on timetable.patient_id = patients.id) as timing "+
                           "left join cabinets " +
                                "on timing.cabinet_id = cabinets.id order by ID";

            DataManipulator.getData(bindingSource1, scheduleDataGridView, query);
        }



        public static void addPatient(string firstName, string middleName, string lastName, char gender,
                                      string dateOfBirth, string passport, string policy,
                                      string telephoneNumber)
        {
            int id = DataManipulator.getLastIdFromTable("patients");
            DataManipulator.insertIntoPatients(new Patient(id, firstName, middleName, lastName, gender,
                                                          Convert.ToDateTime(dateOfBirth), passport,
                                                          policy, telephoneNumber));
        }



        public static void addDoctor(string firstName, string middleName, string lastName,
                                     int specializationId, char category, char gender, string dateOfBirth,
                                     string passport, string inn, string snils, string telephoneNumber)
        {
            int id = DataManipulator.getLastIdFromTable("doctors");

            DataManipulator.insertIntoDoctor(new Doctor(id, firstName, middleName, lastName, specializationId,
                                                        category, gender, Convert.ToDateTime(dateOfBirth),
                                                        passport, inn, snils, telephoneNumber));
        }



        public static void addUser(string login, string password)
        {
            int id = DataManipulator.getLastIdFromTable("soft_users");
            string hpwd = GetHashString(GetHashString(password));
            DataManipulator.insertIntoSoftUsers(new SoftUser(id, login, hpwd));
        }



        public static void addAppointment(int scheduleId, int cabinetId, int patientId)
        {
            string condition = " where id = " + scheduleId;
            DataManipulator.updateTable("schedule", "patient_id", patientId.ToString(), 
                                        "cabinet_id", cabinetId.ToString(), condition);
        }



        public static void clearAppointment(int scheduleId)
        {
            string condition = " where id = " + scheduleId;

            DataManipulator.updateTable("schedule", "patient_id", "NULL", "cabinet_id", "NULL", condition);
        }



        public static bool userExists(string login, string password)
        {
            string hpwd = GetHashString(GetHashString(password));
            SoftUser user = DataManipulator.getUserByName(login);
            
            return (hpwd == user.HPWD);
        }



        public static void formNewSchedule(Schedule schedule)
        {
            DataManipulator.insertIntoSchedule(schedule);
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



        private static string GetHashString(string s)
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
    }
}