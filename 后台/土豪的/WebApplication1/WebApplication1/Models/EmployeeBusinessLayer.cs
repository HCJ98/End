using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;
using System.Data.Entity;


namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            using (SalesERPDAL dal = new SalesERPDAL())
            {

                var list = dal.Employees.ToList();
                return list;
            }
        }
        public void Add(Employee emp)
        {
            using (var db = new SalesERPDAL())
            {
                db.Employees.Add(emp);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var db = new SalesERPDAL())
            {
                Employee emp = db.Employees.Find(id);
                db.Entry(emp).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Employee Query(int id)
        {
            using (var db = new SalesERPDAL())
            {
                Employee emp = db.Employees.Find(id);
                return emp;
            }
        }

        public void Update(Employee emp)
        {
            using (var db=new SalesERPDAL())
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<Employee> Search(string searchSting)
        {
            using (var db= new SalesERPDAL())
            {
                return db.Employees.Where(e => e.Name.Contains(searchSting)).ToList();
            }
        }

    }
}