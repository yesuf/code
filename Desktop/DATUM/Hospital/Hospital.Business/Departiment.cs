using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Hospital.DataAccess;

namespace Hospital.Business
{
  public  class Departiment
    {
      HospitalDataContext _context = new HospitalDataContext();
      public void Add(DataAccess.Departiment departiment )
      {
       _context.Departiments.InsertOnSubmit(departiment);
          _context.SubmitChanges();


      
      }
      public void UpdateDeparitmient(DataAccess.Departiment departiment )
      {
          var ObjDeparitmient = GetById(departiment.ID);

          ObjDeparitmient.DeptName = departiment.DeptName;
          ObjDeparitmient.Code = departiment.Code;
          _context.SubmitChanges();
      }
      public void DeleteDeparitmient(int id)
      {
         var ObjDeparitmient = GetById(id);

             _context.Departiments.DeleteOnSubmit(ObjDeparitmient); 

      
      }
      public List<DataAccess.Departiment> GetAll()
      {
          var ObjDeparitmient = from p in _context.Departiments
                                select p;
          return ObjDeparitmient.ToList();


      }
      public DataAccess.Departiment GetById(int id)
      {

          var ObjDeparitmient = from p in _context.Departiments
                            where p.ID == id
                            select p;
          return ObjDeparitmient.SingleOrDefault(); 
      }









          





    }

}
