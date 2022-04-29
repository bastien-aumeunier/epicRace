using System;
using App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App.Models.configuration;

namespace App.Data;

public class AppDbContext : IdentityDbContext<Pilote>
{
    public DbSet<Pilote> Pilotes { get; set; }
    public DbSet<Race> Races { get; set; }

    public DbSet<CarsType> CarsTypes {get; set;}

    public DbSet<PiloteCar> PiloteCars {get; set;}

    public DbSet<Car> Cars {get; set;}
    public DbSet<RaceResult> RaceResults { get; set; }
    public DbSet<ResultItem> ResultItem { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new Role());
    }
}