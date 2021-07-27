using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TakeChat.Domain.Entities;

namespace TakeChat.Infra.Data.Context
{
    public class TODOAppContext : DbContext
    {
        public TODOAppContext(DbContextOptions<TODOAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSets 

      //  public DbSet<User> Users { get; set; }
        
        #endregion
    }

}