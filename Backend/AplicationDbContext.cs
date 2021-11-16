using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Comentario> Comentario { get; set; }
        // SQL Server - appsettings // "DefaultConnection": "Server=DESKTOP-FU3S2O4;Database=IngresoGastoDB;Trusted_Connection=True;MultipleActiveResultSets=true"
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
