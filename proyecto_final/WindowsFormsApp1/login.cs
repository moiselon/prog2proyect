using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_entidad;
using capa_negocio;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        principal frm1 = new principal();

        public static string usuario_nombre;
        public static string area;

        void p_logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txtusuario.Text;
            objeuser.clave = txtpass.Text;

            dt = objnuser.N_user(objeuser);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();
                frm1.ShowDialog();

                login login = new login();
                login.ShowDialog();

                if(login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new principal());

                    txtusuario.Clear();
                    txtpass.Clear();
                }

                else
                {
                    MessageBox.Show("usuario o contraseña incorrecta" , "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
