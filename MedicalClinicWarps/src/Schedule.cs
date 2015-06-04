using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicWraps
{
    public class Schedule
    {
        int id;
        int doctorId;
        DateTime timeOfReceipt;
        int cabinetId;
        int patientId;
        bool busy;

        public Schedule()
        {
            id = 1;
            doctorId = 1;
            timeOfReceipt = new DateTime(1, 1, 2015, 13, 30, 0);
            cabinetId = 1;
            patientId = 1;
            busy = true;
        }

        public Schedule(int _id, int _doctorId, DateTime _timeOfReceipt, int _cabinetId,
                        int _patientId, bool _busy)
        {
            if (isValidId(_id) && isValidId(_doctorId) && isValidId(_patientId) && isValidId(cabinetId))
            {
                id = _id;
                doctorId = _doctorId;
                timeOfReceipt = _timeOfReceipt;
                cabinetId = _cabinetId;
                patientId = _patientId;
                busy = _busy;
            }
            else
            {
                throw new ScheduleInvalidIdException();
            }
        }

        public int CabinetId
        {
            set
            {
                if (isValidId(value))
                {
                    cabinetId = value;
                }
            }
            get
            {
                return cabinetId;
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
                    throw new ScheduleInvalidIdException();
                }
            }
            get
            {
                return id;
            }
        }

        public int DoctorID
        {
            set
            {
                if (isValidId(value))
                {
                    doctorId = value;
                }
                else
                {
                    throw new ScheduleInvalidIdException();
                }
            }
            get
            {
                return doctorId;
            }
        }

        public int PatientID
        {
            set
            {
                if (isValidId(value))
                {
                    patientId = value;
                }
                else
                {
                    throw new ScheduleInvalidIdException();
                }
            }
            get
            {
                return patientId;
            }
        }

        public DateTime TimeOfReceipt
        {
            set
            {
                timeOfReceipt = value;
            }
            get
            {
                return timeOfReceipt;
            }
        }

        public bool Busy
        {
            set
            {
                busy = value;
            }
            get
            {
                return busy;
            }
        }

        bool isValidId(int _id)
        {
            return (_id > 0);
        }
    }
}
