using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class Patient : Person
    {
        string polis;
        string snils;

        public Patient()
        {
            polis = "1111111211111111";
            snils = "11111113111";
        }

        public Patient(int _id, string _firstName, string _middleName, string _lastName, char _gender,
                      DateTime _dateOfBirth, string _passport, string _inn, string _polis, string _snils) :
        base(_id, _firstName, _middleName, _lastName, _gender, _dateOfBirth, _passport, _inn)
        {
            if (isValidPolis(_polis))
            {
                polis = _polis;
            }
            else
            {
                throw new PatientInvalidPolisException();
            }

            if (isValidSnils(_snils))
            {
                snils = _snils;
            }
            else
            {
                throw new PatientInvalidSnilsException();
            }
        }

        public string Polis
        {
            set
            {
                if (isValidPolis(value))
                {
                    polis = value;
                }
                else
                {
                    throw new PatientInvalidPolisException();
                }
            }
            get
            {
                return polis;
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
                    throw new PatientInvalidSnilsException();
                }
            }
            get
            {
                return snils;
            }
        }

        private bool isValidPolis(string _polis)
        {
            int polisLength = 16;

            return (_polis.Length == polisLength);
        }

        private bool isValidSnils(string _snils)
        {
            int snilsLength = 11;

            return (_snils.Length == snilsLength);
        }
    }
}
