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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            //admin

            if (login.area == "A0001")
            {
                btnalmacen.Enabled = true;
                btnventas.Enabled = true;
                btncompras.Enabled = true;
                btnproducto.Enabled = true;

                lblcargo.Text = "Administrador";
            }

            //ventas

            else if (login.area == "A0002")
            {
                btnalmacen.Enabled = true;
                btnventas.Enabled = false;
                btncompras.Enabled = false;
                btnproducto.Enabled = false;
                lblcargo.Text = "Software";
                
            }

            //compras
            else if (login.area == "A0003")
            {
                btnalmacen.Enabled = false;
                btnventas.Enabled = true;
                btncompras.Enabled = false;
                btnproducto.Enabled = false;
                    

                lblcargo.Text = "multimedia";

            }

            //producto

            else if (login.area == "A0004")
            {
                btnalmacen.Enabled = false;
                btnventas.Enabled = false;
                btncompras.Enabled = false;
                btnproducto.Enabled = true;
                lblcargo.Text = "Redes";

            }

            lblnombre.Text = login.usuario_nombre;
        
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnalmacen_Click(object sender, EventArgs e)
        {
            Form1 vtn = new Form1();
            vtn.Visible = true;
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Form2 vtn = new Form2();
            vtn.Visible = true;
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Form3 vtn = new Form3();
            vtn.Visible = true;
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            Form4 vtn = new Form4();
            vtn.Visible = true;
        }
    }
}
