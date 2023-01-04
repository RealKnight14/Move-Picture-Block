using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture_Block
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            runLoop();


        }


        public void runLoop()
        {

            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.BackColor = Color.Black;
                    x.ForeColor = Color.Black;
                }

                if (x is Label)
                {
                    x.ForeColor = Color.Purple;
                }
                if (x is PictureBox && (string)x.Tag == "group1")
                {
                    x.BackColor = Color.Plum;

                }
               if(x is PictureBox && (string)x.Tag == "group2")
                {
                    x.BackColor = Color.Maroon;
                }
            }

        }




    }

}
