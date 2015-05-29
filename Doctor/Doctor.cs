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

        public Doctor()
        {
            specialization = "Терапевт";
            category = "1";
        }

        public Doctor(int _id, string _firstName, string _middleName, string _lastName, char _gender,
                      DateTime _dateOfBirth, string _passport, string _inn, string _specialization, string _category) : 
        base(_id, _firstName, _middleName, _lastName, _gender, _dateOfBirth, _passport, _inn)
        {
            specialization = _specialization;
            if (isValidCategory(_category))
            {
                category = _category;
            }
            else
            {
                throw new DoctorInvalidCategoryException();
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

        private bool isValidCategory(string _category)
        {
            return (_category == "1" || _category == "2" || _category == "Высшая");
        }
    }
}
