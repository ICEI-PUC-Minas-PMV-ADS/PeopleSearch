using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace projeto.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {
        }
    }
}
