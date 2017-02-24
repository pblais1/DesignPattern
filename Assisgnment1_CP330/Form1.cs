using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assisgnment1_CP330
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ship s1 = new Ship();
        double weight;
        string shipArmour;

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            weight = 0;
            shipArmour = " ";

            if (ckNano.Checked == true)
            {
                withNano wN = new withNano(s1);

                weight += wN.weight();
                shipArmour += wN.ShipDescription() + ", ";
            }
            if (ckSteel.Checked == true)
            {
                withSteel wS = new withSteel(s1);
                weight += wS.weight();
                shipArmour += wS.ShipDescription() + ", ";
            }
            if (ckHoneycomb.Checked == true)
            {
                withHoneycomb wH = new withHoneycomb(s1);
                weight += wH.weight();
                shipArmour += wH.ShipDescription() + ", ";

            }
           
            lblWeight.Visible = true;
            lblWeight.Text = "The weight of the ship is " + weight;

            lblDescription.Visible = true;
            lblDescription.Text = "Ship description: " + shipArmour;
        }
    }
}
