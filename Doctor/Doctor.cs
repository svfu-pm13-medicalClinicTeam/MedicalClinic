using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class Doctor : Person
    {
        string specialization;
        string category;
        string inn;
        string snils;

        public Doctor()
        {
            specialization = "Терапевт";
            category = "1";
            inn = "111111111111";
            snils = "11111111111";
        }

        public Doctor(int _id, string _firstName, string _middleName, string _lastName, string _specialization,
                      string _category, char _gender, DateTime _dateOfBirth, string _passport, string _inn, string _snils,
                      string _telephoneNumber) : 
        base(_id, _firstName, _middleName, _lastName, _gender, _dateOfBirth, _passport, _telephoneNumber)
        {
            if (isValidInputData(_category, _inn, _snils))
            {
                category = _category;
                specialization = _specialization;
                inn = _inn;
                snils = _snils;
            }
            else
            {
                throw new DoctorInvalidInputDataException();
            }
        }

        public string Specialization
        {
            set
            {
                specialization = value;
            }
            get
            {
                return specialization;
            }
        }

        public string INN
        {
            set
            {
                if (isValidINN(value))
                {
                    inn = value;
                }
                else
                {
                    throw new DoctorInvalidInnException();
                }
            }
            get
            {
                return inn;
            }
        }

        public string Snils
        {
            set
            {
                if (isValidSnils(value))
                {
                    snils = value;
                }
                else
                {
                    throw new DoctorInvalidSnilsException();
                }
            }
            get
            {
                return snils;
            }
        }

        public string Category
        {
            set
            {
                if (isValidCategory(value))
                {
                    specialization = value;
                }
                else
                {
                    throw new DoctorInvalidCategoryException();
                }
            }
            get
            {
                return category;
            }
        }

        private bool isValidInputData(string _category, string _inn, string _snils)
        {
            return (isValidCategory(_category) && isValidINN(_inn) && isValidSnils(_snils));
        }

        private bool isValidCategory(string _category)
        {
            return (_category == "1" || _category == "2" || _category == "Высшая");
        }

        private bool isValidINN(string _inn)
        { 
            int innLength = 12;
            
            return (_inn.Length == innLength);
        }

        private bool isValidSnils(string _snils)
        {
            int snilsLength = 11;

            return (_snils.Length == snilsLength);
        }
    }
}
