using FirstProject.BL.Dtos.IssueDto;
using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Dtos.PatientDto
{
    public class PatientReadWithChildDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public virtual IEnumerable<IssueReadDto> Issues { get; set; } = new HashSet<IssueReadDto>();
    }
}
