using OctaTech.Domain.Entity;
using OctaTech.Domain.Interface.Repository;
using OctaTech.Domain.Interface.Service;
using System.Collections.Generic;

namespace OctaTech.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repositorioRepository;

        public VehicleService(IVehicleRepository repositorioRepository)
        {
            _repositorioRepository = repositorioRepository;
        }

        public void Add(Vehicle vehicle)
        {
            _repositorioRepository.Add(vehicle);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _repositorioRepository.GetAll();
        }

        public Vehicle GetById(int id)
        {
            return _repositorioRepository.GetById(id);
        }

        public IEnumerable<Vehicle> GetPaginated(int pageSize, int page, bool orderBy)
        {
            return _repositorioRepository.GetPaginated(pageSize, page, orderBy);
        }

        public void Remove(Vehicle vehicle)
        {
            _repositorioRepository.Remove(vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            _repositorioRepository.Update(vehicle);
        }
    }
}
