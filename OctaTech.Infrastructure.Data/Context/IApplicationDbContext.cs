using Microsoft.EntityFrameworkCore;
using OctaTech.Domain.Entity;
using System.Threading.Tasks;

namespace OctaTech.Infrastructure.Data.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Part> Parts { get; set; }
        Task<int> SaveChanges();
    }
}