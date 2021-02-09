using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_systemAss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // write admin on text box
        private void button1_Click(object sender, EventArgs e)
        {
            if (adminname.Text.Equals("admin")) {
                rentalSection obj = new rentalSection();
                obj.Show();
            }
        }
    }
}
