using Microsoft.EntityFrameworkCore;
using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.Database
{
    public class ApplicationDbContext : DbContext 
    {
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<UserInfo>? UserInfo { get; set; }
        public virtual DbSet<Address>? Address { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected ApplicationDbContext()
        {

        }
    }
}
