using FirstProject.BL.Dtos.PatientDto;
using FirstProject.BL.Service.PatientServices;
using FirstProject.DAL.Models;
using FirstProject.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }
       
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(patientService.GetAll(1, 2));
        }
        //[TypeFilter(typeof(testResourceFilterAttribute))]
        [TypeFilter(typeof(TestActionFitlerAttribute))]
        [HttpPost]
        public ActionResult Add(List<PatientWriteDto> patients)
        {
           
                foreach (var patient in patients)
                {
                    patientService.Add(patient);
                }
            
            patientService.SaveChange();

            return NoContent();
        }
    }
}
