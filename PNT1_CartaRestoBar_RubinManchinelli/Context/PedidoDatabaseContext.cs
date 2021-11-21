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
    }
}
