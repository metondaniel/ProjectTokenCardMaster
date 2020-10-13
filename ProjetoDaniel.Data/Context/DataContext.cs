using Microsoft.EntityFrameworkCore;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Pizza> Pizza { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pizza>()
            .HasKey(pi => new { pi.Id });

            builder.Entity<TipoPizza>()
            .HasKey(tp => new { tp.Id });

            builder.Entity<TipoPizza>()
            .HasData(new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Três Queijos", Preco = 50 },
            new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Frango Requeijao", Preco = 59.99 },
            new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Mussarela", Preco = 42.50 },
            new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Calabresa", Preco = 42.50 },
            new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Pepperoni", Preco = 55 },
            new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Portuguesa", Preco = 45 },
            new TipoPizza() { Id = Guid.NewGuid(), Tipo = "Veggie", Preco = 59.99 });

            builder.Entity<Porcao>()
            .HasKey(po => new { po.Id });

            builder.Entity<Porcao>()
            .HasData(new Porcao() { Id = Guid.NewGuid() , Tipo = 0.5 },
            new Porcao() { Id = Guid.NewGuid(), Tipo = 1 });

            builder.Entity<Pizza>()
               .HasOne(pe => pe.Porcao);

            builder.Entity<Pizza>()
               .HasOne(pe => pe.TipoPizza);

            builder.Entity<Pedido>()
            .HasKey(pe => new { pe.Id });

            builder.Entity<Pedido>()
               .HasMany(pe => pe.Pizza).WithOne(pi => pi.Pedido);

            builder.Entity<Pedido>()
               .HasOne(pe => pe.Cliente);

            builder.Entity<Cliente>()
            .HasKey(pe => new { pe.Id });

            builder.Entity<Cliente>()
               .HasOne(pe => pe.Endereco);
        }

    }
    }
