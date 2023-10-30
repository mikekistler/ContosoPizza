using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza.Data;

// Represents the session with the database
public class ContosoPizzaContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Copilot suggested this connection string
        //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ContosoPizza;Integrated Security=True");
        // This is the connection string from the tutorial
        //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;");
        // This was my attempt to manufacture a connection string based on the PokemonReviews tutorial
        //optionsBuilder.UseSqlServer(@"Data Source=CPC-mikek-U6I7B\\SQLEXPRESS;Initial Catalog=ContosoPizza;Integrated Security=True");
        // This is the connection string that worked -- only _after_ I created the DB in SSMS
        optionsBuilder.UseSqlServer(@"Data Source=CPC-mikek-U6I7B\SQLEXPRESS;Initial Catalog=ContosoPizza;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
