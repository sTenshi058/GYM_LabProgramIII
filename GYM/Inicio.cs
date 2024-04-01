using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_Clientes Mcliente = new M_Clientes();
            Mcliente.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            M_Empleados MEmpleados = new M_Empleados();
            MEmpleados.Show();
        }

        private void cargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            M_Cargos MCargos = new M_Cargos();
            MCargos.Show();
        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            M_Usuarios MUsuarios = new M_Usuarios();
            MUsuarios.Show();
        }
    }
}
