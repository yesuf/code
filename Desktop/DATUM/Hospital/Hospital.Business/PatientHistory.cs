using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Hospital.DataAccess;

namespace Hospital.Business
{
   public  class PatientHistory
    {

       HospitalDataContext _context = new HospitalDataContext();

       public void Add(DataAccess.PatientHistory patientHistory)
       {
           _context.PatientHistories.InsertOnSubmit(patientHistory);
           _context.SubmitChanges();



        }
       public void UpdatePatientHistory(DataAccess.PatientHistory patientHistory)
        {
            var ObjPatientHistory = GetById(patientHistory.ID);

            ObjPatientHistory.AdmissionDate = patientHistory.AdmissionDate;
                
                 ObjPatientHistory.Doctor = patientHistory.Doctor;

                 ObjPatientHistory.DoctorID = patientHistory.DoctorID;

                 ObjPatientHistory.PatientID =  patientHistory.PatientID ;

                 ObjPatientHistory.ReleaseDate = patientHistory.ReleaseDate;

                 ObjPatientHistory.Ward = patientHistory.Ward;
             

        }
       public void DeletePatientHistory(int id)

        {
            var ObjPatientHistory = GetById(id);

            _context.PatientHistories.DeleteOnSubmit(ObjPatientHistory);

            _context.SubmitChanges();
      

        }
        public List<DataAccess.PatientHistory> GetAll()
        {
            var ObjPatientHistory = from p in _context.PatientHistories
                                    select p;
         return ObjPatientHistory.ToList();

        }
        public DataAccess.PatientHistory GetById(int id)
        {

            var ObjPatientHistory = from p in _context.PatientHistories
                                  where p.ID == id
                                  select p;
            return ObjPatientHistory.SingleOrDefault();
        }


    }
}
