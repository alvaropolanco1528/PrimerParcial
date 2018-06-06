using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primer_parcial.BLL;
using Primer_parcial.DAL;
using Primer_parcial.UI;
using Primer_parcial.Entidades;

namespace Primer_parcial.UI.Consultas
{
    public partial class ConsulataParcia : Form
    {
        public ConsulataParcia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarConsulta_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.ValueMember);
            Grupos grupos = BLL.GruposBll.Buscar(id);

            if (grupos != null)
            {

            }
            else
                MessageBox.Show("El grupo no fue encontrado","Fallo",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
