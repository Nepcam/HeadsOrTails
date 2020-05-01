/*
Create an application with a Show Heads button and a Show Tails button.
When the user clicks the Show Heads button, an image of a coin should appear.
When the user clicks the Show Tails button, an image of the Tails side of a coin should appear.
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{
    public partial class FormCoinToss : Form
    {
        public FormCoinToss()
        {
            InitializeComponent();
        }

        private void buttonHeads_Click(object sender, EventArgs e)
        {
            pictureBoxHeads.Visible = true;
            pictureBoxTails.Visible = false;
        }

        private void buttonTails_Click(object sender, EventArgs e)
        {
            pictureBoxTails.Visible = true;
            pictureBoxHeads.Visible = false;
        }
    }
}
