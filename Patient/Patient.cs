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

        public Patient()
        {
            polis = "1111111211111111";
        }

        public Patient(int _id, string _firstName, string _middleName, string _lastName, char _gender,
                      DateTime _dateOfBirth, string _passport, string _polis, string _telephoneNumber) :
        base(_id, _firstName, _middleName, _lastName, _gender, _dateOfBirth, _passport, _telephoneNumber)
        {
            if (isValidPolis(_polis))
            {
                polis = _polis;
            }
            else
            {
                throw new PatientInvalidPolisException();
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

        private bool isValidPolis(string _polis)
        {
            int polisLength = 16;

            return (_polis.Length == polisLength);
        }
    }
}
