using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_Sharp
{
    public partial class DetallesPokemon : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemon = new DataTable();
        public DetallesPokemon()
        {
            InitializeComponent();
            infoPokemon(VentanaPokedex.idActual);
        }
        public void infoPokemon(int id)
        {
            
            misPokemon = miConexion.getPokemonPorId(id);
            nombre.Text = misPokemon.Rows[0]["nombre"].ToString();
            habilidad.Text = misPokemon.Rows[0]["habilidad"].ToString();
            idPokemon.Text = misPokemon.Rows[0]["id"].ToString();
            altura.Text = misPokemon.Rows[0]["altura"].ToString();
            peso.Text = misPokemon.Rows[0]["peso"].ToString();
            tipo1.Text = misPokemon.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemon.Rows[0]["tipo2"].ToString();
            movimiento1.Text = misPokemon.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemon.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemon.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemon.Rows[0]["movimiento4"].ToString();
            descripcion.Text = misPokemon.Rows[0]["descripcion"].ToString();
            imagenPokemon.Image = convierteBlobImagen((byte[])misPokemon.Rows[0]["imagen"]);
        }

        private Image convierteBlobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
    }
}
