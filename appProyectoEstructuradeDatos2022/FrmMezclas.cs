using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace appProyectoEstructuradeDatos2022
{
    public partial class FrmMezclas : Form
    {
        public FrmMezclas()
        {
            InitializeComponent();
        }
        OperacionMezcla mezcla = new OperacionMezcla();
        int[] vector;
        public int[] Cargar(int n)
        {
            Random r = new Random();
            int valor;
            //Dar n elementos
            vector = new int[n];
            //Guardar datos en el arreglo
            for (int i = 0; i < n; i++)
            {
                valor = 0;
                valor = r.Next(1, 100);
                vector[i] = valor;
            }
            return vector;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecAsc_Click_1(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MezclaNatural(vector);
            mezcla.Mostrar(lvwOrdenado, a);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }
        private void btnRAscendenteDirecta_Click_1(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MergeSortDes(vector);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
            mezcla.Mostrar(lvwOrdenado, a);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }

        private void btnRDescendenteDirecta_Click_1(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MergeSortDes(vector);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
            mezcla.Mostrar(lvwOrdenado, a);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            int elementos = int.Parse(txtElementos.Text);
            Cargar(elementos);
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            lvwMostar.Clear();
            mezcla.Mostrar(lvwMostar, vector);
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            lvwOrdenado.Clear();
            lblEstadisticaNombre.Text = "--";
            lblStadistica.Text = "--";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MergeSortDes(vector);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
            mezcla.Mostrar(lvwOrdenado, a);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }
    }
}
