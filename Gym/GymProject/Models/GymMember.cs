using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class GymMember
    {
        [Key]
        [Required]
        public int PersonID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Last Name")]
        public String LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("First Name")]
        public String FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Membership End Date")]
        public String Membership_End_Date { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Planned Exercise ID")]
        public int Planned_exercise_id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public String Address { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Phone Number")]
        public String PhoneNumber { get; set; }
    }
}
