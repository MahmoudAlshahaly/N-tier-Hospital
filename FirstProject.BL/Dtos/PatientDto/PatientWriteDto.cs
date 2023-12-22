using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Dtos.PatientDto
{
    public class PatientWriteDto
    {
        [StringLength(maximumLength:20, MinimumLength = 10, ErrorMessage = "{0} lenght from {2} to {1}")]
        public string name { get; set; }
        [Range(10, 20, ErrorMessage = "{0} from {1} to {2}")]
        public int age { get; set; }
        public string address { get; set; }
    }
}
