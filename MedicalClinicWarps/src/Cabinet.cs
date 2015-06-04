using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicWraps
{
    public class Cabinet
    {
        int id;
        string title;

        public Cabinet()
        {
            id = 1;
            title = "1a";
        }

        public Cabinet(int _id, string _title)
        {
            if (isValidId(_id))
            {
                id = _id;
                title = _title;
            }
            else
            {
                throw new CabinetInvalidIdException();
            }
        }

        public int ID
        {
            set
            {
                if (isValidId(value))
                {
                    id = value;
                }
                else
                {
                    throw new CabinetInvalidIdException();
                }
            }
            get
            {
                return id;
            }
        }

        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }

        private bool isValidId(int _id)
        { 
            return (_id > 0);
        }
    }
}
