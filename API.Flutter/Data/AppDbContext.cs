﻿using API.Flutter.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Flutter.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
