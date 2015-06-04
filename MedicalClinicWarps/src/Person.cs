using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicWraps
{
    public class Person
    {
        int id;
        string firstName;
        string middleName;
        string lastName;
        char gender;
        DateTime dateOfBirth;
        string passport;
        string telephoneNumber;

        public Person()
        {
            id = 1;
            firstName = "Иван";
            middleName = "Иванович";
            lastName = "Иванов";
            gender = 'м';
            dateOfBirth = new DateTime(1990, 1, 1);
            passport = "111111111111111111111";
            telephoneNumber = "111111111111";
        }

        public Person(int _id, string _firstName, string _middleName, string _lastName, char _gender,
                      DateTime _dateOfBirth, string _passport, string _telephoneNumber)
        {
            if (isValidInputData(_id, _gender, _passport, _telephoneNumber))
            {
                id = _id;
                firstName = _firstName;
                middleName = _middleName;
                lastName = _lastName;
                gender = _gender;
                dateOfBirth = _dateOfBirth;
                passport = _passport;
                telephoneNumber = _telephoneNumber;
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

        public string TelephoneNumber
        {
            set
            {
                if (isValidTelephoneNumber(value))
                {
                    telephoneNumber = value;
                }
                else
                {
                    throw new PersonInvalidTelephoneNumberException();
                }
            }
            get
            {
                return telephoneNumber;
            }
        }

        private bool isValidInputData(int _id, char _gender, string _passport, string _telephoneNumber)
        {
            return (isValidID(_id) && isValidGender(_gender) && isValidPassport(_passport) &&
                    isValidTelephoneNumber(_telephoneNumber));
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

        private bool isValidTelephoneNumber(string _telephoneNumber)
        {
            int length = 12;

            return (_telephoneNumber.Length <= length);
        }
    }
}
