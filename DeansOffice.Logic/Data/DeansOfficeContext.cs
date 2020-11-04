using DeansOffice.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DeansOffice.Logic.Data
{
    public class DeansOfficeContext : DbContext
    {
        public DeansOfficeContext(DbContextOptions<DeansOfficeContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentRequest> Requests { get; set; }
        public DbSet<DocumentRequestField> RequestFields { get; set; }
    }
}
