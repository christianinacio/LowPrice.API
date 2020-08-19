using System;
using System.Collections.Generic;
using System.Linq;
using LowPrice.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LowPrice.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}