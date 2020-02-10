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
    public partial class Pasta : UserControl
    {
        List<Plato> lp = new List<Plato>();
        public Pasta()
        {
            InitializeComponent();
        }

        private void Pasta_Load(object sender, EventArgs e)
        {

        }

        public void guardarPLatos(List<Plato> lista_platos)
        {
            foreach (Plato p in lista_platos)
            {
                if (p.getTipoPlato().Equals("Pasta"))
                {
                    this.lp.Add(p);
                }
            }
            //this.lp = lista_platos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Valor de la longitud del array: " + lp.Count);

            //lp[1].toStringPlato();
            this.detalles_platos1.setInfoPlato(lp[0]);
            //Console.WriteLine("traemos el cu al frente");
            this.detalles_platos1.Visible = true;
            this.detalles_platos1.BringToFront();
        }

        private void boton_plato_2_Click(object sender, EventArgs e)
        {
            this.detalles_platos1.setInfoPlato(lp[1]);
            //Console.WriteLine("traemos el cu al frente");
            this.detalles_platos1.Visible = true;
            this.detalles_platos1.BringToFront();
        }

        private void boton_plato_3_Click(object sender, EventArgs e)
        {
            this.detalles_platos1.setInfoPlato(lp[2]);
            //Console.WriteLine("traemos el cu al frente");
            this.detalles_platos1.Visible = true;
            this.detalles_platos1.BringToFront();
        }

        private void boton_plato_4_Click(object sender, EventArgs e)
        {
            this.detalles_platos1.setInfoPlato(lp[3]);
            //Console.WriteLine("traemos el cu al frente");
            this.detalles_platos1.Visible = true;
            this.detalles_platos1.BringToFront();
        }

        public void setInfoDePlatos()
        {
            boton_plato_1.BackgroundImage = Image.FromFile(lp[0].getImagen());
            boton_plato_2.BackgroundImage = Image.FromFile(lp[1].getImagen());
            boton_plato_3.BackgroundImage = Image.FromFile(lp[2].getImagen());
            boton_plato_4.BackgroundImage = Image.FromFile(lp[3].getImagen());

            this.nombre_plato_1.Text = this.lp[0].getNombre();
            this.nombre_plato_2.Text = this.lp[1].getNombre();
            this.nombre_plato_3.Text = this.lp[2].getNombre();
            this.nombre_plato_4.Text = this.lp[3].getNombre();

            this.precio_plato_1.Text = this.lp[0].getPrecio() + "$";
            this.precio_plato_2.Text = this.lp[1].getPrecio() + "$";
            this.precio_plato_3.Text = this.lp[2].getPrecio() + "$";
            this.precio_plato_4.Text = this.lp[3].getPrecio() + "$";
        }
    }
}
