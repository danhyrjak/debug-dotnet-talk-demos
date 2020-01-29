using DebugOnProdC31.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace DebugOnProdC31.Data
{
    public class RegistrationsDbContext : DbContext
    {
        public RegistrationsDbContext([NotNullAttribute] DbContextOptions<RegistrationsDbContext> options) : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set;}
    }
}
