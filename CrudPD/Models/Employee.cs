using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(250, MinimumLength = 3, ErrorMessage = "The lenght of FullName is wrong, please type value 3-250.")]
        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public string FullName { get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "Incorrect value, please type value 3-10.")]
        [Column(TypeName = "nvarchar(10)")]
        public string EmpCode { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Incorrect value, please type value 3-100.")]
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Incorrect value, please type value 3-100.")]
        [Column(TypeName = "nvarchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
