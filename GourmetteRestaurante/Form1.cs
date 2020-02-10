using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GourmetteRestaurante
{
    public partial class Form1 : Form
    {

        List<Button> lista_botones;

        static List<Plato> lista_platos;

        public static List<Plato> carrito_compra;

        public static int numero;

        public Form1()
        {

            lista_platos = new List<Plato>();

            InitializeComponent();
            boton_vegetales.BackgroundImage = Image.FromFile("C:/Users/lolac/source/repos/GourmetteRestaurante/assets/comidas/carrot_icon_128641.png");

            this.invisibilizarCosas();
            this.iniciarBotones();
            
            carrito_compra = new List<Plato>();

            lista_platos = new List<Plato>();

            actualizarCarrito();

            this.crearPlatosYAgregarlos();

            this.vegetales1.guardarPLatos(lista_platos);
            this.vegetales1.setInfoDePlatos();

            this.cocteles1.guardarPLatos(lista_platos);
            this.cocteles1.setInfoDePlatos();

            this.carne1.guardarPLatos(lista_platos);
            this.carne1.setInfoDePlatos();

            this.pescao1.guardarPLatos(lista_platos);
            this.pescao1.setInfoDePlatos();

            this.pasta1.guardarPLatos(lista_platos);
            this.pasta1.setInfoDePlatos();

            this.postres1.guardarPLatos(lista_platos);
            this.postres1.setInfoDePlatos();

            this.seleccionar_tipo_plato1.Visible = true;
            this.seleccionar_tipo_plato1.BringToFront();

            this.pantallaInicial1.Visible = true;
            this.pantallaInicial1.BringToFront();

            numero = 0;

            this.tt_cancelar.SetToolTip(this.cancelar_pedido, "Presione para comenzar su pedido de nuevo");
            this.tt_cancelar.SetToolTip(this.boton_carrito, "Presione para ver cómo va su pedido");
        }

        public void invisibilizarCosas()
        {
            this.vegetales1.Visible = false;
            this.pescao1.Visible = false;
            this.pasta1.Visible = false;
            this.carne1.Visible = false;
            this.cocteles1.Visible = false;
            this.postres1.Visible = false;
            this.carrito1.Visible = false;
        }

        public static List<Plato> buscarPorTipoYDevolverPlatos(string tipo)
        {
            List<Plato> lp = new List<Plato>();

            foreach (Plato p in lista_platos)
            {
                if (p.getTipoPlato().Equals(tipo))
                {

                    Console.WriteLine("Entramos en el insertar plato de los vegetales");
                    lp.Add(p);
                }
            }

            return lp;
            
        }



        public void iniciarBotones()
        {
            this.lista_botones = new List<Button>();
            this.lista_botones.Add(this.boton_bebidas);
            this.lista_botones.Add(this.boton_carne);
            this.lista_botones.Add(this.boton_pasta);
            this.lista_botones.Add(this.boton_pescao);
            this.lista_botones.Add(this.boton_postres);
            this.lista_botones.Add(this.boton_vegetales);
            this.lista_botones.Add(this.boton_carrito);

            foreach (Button b in lista_botones)
            {
                if (!b.Name.Equals("boton_carrito"))
                {
                    b.BackColor = Color.White;
                }
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton_vegetales_Click(object sender, EventArgs e)
        {
            this.checkBotonSelected(this.boton_vegetales);

            this.vegetales1.Visible = true;
            this.vegetales1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.pantallaInicial1.Visible = false;
        }

        private void boton_pescao_Click(object sender, EventArgs e)
        {
            this.checkBotonSelected(this.boton_pescao);

            this.pescao1.Visible = true;
            this.pescao1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.pantallaInicial1.Visible = false;
        }

        private void boton_pasta_Click(object sender, EventArgs e)
        {
            this.checkBotonSelected(this.boton_pasta);

            this.pasta1.Visible = true;
            this.pasta1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.pantallaInicial1.Visible = false;
        }

        private void boton_carne_Click(object sender, EventArgs e)
        {
            this.checkBotonSelected(this.boton_carne);

            this.carne1.Visible = true;
            this.carne1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.pantallaInicial1.Visible = false;
        }

        private void boton_bebidas_Click(object sender, EventArgs e)
        {
            this.checkBotonSelected(this.boton_bebidas);

            this.cocteles1.Visible = true;
            this.cocteles1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.pantallaInicial1.Visible = false;
        }

        private void boton_postres_Click(object sender, EventArgs e)
        {

            this.checkBotonSelected(this.boton_postres);

            this.postres1.Visible = true;
            this.postres1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.pantallaInicial1.Visible = true;
        }

        public void checkBotonSelected(Button b)
        {
            b.BackColor = Color.LightGray;

            foreach (Button bt in lista_botones)
            {
                if (!bt.Equals(b))
                {
                    bt.BackColor = Color.White;
                }
            }
        }

        public static void aniadirPlatoACarrito(Plato p)
        {
            carrito_compra.Add(p);
            actualizarCarrito();
            Carrito.refrescarCarrito();
        }

        public static void actualizarCarrito()
        {
            sumarCarrito();
            num_productos.Text = "(" + numero + ")";
        }

        public static void sumarProductos(Plato p)
        {
                numero += p.getCantidad();
            
        }

        public static void sumarCarrito()
        {
            numero = 0;

            for (int index = 0; index < carrito_compra.Count; index++)
            {
                numero += carrito_compra[index].getCantidad();
            }
        }

        private void boton_carrito_Click(object sender, EventArgs e)
        {
            this.carrito1.Visible = true;
            this.carrito1.BringToFront();

            this.seleccionar_tipo_plato1.Visible = false;

            this.carrito1.calcularTotal();

            this.pantallaInicial1.Visible = false;
        }

        public void crearPlatosYAgregarlos()
        {
            Plato p_vegetal_1 = new Plato("Plato de vegetales 1", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/veganos/vegano_1.jpg", 5.5, 1, "Vegetal");
            Plato p_vegetal_2 = new Plato("Plato de vegetales 2", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/veganos/vegano_2.jpg", 5.5, 1, "Vegetal");
            Plato p_vegetal_3 = new Plato("Plato de vegetales 3", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/veganos/vegano_3.jpg", 5.5, 1, "Vegetal");
            Plato p_vegetal_4 = new Plato("Plato de vegetales 4", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/veganos/vegano_4.jpg", 5.5, 1, "Vegetal");
            lista_platos.Add(p_vegetal_1);
            lista_platos.Add(p_vegetal_2);
            lista_platos.Add(p_vegetal_3);
            lista_platos.Add(p_vegetal_4);


            Plato p_pescao_1 = new Plato("Plato de pescao 1", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pescao/pescao_1.jpg", 6.6, 1, "Pescado");
            Plato p_pescao_2 = new Plato("Plato de pescao 2", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pescao/pescao_2.jpg", 6.6, 1, "Pescado");
            Plato p_pescao_3 = new Plato("Plato de pescao 3", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pescao/pescao_3.jpg", 6.6, 1, "Pescado");
            Plato p_pescao_4 = new Plato("Plato de pescao 4", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pescao/pescao_4.jpg", 6.6, 1, "Pescado");
            lista_platos.Add(p_pescao_1);
            lista_platos.Add(p_pescao_2);
            lista_platos.Add(p_pescao_3);
            lista_platos.Add(p_pescao_4);


            Plato p_carne_1 = new Plato("Plato de carne 1", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/carne/carne_1.jpg", 7.7, 1, "Carne");
            Plato p_carne_2 = new Plato("Plato de carne 2", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/carne/carne_2.jpg", 7.7, 1, "Carne");
            Plato p_carne_3 = new Plato("Plato de carne 3", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/carne/carne_3.jpg", 7.7, 1, "Carne");
            Plato p_carne_4 = new Plato("Plato de carne 4", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/carne/carne_4.jpg", 7.7, 1, "Carne");
            lista_platos.Add(p_carne_1);
            lista_platos.Add(p_carne_2);
            lista_platos.Add(p_carne_3);
            lista_platos.Add(p_carne_4);


            Plato p_pasta_1 = new Plato("Plato de pasta 1", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pasta/pasta_1.jpg", 8.8, 1, "Pasta");
            Plato p_pasta_2 = new Plato("Plato de pasta 2", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pasta/pasta_2.jpg", 8.8, 1, "Pasta");
            Plato p_pasta_3 = new Plato("Plato de pasta 3", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pasta/pasta_3.jpg", 8.8, 1, "Pasta");
            Plato p_pasta_4 = new Plato("Plato de pasta 4", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/pasta/pasta_4.jpg", 8.8, 1, "Pasta");
            lista_platos.Add(p_pasta_1);
            lista_platos.Add(p_pasta_2);
            lista_platos.Add(p_pasta_3);
            lista_platos.Add(p_pasta_4);


            Plato p_coctel_1 = new Plato("Bebida coctel 1", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/cocteles/cocteles_1.jpg", 9.9, 1, "Coctel");
            Plato p_coctel_2 = new Plato("Bebida coctel 2", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/cocteles/cocteles_2.jpg", 9.9, 1, "Coctel");
            Plato p_coctel_3 = new Plato("Bebida coctel 3", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/cocteles/cocteles_3.jpg", 9.9, 1, "Coctel");
            Plato p_coctel_4 = new Plato("Bebida coctel 4", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/cocteles/cocteles_4.jpg", 9.9, 1, "Coctel");
            lista_platos.Add(p_coctel_1);
            lista_platos.Add(p_coctel_2);
            lista_platos.Add(p_coctel_3);
            lista_platos.Add(p_coctel_4);


            Plato p_postre_1 = new Plato("Postre 1", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/postres/postres_1.jpg", 10.0, 1, "Postre");
            Plato p_postre_2 = new Plato("Postre 2", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/postres/postres_2.jpg", 10.0, 1, "Postre");
            Plato p_postre_3 = new Plato("Postre 3", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/postres/postres_3.jpg", 10.0, 1, "Postre");
            Plato p_postre_4 = new Plato("Postre 4", "C:/Users/lolac/source/repos/GourmetteRestaurante/assets/platos/postres/postres_4.jpg", 10.0, 1, "Postre");
            lista_platos.Add(p_postre_1);
            lista_platos.Add(p_postre_2);
            lista_platos.Add(p_postre_3);
            lista_platos.Add(p_postre_4);

        }

        private void cancelar_pedido_Click(object sender, EventArgs e)
        {

            numero = 0;

            foreach (ListViewItem item in Carrito.platos_lista_carrito.Items)
            {
                item.Remove();
            }

            for (int index = carrito_compra.Count - 1; index >= 0 ; index--)
            {
                carrito_compra.RemoveAt(index);
            }

            num_productos.Text = "(0)";

            Console.WriteLine("Numero de productos en el carrito: " + carrito_compra.Count);
            
            this.pantallaInicial1.Visible = true;
            this.pantallaInicial1.BringToFront();
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
                    }

        public static void eliminarPlatoDelCarritoPorNombre(string nombre)
        {

            for (int index = 0; index < carrito_compra.Count; index++)
            {
                if (carrito_compra[index].getNombre().Equals(nombre))
                {
                    carrito_compra.Remove(carrito_compra[index]);
                }
            }
        }
    }
}
