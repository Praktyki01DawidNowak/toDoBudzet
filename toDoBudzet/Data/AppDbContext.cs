﻿using Microsoft.EntityFrameworkCore;
using toDoBudzet.Models;

namespace toDoBudzet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}
