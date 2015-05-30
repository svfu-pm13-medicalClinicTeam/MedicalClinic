using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MedicalClinic
{
    static class Model
    {
        public static bool userExists(string login, string password)
        {
            string hpwd = GetHashString(GetHashString(password));
            SoftUser user = DataManipulator.getUserByName(login);
            
            return (hpwd == user.HPWD);
        }

        static string GetHashString(string s)
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
