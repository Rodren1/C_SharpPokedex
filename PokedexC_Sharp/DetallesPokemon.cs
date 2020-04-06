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
            habilidad.Text ="Habilidad: " + misPokemon.Rows[0]["habilidad"].ToString();
            idPokemon.Text = "ID:  " + misPokemon.Rows[0]["id"].ToString();
            altura.Text = misPokemon.Rows[0]["altura"].ToString() + "m";
            peso.Text = misPokemon.Rows[0]["peso"].ToString() + "kg";
            tipo1.Text ="Tipo 1: " + misPokemon.Rows[0]["tipo1"].ToString();
            tipo2.Text ="Tipo 2: " + misPokemon.Rows[0]["tipo2"].ToString();
            movimiento1.Text ="1º " + misPokemon.Rows[0]["movimiento1"].ToString();
            movimiento2.Text ="2º " + misPokemon.Rows[0]["movimiento2"].ToString();
            movimiento3.Text ="3º " + misPokemon.Rows[0]["movimiento3"].ToString();
            movimiento4.Text ="4º " + misPokemon.Rows[0]["movimiento4"].ToString();
            descripcion.Text ="Descripción: " + misPokemon.Rows[0]["descripcion"].ToString();
            imagenPokemon.Image = convierteBlobImagen((byte[])misPokemon.Rows[0]["imagen"]);
        }

        private Image convierteBlobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
    }
}
