﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onlineStore.Models;

namespace onlineStore.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Value> Values { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
    }
}
