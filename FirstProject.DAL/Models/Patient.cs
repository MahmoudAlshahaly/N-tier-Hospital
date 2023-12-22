namespace FirstProject.DAL.Models
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        public virtual IEnumerable<Issue> Issues  { get; set; }=new HashSet<Issue>();   
    }
}
