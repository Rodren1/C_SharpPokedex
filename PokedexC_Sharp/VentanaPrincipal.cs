using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_Sharp
{
    public partial class VentanaPrincipal : Form
    { 
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculto esta ventana
            VentanaPokedex ventana = new VentanaPokedex();
            ventana.Show();
        }
    }
}
