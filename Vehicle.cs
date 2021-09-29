using System;

namespace TesteTres.Domain.Entity
{
    public class Repositorio
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public string Owner { get; set; }
    }
}
