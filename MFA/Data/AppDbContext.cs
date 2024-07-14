﻿using Authenticator.Models;
using Microsoft.EntityFrameworkCore;

namespace Authenticator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
