using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PNT1_CartaRestoBar_RubinManchinelli.Models;

namespace PNT1_CartaRestoBar_RubinManchinelli.Context
{
    public class PedidoDatabaseContext : DbContext
    {
        public PedidoDatabaseContext(DbContextOptions<PedidoDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Pedido> Pedidos { get; set; }

        private DbSet<Cliente> clientes;

        public DbSet<Cliente> GetClientes()
        {
            return clientes;
        }

        public void SetClientes(DbSet<Cliente> value)
        {
            clientes = value;
        }

        private DbSet<Plato> platos;

        public DbSet<Plato> GetPlatos()
        {
            return platos;
        }

        public void SetPlatos(DbSet<Plato> value)
        {
            platos = value;
        }
    }
}
