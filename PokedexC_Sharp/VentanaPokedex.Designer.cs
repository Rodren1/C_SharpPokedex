using System;

namespace PokedexC_Sharp
{
    partial class VentanaPokedex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPokedex));
            this.imagenPokemon = new System.Windows.Forms.PictureBox();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.BotonDch = new System.Windows.Forms.Button();
            this.BotonIzq = new System.Windows.Forms.Button();
            this.Arriba = new System.Windows.Forms.Button();
            this.Abajo = new System.Windows.Forms.Button();
            this.especie = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.detalles = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPokemon
            // 
            this.imagenPokemon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imagenPokemon.Location = new System.Drawing.Point(78, 2);
            this.imagenPokemon.Name = "imagenPokemon";
            this.imagenPokemon.Size = new System.Drawing.Size(166, 165);
            this.imagenPokemon.TabIndex = 1;
            this.imagenPokemon.TabStop = false;
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombrePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nombrePokemon.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.Color.Lime;
            this.nombrePokemon.Location = new System.Drawing.Point(12, 170);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(307, 40);
            this.nombrePokemon.TabIndex = 4;
            // 
            // BotonDch
            // 
            this.BotonDch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonDch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDch.Location = new System.Drawing.Point(165, 313);
            this.BotonDch.Name = "BotonDch";
            this.BotonDch.Size = new System.Drawing.Size(79, 39);
            this.BotonDch.TabIndex = 6;
            this.BotonDch.Text = ">";
            this.BotonDch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonDch.UseVisualStyleBackColor = true;
            this.BotonDch.Click += new System.EventHandler(this.BotonDch_Click);
            // 
            // BotonIzq
            // 
            this.BotonIzq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonIzq.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIzq.Location = new System.Drawing.Point(81, 313);
            this.BotonIzq.Name = "BotonIzq";
            this.BotonIzq.Size = new System.Drawing.Size(78, 39);
            this.BotonIzq.TabIndex = 5;
            this.BotonIzq.Text = "<";
            this.BotonIzq.UseVisualStyleBackColor = true;
            this.BotonIzq.Click += new System.EventHandler(this.BotonIzq_Click);
            // 
            // Arriba
            // 
            this.Arriba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Arriba.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arriba.Location = new System.Drawing.Point(251, 313);
            this.Arriba.Name = "Arriba";
            this.Arriba.Size = new System.Drawing.Size(68, 39);
            this.Arriba.TabIndex = 7;
            this.Arriba.Text = ">>";
            this.Arriba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Arriba.UseVisualStyleBackColor = true;
            this.Arriba.Click += new System.EventHandler(this.Arriba_Click);
            // 
            // Abajo
            // 
            this.Abajo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Abajo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abajo.Location = new System.Drawing.Point(12, 313);
            this.Abajo.Name = "Abajo";
            this.Abajo.Size = new System.Drawing.Size(63, 39);
            this.Abajo.TabIndex = 8;
            this.Abajo.Text = "<<";
            this.Abajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Abajo.UseVisualStyleBackColor = true;
            this.Abajo.Click += new System.EventHandler(this.Abajo_Click);
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.especie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.especie.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.ForeColor = System.Drawing.Color.Lime;
            this.especie.Location = new System.Drawing.Point(12, 210);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(307, 40);
            this.especie.TabIndex = 9;
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.habitat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.habitat.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitat.ForeColor = System.Drawing.Color.Lime;
            this.habitat.Location = new System.Drawing.Point(12, 250);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(307, 40);
            this.habitat.TabIndex = 10;
            // 
            // detalles
            // 
            this.detalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalles.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalles.Location = new System.Drawing.Point(12, 418);
            this.detalles.Name = "detalles";
            this.detalles.Size = new System.Drawing.Size(140, 37);
            this.detalles.TabIndex = 12;
            this.detalles.Text = "Mas detalles...";
            this.detalles.UseVisualStyleBackColor = true;
            this.detalles.Click += new System.EventHandler(this.detalles_Click);
            // 
            // registro
            // 
            this.registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(179, 418);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(140, 37);
            this.registro.TabIndex = 13;
            this.registro.Text = "Registro";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // VentanaPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(331, 467);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.detalles);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.Abajo);
            this.Controls.Add(this.Arriba);
            this.Controls.Add(this.BotonDch);
            this.Controls.Add(this.BotonIzq);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.imagenPokemon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPokedex";
            this.Text = "VentanaPokedex";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.PictureBox imagenPokemon;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button BotonDch;
        private System.Windows.Forms.Button BotonIzq;
        private System.Windows.Forms.Button Arriba;
        private System.Windows.Forms.Button Abajo;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Button detalles;
        private System.Windows.Forms.Button registro;
    }
}