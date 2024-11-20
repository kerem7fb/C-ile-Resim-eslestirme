using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Resim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            secim = listBox1.SelectedItem.ToString();
            if (radioButton1.Checked == true && (secim == "MP4" || secim == "MOV")) 
            {
                MessageBox.Show("Seçim Doğru");
            }
            else if (radioButton1.Checked == false && (secim == "MP4" || secim == "MOV")) 
            {
                MessageBox.Show("Seçim Yanlış");
            }
            else if (radioButton2.Checked == true && (secim == "JPEG" || secim == "PNG")) 
            {
                MessageBox.Show("Seçim Doğru");
            }
            else if (radioButton2.Checked == false && (secim == "JPEG" || secim == "PNG")) 
            {
                MessageBox.Show("Seçim Yanlış");
            }
        }
    }
}
