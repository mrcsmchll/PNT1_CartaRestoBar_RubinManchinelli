using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Plato
    {
        public Plato(int id, string nombre, double precio, string descripcion, bool esAptoCeliaco, bool esAptoVegano)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.esAptoCeliaco = esAptoCeliaco;
            this.esAptoVegano = esAptoVegano;
        }

        private int Id { get; set; }
        private string Nombre { get; set; }
        private double Precio { get; set; }
        private string Descripcion { get; set; }
        private bool esAptoCeliaco { get; set; }
        private bool esAptoVegano { get; set; }

    }

}

