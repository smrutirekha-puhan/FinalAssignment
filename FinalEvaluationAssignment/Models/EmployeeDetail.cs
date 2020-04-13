using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName ="varchar(60)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "varchar(60)")]
        public string email { get; set; }

        [Required]
        [Column(TypeName = "varchar(45)")]
        public string password { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string dob { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]

        public string doj { get; set; }
    }
}
