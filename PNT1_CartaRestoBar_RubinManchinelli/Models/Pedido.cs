using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Pedido
    {
        public Pedido() 
        {
        
        }
       

      /*  public void cargarPlato()
        {
            platos.Add(new Plato(1, TipoPlato.Principal, "Pizza", 250, false, false));
            platos.Add(new Plato(2, TipoPlato.Principal, "Pasta", 250, false, true));
            platos.Add(new Plato(3, TipoPlato.Principal, "Carne", 800, false, false));
            platos.Add(new Plato(4, TipoPlato.Principal, "Pescado", 1000, false, false));
        }
      */
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

  
        [Required]
        [Display(Name = "Nombre de Cliente")]
        public string NombreCliente { get; set; }

        [Required]
        [Display(Name = "Descripcion del Pedido")]
        public string NomPedido { get; set; }

       
        /*
        public string GetNombreCliente()
        {
            return Cliente.Nombre;
        }

        public void SetNombreCliente(string value)
        {
            nombreCliente = Cliente.Nombre;
        }
        */
        [Display(Name = "Tipo de Plato")]
        [EnumDataType(typeof(TipoPlato))]
        public TipoPlato TipoPlatos { get; set; }

        // List<Plato> platos = new List<Plato>();

        [Display(Name ="Precio")]
        [Required]
        public float Precio { get; set; }      
    }


}

