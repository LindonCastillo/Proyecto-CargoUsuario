using RegistroCompleto.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCompleto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios formRegistroUsuarios = new rUsuarios();
            formRegistroUsuarios.MdiParent = this;
            formRegistroUsuarios.Show();
        }

        private void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargo formRegistroCargos = new rCargo();
            formRegistroCargos.MdiParent = this;
            formRegistroCargos.Show();
        }
    }
}
