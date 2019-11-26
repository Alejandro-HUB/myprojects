using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Name")]
        public String Exercise_Name { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Description")]
        public String Exercise_Description { get; set; }
    }
}
