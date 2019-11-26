using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class PlannedWorkout
    {
        [Key]
        [Required]
        public int ExerciseID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Name")]
        public String Exercise_Name { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Planned Set Number")]
        public int Planned_Set_Number { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Planned Reps")]
        public int Planned_Reps { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Planned Weight")]
        public int Planned_Weight { get; set; }
    }
}
