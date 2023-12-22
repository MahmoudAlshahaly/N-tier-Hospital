using FirstProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DAL.DB
{
    public class HospitalDB:DbContext
    {
        public HospitalDB(DbContextOptions<HospitalDB> Options) : base(Options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Issue> Issues { get; set; }

    
    }
}
