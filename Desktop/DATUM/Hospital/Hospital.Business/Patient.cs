using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Hospital.DataAccess;


namespace Hospital.Business
{
    public class Patient
    {
        HospitalDataContext _context = new HospitalDataContext();

        public void Add(DataAccess.Patient patient)
        {
            _context.Patients.InsertOnSubmit(patient);
            _context.SubmitChanges();

        }
        public void UpdatePatient(DataAccess.Patient patient)
        {
            var ObjPatient = GetById(patient.Id);

            ObjPatient.PatientName = patient.PatientName;
            ObjPatient.Gender = patient.Gender;
            ObjPatient.Age = patient.Age;
            ObjPatient.City = patient.City;

        }
        public void DeletePatient(int id)
        {
            var ObjPatient = GetById(id);

            _context.Patients.DeleteOnSubmit(ObjPatient);

            _context.SubmitChanges();

        }
        public List<DataAccess.Patient> GetAll()
        {
            var ObjPatient = from p in _context.Patients
                             select p;
            return ObjPatient.ToList();

        }
        public DataAccess.Patient GetById(int id)
        {

            var ObjPatient = from p in _context.Patients
                             where p.Id == id 
                             select p;
            return ObjPatient.SingleOrDefault();

        }

    }
}
