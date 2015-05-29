using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace DatabaseConnectie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Code39BarcodeDraw barcode39 = BarcodeDrawFactory.Code39WithoutChecksum;

            pictureBox1.Image = barcode39.Draw(textBox1.Text, pictureBox1.Size.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newDataBaseConnection connection = new newDataBaseConnection();


            label1.Text = connection.Procedure_ASSERT_EQUALS(textBox2.Text, textBox3.Text);
        }

    }
}

