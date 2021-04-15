using Microsoft.EntityFrameworkCore;
using ProjectTokenCard.Domain.Model;
using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Token> Token { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Card> Card { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Token>()
            .HasKey(pi => new { pi.TokenId });

            builder.Entity<Card>()
            .HasKey(tp => new { tp.CardId });

            builder.Entity<Card>()
            .HasOne(ca => ca.Token);

            builder.Entity<Customer>()
            .HasKey(tp => new { tp.CustomerId });

            builder.Entity<Customer>()
            .HasOne(cus => cus.Card);
        }

    }
    }
