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

            Boolean v1, v2, v3, v4, v5;
            v1 = comprobar('a');
            v2 = comprobar('e');
            v3 = comprobar('i');
            v4 = comprobar('o');
            v5 = comprobar('u');
            if (v1 & v2 & v3 & v4 & v5 == true)
            {
                MessageBox.Show("La palabra contiene las 5 vocales", "Exitoooo");
            }else
            {
                MessageBox.Show("La palabra no  contiene las 5 vocales", "Mal :C");
            }

            
            

            
        }
        public Boolean comprobar(char v)
        {
            String linea1 = textBox1.Text.ToLower();
            char[] a = linea1.ToCharArray();
            for (int i = 0; i < linea1.Length; i++ )
            {
                if (a[i]==v)
                {
                    return true;
                }
            }
            return false;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String linea1 = textBox1.Text;
            string linea2 = textBox2.Text;
            char[] a = linea1.ToCharArray();
            char[] b = linea2.ToCharArray();
            textBox1.Text = "";
            textBox2.Text = "";
            for (int i = linea1.Length - 1; i >= 0; i--)
            {
                textBox1.Text += a[i];
            }
            for (int i = linea2.Length - 1; i >= 0; i--)
            {
                textBox2.Text += b[i];
            }
            MessageBox.Show(textBox1.Text +" "+textBox2.Text+" 201408473");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c, d;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);
                d = b * c / a;
                label1.Text = "x= " + d;
            }
            catch
            {
                MessageBox.Show("Verifique que los 3 valores estén ingresados y que sean números enteros", "Te estoy vigilando");
            }
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
