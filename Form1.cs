using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void txtnombre_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            MessageBox.Show(string.Format("hola {0}! como estas ", nombre));
        }

        private void fdmclick_Click(object sender, EventArgs e)
        {
            string click = fdmclick.Text;
            MessageBox.Show(string.Format("mi primera programcion en c# {0}", click));
        }

        private void fdmsumar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtvalor1.Text);
            int valor2 = Convert.ToInt32(txtvalor2.Text);

            int resurtado = valor1 + valor2;

            txtresurtado.Text = resurtado.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
