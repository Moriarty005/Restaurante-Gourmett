using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GourmetteRestaurante
{
    public partial class Carrito : UserControl
    {
        public Carrito()
        {
            InitializeComponent();

            this.pagar1.Visible = false;
            this.pagar1.SendToBack();

            this.tt_carrito.SetToolTip(this.boton_eliminar, "Seleccione un plato por el nombre y pulse este botón para eliminarlo de su carrito");
            this.tt_carrito.SetToolTip(this.boton_pagar, "Finalize su pedido pulsando este botón");

            this.error.Text = "";
        }

        private void cerrar_carrito_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.error.Text = "";
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            
        }

        public static void refrescarCarrito()
        {
            Console.Write("Entramos en el metodo de actualizar carrito");


            for (int index = 0; index < platos_lista_carrito.Items.Count; index++)
            {
                platos_lista_carrito.Items.RemoveAt(index);
            }
            

            for (int index2 = 0; index2 < Form1.carrito_compra.Count; index2++)
            {
                Console.Write("Entramos en el bucle de los platos");
                ListViewItem item = new ListViewItem(Form1.carrito_compra[index2].getNombre());
                //item.SubItems.Add(Form1.carrito_compra[index2].getNombre());
                item.SubItems.Add(Form1.carrito_compra[index2].getCantidad().ToString());
                item.SubItems.Add((Form1.carrito_compra[index2].getPrecio() * Form1.carrito_compra[index2].getCantidad()).ToString());
                item.SubItems.Add(Form1.carrito_compra[index2].getTipoPlato());
                //item.SubItems.Add("prueba");
                platos_lista_carrito.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in platos_lista_carrito.SelectedItems)
            {
                item.Remove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Form1.carrito_compra.Count == 0)
            {
                this.error.Text = "No puede finalizar el pedido sin tener productos en el carrito";
            }
            else
            {
                this.pagar1.Visible = true;
                this.pagar1.BringToFront();

                this.calcularTotal();
            }
        }

        public void calcularTotal()
        {

            double numero = 0;
            foreach (Plato p in Form1.carrito_compra)
            {
                numero += p.getCantidad() * p.getPrecio();
            }

            this.total.Text = numero.ToString();
        }
    }
}
