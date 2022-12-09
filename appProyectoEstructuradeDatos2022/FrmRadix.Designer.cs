
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmRadix
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
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.LtbArregloOrdenadoMN = new System.Windows.Forms.ListBox();
            this.LtbArregloOrdenado = new System.Windows.Forms.ListBox();
            this.LtbArregloAleatorio = new System.Windows.Forms.ListBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(293, 9);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(100, 20);
            this.TxtTiempo.TabIndex = 21;
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(242, 12);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(45, 13);
            this.LblTiempo.TabIndex = 20;
            this.LblTiempo.Text = "Tiempo:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(278, 42);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(197, 43);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 18;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click_1);
            // 
            // LtbArregloOrdenadoMN
            // 
            this.LtbArregloOrdenadoMN.FormattingEnabled = true;
            this.LtbArregloOrdenadoMN.Location = new System.Drawing.Point(258, 71);
            this.LtbArregloOrdenadoMN.Name = "LtbArregloOrdenadoMN";
            this.LtbArregloOrdenadoMN.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloOrdenadoMN.TabIndex = 17;
            // 
            // LtbArregloOrdenado
            // 
            this.LtbArregloOrdenado.FormattingEnabled = true;
            this.LtbArregloOrdenado.Location = new System.Drawing.Point(138, 71);
            this.LtbArregloOrdenado.Name = "LtbArregloOrdenado";
            this.LtbArregloOrdenado.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloOrdenado.TabIndex = 16;
            // 
            // LtbArregloAleatorio
            // 
            this.LtbArregloAleatorio.FormattingEnabled = true;
            this.LtbArregloAleatorio.Location = new System.Drawing.Point(10, 71);
            this.LtbArregloAleatorio.Name = "LtbArregloAleatorio";
            this.LtbArregloAleatorio.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloAleatorio.TabIndex = 15;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(116, 45);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 14;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click_1);
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Location = new System.Drawing.Point(10, 45);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(100, 20);
            this.TxtTamaño.TabIndex = 13;
            // 
            // FrmRadix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 215);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.LtbArregloOrdenadoMN);
            this.Controls.Add(this.LtbArregloOrdenado);
            this.Controls.Add(this.LtbArregloAleatorio);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtTamaño);
            this.Name = "FrmRadix";
            this.Text = "FrmRadix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.ListBox LtbArregloOrdenadoMN;
        private System.Windows.Forms.ListBox LtbArregloOrdenado;
        private System.Windows.Forms.ListBox LtbArregloAleatorio;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox TxtTamaño;
    }
}