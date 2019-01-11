using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public string CustomerNmae
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public override string ToString()
        {
            return this.CustomerNmae + "-" + this.Address;
        }
    }
}