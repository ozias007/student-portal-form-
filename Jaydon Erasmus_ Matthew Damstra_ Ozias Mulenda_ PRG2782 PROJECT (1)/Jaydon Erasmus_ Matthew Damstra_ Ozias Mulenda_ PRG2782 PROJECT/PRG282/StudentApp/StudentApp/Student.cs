using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Student
    {
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string ImageUrl { get; set; }

        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string ModuleCodes { get; set; }
    }
}
