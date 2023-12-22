using FirstProject.DAL.Models;

namespace FirstProject.DAL.Repository
{
    public interface IpatientRepository
    {
        IQueryable<Patient> GetAll();
        IQueryable<Patient> GetAllAsReadOnly();
        Patient GetByID(int id);
        void update(Patient entity);
        void Add(Patient entity);
        void Delete(Patient entity);
        void SaveChange();
    }
}
