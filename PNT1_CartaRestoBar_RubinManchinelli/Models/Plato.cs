using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Plato
    {

        public Plato()
        {

        }

        public Plato(int id, TipoPlato tipo, string nombre, double precio, bool esAptoCeliaco, bool esAptoVegano)
        {
            this.Id = id;
            this.SetTipo(tipo);
            this.Nombre = nombre;
            this.Precio = precio;
            this.esAptoCeliaco = esAptoCeliaco;
            this.esAptoVegano = esAptoVegano;
        }

        public int Id { get; set; }

        public TipoPlato tipo;

        public TipoPlato GetTipo()
        {
            return tipo;
        }

        public void SetTipo(TipoPlato value)
        {
            tipo = value;
        }

        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool esAptoCeliaco { get; set; }
        public bool esAptoVegano { get; set; }

    }

}

