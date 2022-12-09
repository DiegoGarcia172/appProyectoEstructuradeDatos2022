
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOrdenamientos = new System.Windows.Forms.Button();
            this.BtnEstructuras = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOrdenamientos
            // 
            this.BtnOrdenamientos.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOrdenamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdenamientos.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrdenamientos.Location = new System.Drawing.Point(381, 12);
            this.BtnOrdenamientos.Name = "BtnOrdenamientos";
            this.BtnOrdenamientos.Size = new System.Drawing.Size(153, 101);
            this.BtnOrdenamientos.TabIndex = 3;
            this.BtnOrdenamientos.Text = "Metodos de Ordenamiento";
            this.BtnOrdenamientos.UseVisualStyleBackColor = false;
            this.BtnOrdenamientos.Click += new System.EventHandler(this.BtnOrdenamientos_Click);
            // 
            // BtnEstructuras
            // 
            this.BtnEstructuras.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnEstructuras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstructuras.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstructuras.Location = new System.Drawing.Point(27, 12);
            this.BtnEstructuras.Name = "BtnEstructuras";
            this.BtnEstructuras.Size = new System.Drawing.Size(149, 101);
            this.BtnEstructuras.TabIndex = 2;
            this.BtnEstructuras.Text = "Estructuras";
            this.BtnEstructuras.UseVisualStyleBackColor = false;
            this.BtnEstructuras.Click += new System.EventHandler(this.BtnEstructuras_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(203, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(153, 101);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 135);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnOrdenamientos);
            this.Controls.Add(this.BtnEstructuras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOrdenamientos;
        private System.Windows.Forms.Button BtnEstructuras;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

