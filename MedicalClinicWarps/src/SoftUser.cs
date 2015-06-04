using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicWraps
{
    public class SoftUser
    {
        int id;
        string login;
        string hpwd;

        public SoftUser()
        {
            id = 1;
            login = "";
            hpwd = "11111111111111111111111111111111";
        }

        public SoftUser(int _id, string _login, string _hpwd)
        {
            if (isValidInpuData(_id, _login, _hpwd))
            {
                id = _id;
                login = _login;
                hpwd = _hpwd;
            }
            else
            {
                throw new SoftUserInvalidInputDataException();
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
                    throw new SoftUserInvalidIdException();
                }
            }
            get
            {
                return id;
            }
        }

        public string Login
        {
            set
            {
                if (isValidLogin(value))
                {
                    login = value;
                }
                else
                {
                    throw new SoftUserInvalidLoginException();
                }
            }
            get
            {
                return login;
            }
        }

        public string HPWD
        {
            set
            {
                if (isValidHPWD(value))
                {
                    hpwd = value;
                }
                else
                {
                    throw new SoftUserInvalidHPWDException();
                }
            }
            get
            {
                return hpwd;
            }
        }

        bool isValidInpuData(int _id, string _login, string _hpwd)
        {
            return (isValidID(_id) && isValidLogin(_login) && isValidHPWD(_hpwd));
        }

        bool isValidHPWD(string _hpwd)
        {
            int hpwdLength = 32;

            return (_hpwd.Length == hpwdLength);
        }

        bool isValidID(int _id)
        { 
            return (_id > 0);
        }

        bool isValidLogin(string _login)
        {
            int loginLength = 32;

            return (_login.Length <= loginLength);
        }
    }
}
