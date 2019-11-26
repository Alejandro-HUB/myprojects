using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Staff
    {
        [Key]
        [Required]
        public int StaffID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Last Name")]
        public String LastName { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("First Name")]
        public String FirstName { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public String Occupation { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Organization Name")]
        public String OrganizationName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public String Address { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Phone Number")]
        public String PhoneNumber { get; set; }
    }
}
