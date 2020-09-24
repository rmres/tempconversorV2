using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvTempV2
{
    public partial class F_TemperatureConversor : Form
    {
        public F_TemperatureConversor()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        // evento pra aceitar apenas números, vírgula e menos(-).
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double c, f, k;

            try
            {
                if (cbx_temps.SelectedIndex == 0)
                {
                    c = Convert.ToDouble(textBox1.Text);

                    f = c * 1.8 + 32;
                    k = c + 273.15;

                    lb_result1.Text = $"Fahrenheit: {Math.Round(f, 2)}";
                    lb_result2.Text = $"Kelvin: {Math.Round(k, 2)}";
                }
                else if (cbx_temps.SelectedIndex == 1)
                {
                    f = Convert.ToDouble(textBox1.Text);

                    c = (f - 32) / 1.8;
                    k = c + 273.15;

                    lb_result1.Text = $"Celsius: {Math.Round(c, 2)}";
                    lb_result2.Text = $"Kelvin: {Math.Round(k, 2)}";
                }
                else if (cbx_temps.SelectedIndex == 2)
                {
                    k = Convert.ToDouble(textBox1.Text);

                    c = k - 273.15;
                    f = c * 1.8 + 32;

                    lb_result1.Text = $"Celsius: {Math.Round(c, 2)}";
                    lb_result2.Text = $"Fahrenheit: {Math.Round(f, 2)}";
                } 
            } 
            catch
            {
                //
            }

            if (textBox1.Text.Length == 0)
            {
                lb_result1.Text = "Aguardando valor.";
                lb_result2.Text = "";
            }
        }
        private void cbx_temps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_temps.SelectedIndex >= 0)
            {
                textBox1.Enabled = true;
            }

            textBox1.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/rmres");

            linkLabel1.LinkVisited = true;
        }
    }
}
