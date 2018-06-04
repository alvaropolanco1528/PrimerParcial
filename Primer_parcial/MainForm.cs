using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primer_parcial.UI.Registros;
using Primer_parcial.UI.Consultas;

namespace Primer_parcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroParcial db = new RegistroParcial();
            db.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsulataParcia db = new ConsulataParcia();
            db.Show();
        }
    }
}
