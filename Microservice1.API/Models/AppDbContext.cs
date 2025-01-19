﻿using Microsoft.EntityFrameworkCore;

namespace Microservice1.API.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
            
    }
}
