using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Core5._0
{
    [Table("T_Cats")]
    public class Cat
    {
        public long Id { get; set; }//主键

        [Required]
        [MaxLength(22)]
        public string Name { get; set; }//标题

        public int age { get; set; }
    }
}
