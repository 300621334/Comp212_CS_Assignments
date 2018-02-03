using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblC.Text = lblF.Text = "";
      }

        private void convertToF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtC.Text)) //if nothing entered in txtbox
            {
                lblF.Text = "";
                return;
            }

            double fahrenheit = ((Convert.ToDouble(txtC.Text) * 1.8) + 32);
            lblF.Text = string.Format("{0:F2} \u00B0F", fahrenheit); // "\u00B0" inserts degree symbol;
        }

        private void convertToC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtF.Text))
            {
                double celcius = ((Convert.ToDouble(txtF.Text) - 32) / 1.8);
                lblC.Text = string.Format("{0:F2} \u00B0C", celcius); // {0:.##} makes 0.00 just disappear

                // lblC.Text = ((Convert.ToDouble(txtF.Text) - 32) / 1.8) + "\u00B0C";
            }
            else
                lblC.Text = "";


        }
    }
}
