using FirstProject.DAL.DB;
using FirstProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DAL.Repository
{
    public class PatientRepository : IpatientRepository
    {
        private readonly HospitalDB hospitalDB;
        public PatientRepository(HospitalDB hospitalDB)
        {
            this.hospitalDB = hospitalDB;
        }
        public void Add(Patient entity)
        {
            hospitalDB.Add(entity);
        }
        public void Delete(Patient entity)
        {
            hospitalDB.Remove(entity);
        }
        public IQueryable<Patient> GetAll()
        {
            return hospitalDB.Patients;
        }
        public IQueryable<Patient> GetAllAsReadOnly()
        {
            return hospitalDB.Patients.AsNoTracking();
        }
        public Patient GetByID(int id)
        {
            return hospitalDB.Patients.Find(id);
            //return hospitalDB.Patients.FirstOrDefault(P=>P.id==id);
        }
        public void update(Patient entity)
        {
            //hospitalDB.Update(entity);
        }
        public void SaveChange()
        {
            hospitalDB.SaveChanges();
        }
    }
}
