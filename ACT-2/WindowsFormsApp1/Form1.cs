using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contacto[] a = new Contacto[2];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (i < a.Length)
            {
                Contacto x = new Contacto();
                x.Nombre = textBox1.Text;
                x.FechaN = dateTimePicker1.Value;
                x.Telefono = textBox2.Text;
                x.Correo = textBox3.Text;

                a[i] = x;
                listView1.Items.Add(x.ToString());
                i++;
            }


        }


    }
}