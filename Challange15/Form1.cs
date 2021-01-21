using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange15
{
    public partial class Form1 : Form
    {
        Double dig = 0;
        String isi = "";
        bool tekan_press = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((tboxhasil.Text=="0")||(tekan_press))
            {
                tboxhasil.Clear();
            }
            Button button = (Button)sender;
            tboxhasil.Text = tboxhasil.Text + button.Text;
            tekan_press = false;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            tboxhasil.Text = "0";

        }

        private void tekan(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isi = button.Text;
            dig = Double.Parse(tboxhasil.Text);
            tekan_press = true;
        }

        private void tek_press(object sender, EventArgs e)
        {
            switch(isi)
            {
                case "+":
                    tboxhasil.Text = (dig + Double.Parse(tboxhasil.Text)).ToString();
                    break;
                case "-":
                    tboxhasil.Text = (dig - Double.Parse(tboxhasil.Text)).ToString();
                    break;
                case "/":
                    tboxhasil.Text = (dig / Double.Parse(tboxhasil.Text)).ToString();
                    break;
                case "*":
                    tboxhasil.Text = (dig * Double.Parse(tboxhasil.Text)).ToString();
                    break;
                default:
                    break;
            }
            tekan_press = false;
        }

        private void c_pres(object sender, EventArgs e)
        {
            tboxhasil.Clear();
            dig = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (tboxhasil.Text.Length > 0)
            {
                tboxhasil.Text = tboxhasil.Text.Remove(tboxhasil.Text.Length - 1, 1);
            }
            if (tboxhasil.Text == "")
            {
                tboxhasil.Text = "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!tboxhasil.Text.Contains("-"))
            {
                tboxhasil.Text = tboxhasil.Text.Remove(0, 1);
            }
            else
            {
                tboxhasil.Text = "-" + tboxhasil.Text;
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tboxhasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
