﻿using System;
using Collection.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.Data
{
    public class AppDBContent : DbContext
     {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) 
        {

        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
