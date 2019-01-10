using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        //外键
        public int ClassId { get; set; }
        //导航属性
        public virtual Class Class { get; set; }
    }
}
