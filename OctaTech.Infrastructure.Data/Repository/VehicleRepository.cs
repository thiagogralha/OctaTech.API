using Microsoft.EntityFrameworkCore;
using OctaTech.Domain.Entity;
using OctaTech.Domain.Interface.Repository;
using OctaTech.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace OctaTech.Infrastructure.Data.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private IApplicationDbContext _context;

        public VehicleRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles
                .Include(x => x.Parts);
        }

        public Vehicle GetById(int id)
        {
            return _context.Vehicles
                .Include(x => x.Parts)
                .FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Vehicle> GetPaginated(int pageSize, int page, bool orderBy)
        {
            var vehicles = _context.Vehicles
                .Include(x => x.Parts)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            if (orderBy)
                vehicles = vehicles.OrderByDescending(x => x.Id);

            return vehicles;
        }

        public void Remove(Vehicle vehicle)
        {
            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();
        }

        public void Update(Vehicle vehicle)
        {
            _context.Vehicles.Update(vehicle);
            _context.SaveChanges();
        }
    }
}
