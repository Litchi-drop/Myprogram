using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Core5._0
{
    [Table("student_info")]
    public class Student
    {
        public int Sno { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string Discription { get; set; }

    }
}
