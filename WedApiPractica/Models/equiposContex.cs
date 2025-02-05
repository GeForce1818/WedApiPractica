using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using webApiPractica.Models;

namespace WedApiPractica.Models
{
    public class equiposContex : DbContext
    {
        public equiposContex (DbContextOptions<equiposContex> options) : base(options) 
        { 
        
        }
        public DbSet<equipos> equipos { get; set; }

    }
}
