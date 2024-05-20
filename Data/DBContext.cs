using BudgetBomb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class DBContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Category> Categories { get; set; }

    public string DbPath { get; }

    public DBContext(DbContextOptions<DBContext> options)
    : base(options)
    { }

}
