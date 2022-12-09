using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyectoEstructuradeDatos2022
{
    public partial class FrmListasdoblesenlazadas : Form
    {
        MiListaDobleE lista = new MiListaDobleE();
        public FrmListasdoblesenlazadas()
        {
            InitializeComponent();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            NododobleE n = new NododobleE();
            n.Dato = txtDato.Text;
            lista.Agregar(n);
            MessageBox.Show(lista.ToString());
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
            {
                MessageBox.Show("Encontrado");
                return;
            }
            MessageBox.Show("No encontrado");
        }
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (txtDato.TextLength == 0)
            {
                MessageBox.Show("Antes de borrar, inserta un numero");
            }
            else
            {
                lista.Borrar(txtDato.Text);
                MessageBox.Show(lista.ToString());
            }
        }
    }
}
