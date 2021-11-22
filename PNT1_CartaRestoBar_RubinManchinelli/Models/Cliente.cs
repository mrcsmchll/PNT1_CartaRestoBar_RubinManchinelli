using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Cliente
    {
        public Cliente() { }

        public Cliente(int id, string nombre, string apellido, int numTelefono, string email, TipoPago tipoPago)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NumTelefono = numTelefono;
            Email = email;
            TipoPago = tipoPago;
        }


        /*       public Cliente(int id, string nombre, string apellido, int numTelefono, string email, TipoPago tipoPago)
               {
                   this.Id = id;
                   this.Nombre = nombre;
                   this.Apellido = apellido;
                   this.NumTelefono = numTelefono;
                   this.Email = email;
                   this.TipoPago = tipoPago;
               }
        */
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int NumTelefono { get; set; }
        private string Email { get; set; }
        private TipoPago TipoPago { get; set; }


    }
}
