using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ingressos.controller;
namespace ingressos.view
{
    public partial class TelaIngressos : Form
    {
        public TelaIngressos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(textBox1.Text);
            int v = Convert.ToInt32(textBox2.Text);

            int resul = q * v;

            textBox3.Text = Convert.ToString(resul);
        }
    }
}
