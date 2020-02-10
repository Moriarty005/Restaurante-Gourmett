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
    public partial class Detalles_platos : UserControl
    {

        Plato p;


        public Detalles_platos()
        {
            InitializeComponent();
            p = new Plato();
        }

        public Detalles_platos(Plato new_p)
        {
            InitializeComponent();
            this.p = new_p;
            this.foto_plato.BackgroundImage = Image.FromFile(this.p.getImagen());
        }

        public void setInfoPlato(Plato new_p)
        {
            this.p = new_p;
            this.foto_plato.BackgroundImage = Image.FromFile(this.p.getImagen());

            

            foreach (String alergeno in this.p.getAlergenos())
            {
                this.lista_alergenos.Items.Remove(alergeno);
                this.lista_alergenos.Items.Add(alergeno);
            }

            this.ponerEnSeleccionadoTodosLosAlergenos();

            this.precio_plato.Text = this.p.getPrecio() + "$";

            this.cantidad.Text = this.p.getCantidad().ToString();
        }

        public void ponerEnSeleccionadoTodosLosAlergenos()
        {
            for (int index = 0; index < this.lista_alergenos.Items.Count; index++)
            {
                this.lista_alergenos.SetItemChecked(index, true);
            }
        }

        private void Detalles_platos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void plus_button_Click(object sender, EventArgs e)
        {

            if (this.p.getCantidad() < 50)
            {
                this.p.setCantidad(this.p.getCantidad() + 1);
                this.cantidad.Text = this.p.getCantidad().ToString();
            }
        }

        private void less_button_Click(object sender, EventArgs e)
        {
            if (this.p.getCantidad() > 1 )
            {
                this.p.setCantidad(this.p.getCantidad() - 1);
                this.cantidad.Text = this.p.getCantidad().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.lista_alergenos.Items.Count; index++)
            {
                if (!this.lista_alergenos.GetItemChecked(index))
                {
                    this.p.getAlergenos().Remove(this.lista_alergenos.GetSelected(index).ToString());
                }

            }

            Form1.aniadirPlatoACarrito(this.p);
            Form1.actualizarCarrito();

            /*for (int index2 = 0; index2 < this.p.getAlergenos().Count; index2++)
            {
                Console.WriteLine("Alergenos del plato que vamos a insertar :" + this.p.getAlergenos()[index2].ToString());
            }*/
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            /*for (int index = 0; index < this.lista_alergenos.Items.Count; index++)
            {
                if (!this.lista_alergenos.GetItemChecked(index))
                {
                    this.p.getAlergenos().Remove(this.lista_alergenos.GetSelected(index).ToString());
                }

            }*/
            Console.WriteLine("Cuántos platos vamos a insertar: " + this.p.getCantidad());
            Form1.sumarProductos(this.p);
            Form1.aniadirPlatoACarrito(this.p);
            

            for (int index2 = 0; index2 < this.p.getAlergenos().Count; index2++)
            {
                Console.WriteLine("Alergenos del plato que vamos a insertar :" + this.p.getAlergenos()[index2].ToString());
            }
        }
    }
}
