using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PNT1_CartaRestoBar_RubinManchinelli.Models;

namespace PNT1_CartaRestoBar_RubinManchinelli.Context
{
    public class RestaurantDatabaseContext : DbContext
    {
        public RestaurantDatabaseContext(DbContextOptions<RestaurantDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurant { get; set; }
    }
}
