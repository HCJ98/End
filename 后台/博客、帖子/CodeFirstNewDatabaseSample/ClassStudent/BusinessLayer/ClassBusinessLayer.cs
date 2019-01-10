using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent.Models;
using ClassStudent.DataAccessLayer;

namespace ClassStudent.BusinessLayer
{
    public class ClassBusinessLayer
    {
        public void Add(Class Class)
        {
            using (var db = new ClassContext())
            {
                db.ClassA.Add(Class);
                db.SaveChanges();
            }
        }
        public List<Class> Show()
        {
            using (var db = new ClassContext())
            {
                return db.ClassA.ToList();
            }
        }
    }
}
