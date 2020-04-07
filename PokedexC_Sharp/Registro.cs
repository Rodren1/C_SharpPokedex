using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_Sharp
{
    public partial class Registro : Form
    {
        public int idSeleccionado;

        Conexion miConexion = new Conexion();
        DataTable misPokemon = new DataTable();
        public Registro()
        {
            InitializeComponent();
            Buscador.DataSource = miConexion.getAllPokemon();
            Buscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            Buscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void Buscador_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(Buscador.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.Close();
        }
    }
}
