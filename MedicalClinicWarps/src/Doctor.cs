using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicWraps
{
    public class Doctor : Person
    {
        int specialization_id;
        char category;
        string inn;
        string snils;

        public Doctor()
        {
            specialization_id = 1;
            category = '1';
            inn = "111111111111";
            snils = "11111111111";
        }

        public Doctor(int _id, string _firstName, string _middleName, string _lastName, int _specialization_id,
                      char _category, char _gender, DateTime _dateOfBirth, string _passport, string _inn, string _snils,
                      string _telephoneNumber) : 
        base(_id, _firstName, _middleName, _lastName, _gender, _dateOfBirth, _passport, _telephoneNumber)
        {
            if (isValidInputData(_category, _inn, _snils))
            {
                category = _category;
                specialization_id = _specialization_id;
                inn = _inn;
                snils = _snils;
            }
            else
            {
                throw new DoctorInvalidInputDataException();
            }
        }

        public int Specialization
        {
            set
            {
                specialization_id = value;
            }
            get
            {
                return specialization_id;
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

        public char Category
        {
            set
            {
                if (isValidCategory(value))
                {
                    specialization_id = value;
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

        private bool isValidInputData(char _category, string _inn, string _snils)
        {
            return (isValidCategory(_category) && isValidINN(_inn) && isValidSnils(_snils));
        }

        private bool isValidCategory(char _category)
        {
            return (_category == '2' || _category == '1' || _category == 'в');
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
