using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Postre : Plato
    {
        public Postre(int id, string nombre, double precio, string descripcion, bool esAptoCeliaco, bool esAptoVegano) : base(id, nombre, precio, descripcion, esAptoCeliaco, esAptoVegano)
        {

        }
    }
}
