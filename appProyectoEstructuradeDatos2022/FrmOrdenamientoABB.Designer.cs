
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmOrdenamientoABB
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInvertidos = new System.Windows.Forms.Button();
            this.txtInorden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSinOrdenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(441, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 395);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnInvertidos
            // 
            this.btnInvertidos.Location = new System.Drawing.Point(82, 74);
            this.btnInvertidos.Name = "btnInvertidos";
            this.btnInvertidos.Size = new System.Drawing.Size(64, 45);
            this.btnInvertidos.TabIndex = 16;
            this.btnInvertidos.Text = "invertidos";
            this.btnInvertidos.UseVisualStyleBackColor = true;
            this.btnInvertidos.Click += new System.EventHandler(this.btnInvertidos_Click_1);
            // 
            // txtInorden
            // 
            this.txtInorden.Location = new System.Drawing.Point(189, 99);
            this.txtInorden.Name = "txtInorden";
            this.txtInorden.Size = new System.Drawing.Size(234, 20);
            this.txtInorden.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ordenados";
            // 
            // txtSinOrdenar
            // 
            this.txtSinOrdenar.Location = new System.Drawing.Point(189, 42);
            this.txtSinOrdenar.Name = "txtSinOrdenar";
            this.txtSinOrdenar.Size = new System.Drawing.Size(234, 20);
            this.txtSinOrdenar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sin ordenar";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(8, 74);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(64, 45);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese la cantidad de digitos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(8, 42);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(8, 415);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 18;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmOrdenamientoABB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInvertidos);
            this.Controls.Add(this.txtInorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSinOrdenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Name = "FrmOrdenamientoABB";
            this.Text = "FrmOrdenamientoABB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInvertidos;
        private System.Windows.Forms.TextBox txtInorden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button BtnCerrar;
    }
}