using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Pedido
    {
        public Pedido() { }
        public Pedido(int id, Cliente c, TipoPlato tp, TipoPlato tipoPlatos)
        {
            this.Id = id;
            this.Cliente = c;
            this.platos = new List<Plato>();
            TipoPlatos = tipoPlatos;
         
            cargarPlato();
        }

        public void cargarPlato()
        {
            platos.Add(new Plato(1, "Pizza", 250, "", false, false));
            platos.Add(new Plato(2, "Pasta", 250, "", false, true));
            platos.Add(new Plato(3, "Carne", 800, "", false, false));
            platos.Add(new Plato(4, "Pescado", 1000, "", false, false));
        }


        public int Id { get; set; }
        public Cliente Cliente { get; set; }

        [EnumDataType(typeof(TipoPlato))]
        public TipoPlato TipoPlatos;

        public List<Plato> platos;

      
    }


}

