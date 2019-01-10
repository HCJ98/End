using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string Image { get; set; }
        //头像地址
        [Display(Name= "头像")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}