﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    class Schedule
    {
        int id;
        int doctorId;
        DateTime dateOfReceipt;
        TimeSpan timeOfReceipt;
        int patientId;
        bool busy;

        public Schedule()
        {
            id = 1;
            doctorId = 1;
            dateOfReceipt = new DateTime(1, 1, 2015);
            timeOfReceipt = new TimeSpan(0, 0, 0);
        }

        public Schedule(int _id, int _doctorId, DateTime _dateOfReceipt, TimeSpan _timeOfReceipt,
                        int _patientId, bool _busy)
        {
            if (isValidId(_id))
            {
                id = _id;
                dateOfReceipt = _dateOfReceipt;
                timeOfReceipt = _timeOfReceipt;
                patientId = _patientId;
                busy = _busy;
            }
            else
            {
                throw new ScheduleInvalidIdException();
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

        public DateTime DateOfReceipt
        {
            set
            {
                dateOfReceipt = value;
            }
            get
            {
                return dateOfReceipt;
            }
        }

        public TimeSpan TimeOfReceipt
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