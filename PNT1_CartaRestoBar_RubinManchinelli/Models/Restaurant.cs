using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNT1_CartaRestoBar_RubinManchinelli.Models
{
    public class Restaurant
    {
        private String nombre;
        private List<Plato> menu;
        private List<Pedido> pedidos;
        private List<Cliente> clientes;

        public Restaurant(string nombre, List<Plato> menu, List<Pedido> pedidos, List<Cliente> clientes)
        {
            this.nombre = nombre;
            this.menu = menu;
            this.pedidos = pedidos;
            this.clientes = clientes;
        }

        public void cargarCliente(Cliente c)
        {

        }

        public void cargarPlato(Plato p)
        {

        }

        public void actualizarPrecio(Plato p, double precio)
        {

        }

        public void agregarPedido(List<Plato> pedido, Cliente c)
        {

        }

        public void eliminarPlato(Plato p)
        {

        }
    }
}
