using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300621334_SHAFIQ_ASS_1
{
    public partial class PrinterGUI : Form
    {
        public PrinterGUI()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = checkBox3.Checked = false;

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox3.Checked = false;
            checkBox2.Checked = true;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox2.Checked = false;
            checkBox3.Checked = true;
        }
    }
}
