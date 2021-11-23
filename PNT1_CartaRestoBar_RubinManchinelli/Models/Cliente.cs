using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumTelefono { get; set; }
        public string Email { get; set; }

        [EnumDataType(typeof(TipoPago))]
        public TipoPago TipoPago { get; set; }


    }
}
