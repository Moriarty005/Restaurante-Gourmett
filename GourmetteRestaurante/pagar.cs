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
    public partial class pagar : UserControl
    {
        public pagar()
        {
            InitializeComponent();

            this.label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();

            this.label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "¡Gracias por confiar en nosotros!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "¡Gracias por confiar en nosotros!";
        }
    }
}
