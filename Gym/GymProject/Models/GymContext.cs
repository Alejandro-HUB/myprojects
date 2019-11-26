using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class GymContext:DbContext
    {
        public GymContext(DbContextOptions<GymContext> options):base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<PlannedWorkout> PlannedWorkouts { get; set; }
        public DbSet<GymMember> Members { get; set; }
        public DbSet<Staff> Staffs { get; set; }

    }
}
