
namespace FirstProject.DAL.Models
{
    public class Issue
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual IEnumerable<Patient> Patients { get; set; } = new HashSet<Patient>();

    }
}

