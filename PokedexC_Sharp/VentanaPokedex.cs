using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PokedexC_Sharp
{
    public partial class VentanaPokedex : Form
    {

        Conexion miConexion = new Conexion();
        DataTable misPokemon = new DataTable();
        public static int idActual = 0;
        public VentanaPokedex()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }


        private Image convierteBlobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void BotonIzq_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) idActual = 1;
            infoPokemon(idActual);
        }

        private void BotonDch_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) idActual = 151;
            infoPokemon(idActual);
        }



        private void Arriba_Click(object sender, EventArgs e)
        {
            idActual += 10;
            if (idActual >= 151) idActual = 151;
            infoPokemon(idActual);
        }

        private void Abajo_Click(object sender, EventArgs e)
        {
            idActual -= 10;
            if (idActual <= 0) idActual = 1;
            infoPokemon(idActual);
        }

        public void infoPokemon(int id)
        {
            misPokemon = miConexion.getPokemonPorId(id);
            nombrePokemon.Text = "Nombre: " + misPokemon.Rows[0]["nombre"].ToString();
            especie.Text = "Especie: " + misPokemon.Rows[0]["especie"].ToString();
            habitat.Text = "Habitat: " + misPokemon.Rows[0]["habitat"].ToString();
            imagenPokemon.Image = convierteBlobImagen((byte[])misPokemon.Rows[0]["imagen"]);
        }

        private void detalles_Click(object sender, EventArgs e)
        {
            DetallesPokemon ventanaDetalles = new DetallesPokemon();
            ventanaDetalles.Show();
        }
    }
}
