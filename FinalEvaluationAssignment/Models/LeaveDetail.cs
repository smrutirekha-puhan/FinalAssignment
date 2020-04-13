using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName ="varchar(55)")]
        public string leavename { get; set; }

        [Required]
        [Column(TypeName ="int(4)")]
        public int numberOfDays { get; set; }
    }
}
