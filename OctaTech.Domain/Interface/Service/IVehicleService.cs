using OctaTech.Domain.Entity;
using System.Collections.Generic;

namespace OctaTech.Domain.Interface.Service
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAll();
        void Add(Vehicle vehicle);
        Vehicle GetById(int id);
        void Update(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        IEnumerable<Vehicle> GetPaginated(int pageSize, int page, bool orderBy);
    }
}
