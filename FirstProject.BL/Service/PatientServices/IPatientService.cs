using FirstProject.BL.Dtos.PatientDto;
using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Service.PatientServices
{
    public interface IPatientService
    {
        IEnumerable<PatientReadWithChildDto> GetAll(int take,int skip);
       // IEnumerable<PatientReadDto> GetAllNoIssue();
        IEnumerable<PatientReadWithChildDto> GetAllAsReadOnly();
        PatientReadWithChildDto GetByID(int id);
        void update(PatientUpdateDto entity);
        void Add(PatientWriteDto entity);
        void Delete(PatientReadDto entity);
        void SaveChange();

    }
}
