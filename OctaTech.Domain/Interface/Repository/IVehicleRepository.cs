using OctaTech.Domain.Entity;
using System.Collections.Generic;

namespace OctaTech.Domain.Interface.Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        void Add(Vehicle vehicle);
        Vehicle GetById(int id);
        void Update(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        IEnumerable<Vehicle> GetPaginated(int pageSize, int page,bool orderBy);
    }
}
