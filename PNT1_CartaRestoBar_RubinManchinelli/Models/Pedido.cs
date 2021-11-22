using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{

    public class Pedido
    {
        public Pedido(int id, Cliente c)
        {
            this.Id = id;
            this.Cliente = c;
            this.platos = new List<Plato>();

        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }

        public List<Plato> platos;

    }


}

