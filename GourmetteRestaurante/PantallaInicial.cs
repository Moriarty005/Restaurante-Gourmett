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
    public partial class PantallaInicial : UserControl
    {
        public PantallaInicial()
        {
            InitializeComponent();
        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {

        }
        

        private void ocultar(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }
    }
}
