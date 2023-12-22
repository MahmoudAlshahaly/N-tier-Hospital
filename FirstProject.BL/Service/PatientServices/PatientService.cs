using FirstProject.BL.Dtos.IssueDto;
using FirstProject.BL.Dtos.PatientDto;
using FirstProject.BL.Service.PatientServices;
using FirstProject.DAL.DB;
using FirstProject.DAL.Models;
using FirstProject.DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.BL.Service.PatientServices
{
    public class PatientService : IPatientService
    {
        private readonly IpatientRepository patientRepository;
        public PatientService(IpatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }
        public void Add(PatientWriteDto entity)
        {
            var patientModel = new Patient
            {
                name = entity.name,
                age = entity.age,
                address = entity.address
            };
             
            patientRepository.Add(patientModel);

        }

        public void Delete(PatientReadDto entity)
        {
            var patientModel = new Patient
            {
                name = entity.name,
                age = entity.age,
                address = entity.address
            };

            patientRepository.Delete(patientModel);
        }

        public IEnumerable<PatientReadWithChildDto> GetAll( int skip, int take)
        {
          var patientDto= patientRepository.GetAll().Include(i=>i.Issues).Select(p=>new PatientReadWithChildDto
          {
              id = p.id,
              name = p.name,
              age= p.age,
              address = p.address,Issues = p.Issues.Select(i=>new IssueReadDto
              {
                  id=i.id,
                  name=i.name
              })
          }).Skip(skip).Take(take).ToList();
            return patientDto;
        }

        public IEnumerable<PatientReadWithChildDto> GetAllAsReadOnly()
        {
            var patientDto = patientRepository.GetAll().Include(i => i.Issues).Select(p => new PatientReadWithChildDto
            {
                id = p.id,
                name = p.name,
                age = p.age,
                address = p.address,
                Issues = p.Issues.Select(i => new IssueReadDto
                {
                    id = i.id,
                    name = i.name
                })
            }).ToList();
            return patientDto;
        }

        public PatientReadWithChildDto GetByID(int id)
        {
            var patientModel = patientRepository.GetByID(id);
            var patientDto = new PatientReadWithChildDto()
            {
                id= patientModel.id,
                name= patientModel.name,
                age = patientModel.age,
                address = patientModel.address,
                Issues = patientModel.Issues.Select(i => new IssueReadDto
                {
                    id = i.id,
                    name = i.name
                })
            };
            return patientDto;
        }
        public void SaveChange()
        {
            patientRepository.SaveChange();
        }
        public void update(PatientUpdateDto entity)
        {

            Patient patientModel = new Patient
            {
                id = entity.id,
                name = entity.name,
                age = entity.age,
                address = entity.address
            };
          //patientRepository.update(patientModel);
        }
    }
}
