using CRUD_DOTNET6.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_DOTNET6.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public  DbSet<Category> Categories { get; set; }
    }
}
