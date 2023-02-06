using infinity_talent.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace infinity_talent.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateContacts> CandidatesContacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
