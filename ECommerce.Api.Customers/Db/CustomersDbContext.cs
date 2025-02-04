﻿using Microsoft.EntityFrameworkCore;
using System.Data;


namespace ECommerce.Api.Customers.Db
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomersDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
