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

        private int Id;
        private string Nombre;
        private double Precio;
        private string Descripcion;
        private bool esAptoCeliaco;
        private bool esAptoVegano;

    }

}

