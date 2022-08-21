using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblmateria1_Click(object sender, EventArgs e)
        {
            lblmateria1.Text = "Programacion 1";
            fecha1.Text = "viernes -- 10:00am - 12:00pm";

        }
    }
}
