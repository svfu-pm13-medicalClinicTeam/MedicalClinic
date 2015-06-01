using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class Person
    {
        int id;
        string firstName;
        string middleName;
        string lastName;
        char gender;
        DateTime dateOfBirth;
        string passport;
        string inn;

        public Person()
        {
            id = 2;
            firstName = "Иван";
            middleName = "Иванович";
            lastName = "Иванов";
            gender = 'м';
            dateOfBirth = new DateTime(1990, 1, 1);
            passport = "111111111111111111121";
            inn = "111111111112";
        }

        public Person(int _id, string _firstName, string _middleName, string _lastName, char _gender,
                      DateTime _dateOfBirth, string _passport, string _inn)
        {
            if (isValidInputData(_id, _gender, _passport, _inn))
            {
                id = _id;
                firstName = _firstName;
                middleName = _middleName;
                lastName = _lastName;
                gender = _gender;
                dateOfBirth = _dateOfBirth;
                passport = _passport;
                inn = _inn;
            }
            else
            {
                throw new PersonInvalidInputDataException();
            }
        }

        public int ID
        {
            set
            {
                if (isValidID(value))
                {
                    id = value;
                }
                else 
                {
                    throw new PersonInvalidIDException();
                }
            }
            get
            {
                return id;
            }
        }

        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }

        public string MiddleName
        {
            set
            {
                middleName = value;
            }
            get
            {
                return middleName;
            }
        }

        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }

        public char Gender
        {
            set
            {
                if (isValidGender(value))
                {
                    gender = value;
                }
                else
                {
                    throw new PersonInvalidGenderException();
                }
            }
            get
            {
                return gender;
            }
        }

        public DateTime DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
            get
            {
                return dateOfBirth;
            }
        }

        public string Passport
        {
            set
            {
                if (isValidPassport(value))
                {
                    passport = value;
                }
                else
                {
                    throw new PersonInvalidPassportException();
                }
            }
            get
            {
                return passport;
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
                    throw new PersonInvalidInnException();
                }
            }
            get
            {
                return inn;
            }
        }

        private bool isValidInputData(int _id, char _gender, string _passport, string _inn)
        {
            return (isValidID(_id) && isValidGender(_gender) && isValidPassport(_passport) && isValidINN(_inn));
        }

        private bool isValidID(int _id)
        {
            return (_id > 0);
        }

        private bool isValidGender(char _gender)
        {
            return (_gender == 'м' || _gender == 'ж');
        }

        private bool isValidPassport(string _passport)
        {
            int passportLength = 21;

            return (_passport.Length > 0 && _passport.Length <= passportLength);
        }

        private bool isValidINN(string _inn)
        {
            int innLength = 12;

            return (_inn.Length == innLength);
        }
    }
}
