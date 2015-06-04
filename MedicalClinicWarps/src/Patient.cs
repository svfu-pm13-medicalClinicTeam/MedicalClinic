using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicWraps
{
    public class Patient : Person
    {
        string policy;

        public Patient()
        {
            policy = "1111111111111111";
        }

        public Patient(int _id, string _firstName, string _middleName, string _lastName, char _gender,
                      DateTime _dateOfBirth, string _passport, string _policy, string _telephoneNumber) :
        base(_id, _firstName, _middleName, _lastName, _gender, _dateOfBirth, _passport, _telephoneNumber)
        {
            if (isValidPolicy(_policy))
            {
                policy = _policy;
            }
            else
            {
                throw new PatientInvalidPolicyException();
            }
        }

        public string Policy
        {
            set
            {
                if (isValidPolicy(value))
                {
                    policy = value;
                }
                else
                {
                    throw new PatientInvalidPolicyException();
                }
            }
            get
            {
                return policy;
            }
        }

        private bool isValidPolicy(string _policy)
        {
            int policyLength = 16;

            return (_policy.Length == policyLength);
        }
    }
}
