using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPanel
{
    public partial class Form1 : Form
    {
        private Color colorSelected = Color.Black;
        private int pixelW = 5; //default medium size
        private int pixelH =5;

        //a form to draw on
        public bool mouseDown { get; set; } = false; //start painting when mouse clicked

        public Form1()
        {
            InitializeComponent();
            //Color c; //this didn't work outside of constructor!!!
            //c = radBlack.Checked ? Color.Black : (radRed.Checked ? Color.Red : (radBlack.Checked ?Color.Blue:(radGreen.Checked?Color.Green:Color.Transparent)));//this didn't work outside of constructor!!!
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            colorSelected = Color.Red;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            colorSelected = Color.Blue;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            colorSelected = Color.Green;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            colorSelected = Color.Black;
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            pixelW = pixelH = 2;
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            pixelW = pixelH = 5;
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            pixelW = pixelH = 8;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                using (Graphics draw = CreateGraphics())
                {
                    draw.FillEllipse(new SolidBrush(colorSelected), e.X, e.Y, pixelH, pixelW);
                }
            }
        }
    }
}
