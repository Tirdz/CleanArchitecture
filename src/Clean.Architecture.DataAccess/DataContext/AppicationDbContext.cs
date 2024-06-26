﻿using Clean.Architecture.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.DataAccess.DataContext;

public class AppicationDbContext : DbContext, IApplicationDbContext
{
    public AppicationDbContext(DbContextOptions<AppicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}

