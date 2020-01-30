using DebugOnProdF452.Models;
using System.Data.Entity;

namespace DebugOnProdF452.Data
{
    public class RegistrationsDbContext : DbContext
    {
        public RegistrationsDbContext() : base("RegistrationSQLConnection")
        {
        }

        public DbSet<Registration> Registrations { get; set; }
    }
}