using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.DataAccess;

namespace Hospital.Business
{
    public class Login1
    {
        HospitalDataContext _context = new HospitalDataContext();
        public void Add(DataAccess.Login1 login)
        {

            _context.Login1s.InsertOnSubmit(login);

            _context.SubmitChanges();

        }
        public List<DataAccess.Login1> GetAll()
        {
            var Objlogin = from p in _context.Login1s
                           select p;
            return Objlogin.ToList();


        }

        public DataAccess.Login1 GetById(int id)
        {

            var Objlogin = from p in _context.Login1s
                           where p.Id == id
                           select p;
            return Objlogin.SingleOrDefault();
        }

        public DataAccess.Login1 Autentication(string lastName, int password)
{
                 var objlogin = from s in _context.Login1s
              where s.LastName == lastName && s.password == password
                         select s;            
                 return objlogin.SingleOrDefault();
}



        
    }
}