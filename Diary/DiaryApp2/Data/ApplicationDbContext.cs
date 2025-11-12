using DiaryApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

    }
}
