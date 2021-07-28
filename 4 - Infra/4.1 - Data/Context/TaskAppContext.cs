using Microsoft.EntityFrameworkCore;
using Task.Domain.Entities;

namespace Task.Infra.Data.Context
{
    public class taskAppContext : DbContext
    {
        public taskAppContext(DbContextOptions<taskAppContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSets 

        public DbSet<User> Users { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }

        #endregion
    }
}