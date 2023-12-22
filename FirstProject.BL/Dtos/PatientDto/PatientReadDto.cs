using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Dtos.PatientDto
{
    public class PatientReadDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
    }
}
//name, Minimum, Maximum

//name, MaximumLength, MinimumLength