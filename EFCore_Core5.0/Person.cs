using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Core5._0
{
    public class Person
    {
        public long Id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public string BirthPlace { get; set; }

        public double? Salary { get; set; }
    }
}
