using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Programa_Simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hyp = 0;
            try{
                hyp = double.Parse(textBox1.Text) * double.Parse(textBox1.Text) + int.Parse(textBox2.Text) * int.Parse(textBox2.Text);
                hyp = Math.Sqrt(hyp);
                this.label1.Text = "La hipotenusa es: "+hyp ;
            }catch
            {
                MessageBox.Show("Ingrese números enteros  ","Cuidadito!!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string direccion = Path.Combine(Application.StartupPath, "instrucciones.txt");
                System.Diagnostics.Process.Start(direccion);
            }
            catch
            {
                MessageBox.Show("No existe el archivo ", "Ups",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
