using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAprobacion
{
    public partial class Jefe1 : Form
    {
        
        public Jefe1()
        {
            InitializeComponent();
        }

        private void Jefe1_Load(object sender, EventArgs e)
        {
            txt2.Text = aprobacion.sendtext;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("El Monto Ha sido aprovado, enviando a siguiente nivel de revision");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form Negado = new MsjdenegadoJefe1();
            Negado.Show();
            this.Hide();
        }
    }
}
