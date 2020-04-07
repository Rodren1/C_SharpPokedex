namespace PokedexC_Sharp
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Buscador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Buscador)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscador
            // 
            this.Buscador.BackgroundColor = System.Drawing.Color.Silver;
            this.Buscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buscador.Location = new System.Drawing.Point(0, 0);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(820, 589);
            this.Buscador.TabIndex = 0;
            this.Buscador.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Buscador_CellContentDoubleClick);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 589);
            this.Controls.Add(this.Buscador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.Buscador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Buscador;
    }
}