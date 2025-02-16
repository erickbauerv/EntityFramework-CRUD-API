﻿using CRUD_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Data
{
  public class AppDbContext : DbContext
  {
    private DbSet<Student> Students {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true");
      base.OnConfiguring(optionsBuilder);
    }
  }
}
