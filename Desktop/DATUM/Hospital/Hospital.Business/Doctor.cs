using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Hospital.DataAccess;

namespace Hospital.Business
{
   public  class Doctor
   {

       HospitalDataContext _context = new HospitalDataContext();

       
        public void Add(DataAccess.Doctor doctor)
      {
      _context.Doctors.InsertOnSubmit(doctor);
          _context.SubmitChanges();


       }
        public void UpdateDoctor(DataAccess.Doctor doctor)
       {
           var ObjDoctor = GetById(doctor.ID);
           ObjDoctor.ID = doctor.ID;
           ObjDoctor.Name = doctor.Name;
           ObjDoctor.Salary = doctor.Salary;
           ObjDoctor.Designation = doctor.Designation;
           ObjDoctor.DeptID = doctor.DeptID;
           ObjDoctor.DOB = doctor.DOB;
           ObjDoctor.JoinDate = doctor.JoinDate;

       }
           public void DeleteDoctor(int id)
       {
           var ObjDoctor = GetById(id);

           _context.Doctors.DeleteOnSubmit(ObjDoctor);

           _context.SubmitChanges();


       }
           public List<DataAccess.Doctor> GetAll()
       {
           var ObjDoctor = from p in _context.Doctors
            select p;
           return ObjDoctor.ToList();
              
       }
           public  DataAccess.Doctor GetById(int id ) 
       {
         var ObjDoctor = from p in _context.Doctors
                            where p.ID == id
                            select p;
          return ObjDoctor.SingleOrDefault();

       }


   }
}
