﻿
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmGrafos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbGrafo = new System.Windows.Forms.GroupBox();
            this.cbTipoGrafo = new System.Windows.Forms.ComboBox();
            this.btNuevoGrafo = new System.Windows.Forms.Button();
            this.gbArcos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEliminarArco = new System.Windows.Forms.Button();
            this.lbArcos = new System.Windows.Forms.ListBox();
            this.txDestino = new System.Windows.Forms.TextBox();
            this.txOrigen = new System.Windows.Forms.TextBox();
            this.btAgregarArco = new System.Windows.Forms.Button();
            this.gbVertices = new System.Windows.Forms.GroupBox();
            this.btEliminarVertice = new System.Windows.Forms.Button();
            this.lbVertices = new System.Windows.Forms.ListBox();
            this.txAgregarVertice = new System.Windows.Forms.TextBox();
            this.btAgregarVertice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGrafo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbIndicacion = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGrafo.SuspendLayout();
            this.gbArcos.SuspendLayout();
            this.gbVertices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 28;
            // 
            // gbGrafo
            // 
            this.gbGrafo.BackColor = System.Drawing.Color.Transparent;
            this.gbGrafo.Controls.Add(this.cbTipoGrafo);
            this.gbGrafo.Controls.Add(this.btNuevoGrafo);
            this.gbGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGrafo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGrafo.Location = new System.Drawing.Point(6, 88);
            this.gbGrafo.Name = "gbGrafo";
            this.gbGrafo.Size = new System.Drawing.Size(192, 60);
            this.gbGrafo.TabIndex = 27;
            this.gbGrafo.TabStop = false;
            this.gbGrafo.Text = "Tipo de Grafo";
            // 
            // cbTipoGrafo
            // 
            this.cbTipoGrafo.BackColor = System.Drawing.Color.White;
            this.cbTipoGrafo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoGrafo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoGrafo.FormattingEnabled = true;
            this.cbTipoGrafo.Items.AddRange(new object[] {
            "Dirigido",
            "No Dirigido"});
            this.cbTipoGrafo.Location = new System.Drawing.Point(6, 22);
            this.cbTipoGrafo.Name = "cbTipoGrafo";
            this.cbTipoGrafo.Size = new System.Drawing.Size(100, 25);
            this.cbTipoGrafo.TabIndex = 2;
            // 
            // btNuevoGrafo
            // 
            this.btNuevoGrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btNuevoGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevoGrafo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoGrafo.ForeColor = System.Drawing.Color.White;
            this.btNuevoGrafo.Location = new System.Drawing.Point(112, 22);
            this.btNuevoGrafo.Name = "btNuevoGrafo";
            this.btNuevoGrafo.Size = new System.Drawing.Size(74, 27);
            this.btNuevoGrafo.TabIndex = 1;
            this.btNuevoGrafo.Text = "Nuevo";
            this.btNuevoGrafo.UseVisualStyleBackColor = false;
            // 
            // gbArcos
            // 
            this.gbArcos.Controls.Add(this.label4);
            this.gbArcos.Controls.Add(this.label3);
            this.gbArcos.Controls.Add(this.label2);
            this.gbArcos.Controls.Add(this.btEliminarArco);
            this.gbArcos.Controls.Add(this.lbArcos);
            this.gbArcos.Controls.Add(this.txDestino);
            this.gbArcos.Controls.Add(this.txOrigen);
            this.gbArcos.Controls.Add(this.btAgregarArco);
            this.gbArcos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArcos.Location = new System.Drawing.Point(12, 300);
            this.gbArcos.Name = "gbArcos";
            this.gbArcos.Size = new System.Drawing.Size(192, 187);
            this.gbArcos.TabIndex = 26;
            this.gbArcos.TabStop = false;
            this.gbArcos.Text = "Arcos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado de Arcos:";
            // 
            // btEliminarArco
            // 
            this.btEliminarArco.BackColor = System.Drawing.Color.Teal;
            this.btEliminarArco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarArco.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarArco.ForeColor = System.Drawing.Color.White;
            this.btEliminarArco.Location = new System.Drawing.Point(112, 126);
            this.btEliminarArco.Name = "btEliminarArco";
            this.btEliminarArco.Size = new System.Drawing.Size(74, 27);
            this.btEliminarArco.TabIndex = 3;
            this.btEliminarArco.Text = "Eliminar";
            this.btEliminarArco.UseVisualStyleBackColor = false;
            // 
            // lbArcos
            // 
            this.lbArcos.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArcos.FormattingEnabled = true;
            this.lbArcos.ItemHeight = 17;
            this.lbArcos.Location = new System.Drawing.Point(6, 109);
            this.lbArcos.Name = "lbArcos";
            this.lbArcos.Size = new System.Drawing.Size(100, 72);
            this.lbArcos.TabIndex = 2;
            // 
            // txDestino
            // 
            this.txDestino.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDestino.Location = new System.Drawing.Point(60, 44);
            this.txDestino.Name = "txDestino";
            this.txDestino.Size = new System.Drawing.Size(46, 25);
            this.txDestino.TabIndex = 1;
            this.txDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txOrigen
            // 
            this.txOrigen.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txOrigen.Location = new System.Drawing.Point(60, 18);
            this.txOrigen.Name = "txOrigen";
            this.txOrigen.Size = new System.Drawing.Size(46, 25);
            this.txOrigen.TabIndex = 1;
            this.txOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAgregarArco
            // 
            this.btAgregarArco.BackColor = System.Drawing.Color.SlateGray;
            this.btAgregarArco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarArco.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarArco.ForeColor = System.Drawing.Color.White;
            this.btAgregarArco.Location = new System.Drawing.Point(112, 47);
            this.btAgregarArco.Name = "btAgregarArco";
            this.btAgregarArco.Size = new System.Drawing.Size(74, 27);
            this.btAgregarArco.TabIndex = 0;
            this.btAgregarArco.Text = "Agregar";
            this.btAgregarArco.UseVisualStyleBackColor = false;
            // 
            // gbVertices
            // 
            this.gbVertices.Controls.Add(this.btEliminarVertice);
            this.gbVertices.Controls.Add(this.lbVertices);
            this.gbVertices.Controls.Add(this.txAgregarVertice);
            this.gbVertices.Controls.Add(this.btAgregarVertice);
            this.gbVertices.Controls.Add(this.label6);
            this.gbVertices.Controls.Add(this.label1);
            this.gbVertices.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVertices.Location = new System.Drawing.Point(9, 154);
            this.gbVertices.Name = "gbVertices";
            this.gbVertices.Size = new System.Drawing.Size(192, 140);
            this.gbVertices.TabIndex = 25;
            this.gbVertices.TabStop = false;
            this.gbVertices.Text = "Vértices";
            // 
            // btEliminarVertice
            // 
            this.btEliminarVertice.BackColor = System.Drawing.Color.Teal;
            this.btEliminarVertice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarVertice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarVertice.ForeColor = System.Drawing.Color.White;
            this.btEliminarVertice.Location = new System.Drawing.Point(112, 79);
            this.btEliminarVertice.Name = "btEliminarVertice";
            this.btEliminarVertice.Size = new System.Drawing.Size(74, 30);
            this.btEliminarVertice.TabIndex = 3;
            this.btEliminarVertice.Text = "Eliminar";
            this.btEliminarVertice.UseVisualStyleBackColor = false;
            // 
            // lbVertices
            // 
            this.lbVertices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbVertices.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVertices.FormattingEnabled = true;
            this.lbVertices.ItemHeight = 17;
            this.lbVertices.Location = new System.Drawing.Point(6, 79);
            this.lbVertices.Name = "lbVertices";
            this.lbVertices.Size = new System.Drawing.Size(100, 53);
            this.lbVertices.TabIndex = 2;
            // 
            // txAgregarVertice
            // 
            this.txAgregarVertice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAgregarVertice.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAgregarVertice.Location = new System.Drawing.Point(73, 25);
            this.txAgregarVertice.Name = "txAgregarVertice";
            this.txAgregarVertice.Size = new System.Drawing.Size(33, 25);
            this.txAgregarVertice.TabIndex = 1;
            this.txAgregarVertice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAgregarVertice
            // 
            this.btAgregarVertice.BackColor = System.Drawing.Color.SlateGray;
            this.btAgregarVertice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarVertice.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarVertice.ForeColor = System.Drawing.Color.White;
            this.btAgregarVertice.Location = new System.Drawing.Point(112, 25);
            this.btAgregarVertice.Name = "btAgregarVertice";
            this.btAgregarVertice.Size = new System.Drawing.Size(74, 29);
            this.btAgregarVertice.TabIndex = 0;
            this.btAgregarVertice.Text = "Agregar";
            this.btAgregarVertice.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Vértices:";
            // 
            // pbGrafo
            // 
            this.pbGrafo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGrafo.BackColor = System.Drawing.Color.White;
            this.pbGrafo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrafo.Location = new System.Drawing.Point(260, 88);
            this.pbGrafo.Name = "pbGrafo";
            this.pbGrafo.Size = new System.Drawing.Size(509, 381);
            this.pbGrafo.TabIndex = 24;
            this.pbGrafo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Ebrima", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(-13, -30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 128);
            this.label7.TabIndex = 29;
            this.label7.Text = "Grafos";
            // 
            // lbIndicacion
            // 
            this.lbIndicacion.AutoSize = true;
            this.lbIndicacion.Location = new System.Drawing.Point(520, 58);
            this.lbIndicacion.Name = "lbIndicacion";
            this.lbIndicacion.Size = new System.Drawing.Size(0, 13);
            this.lbIndicacion.TabIndex = 31;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(725, 471);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 32;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lbIndicacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbGrafo);
            this.Controls.Add(this.gbArcos);
            this.Controls.Add(this.gbVertices);
            this.Controls.Add(this.pbGrafo);
            this.Controls.Add(this.label7);
            this.Name = "FrmGrafos";
            this.Text = "FrmGrafos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGrafo.ResumeLayout(false);
            this.gbArcos.ResumeLayout(false);
            this.gbArcos.PerformLayout();
            this.gbVertices.ResumeLayout(false);
            this.gbVertices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbGrafo;
        private System.Windows.Forms.ComboBox cbTipoGrafo;
        private System.Windows.Forms.Button btNuevoGrafo;
        private System.Windows.Forms.GroupBox gbArcos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEliminarArco;
        private System.Windows.Forms.ListBox lbArcos;
        private System.Windows.Forms.TextBox txDestino;
        private System.Windows.Forms.TextBox txOrigen;
        private System.Windows.Forms.Button btAgregarArco;
        private System.Windows.Forms.GroupBox gbVertices;
        private System.Windows.Forms.Button btEliminarVertice;
        private System.Windows.Forms.ListBox lbVertices;
        private System.Windows.Forms.TextBox txAgregarVertice;
        private System.Windows.Forms.Button btAgregarVertice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGrafo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIndicacion;
        private System.Windows.Forms.Button BtnCerrar;
    }
}