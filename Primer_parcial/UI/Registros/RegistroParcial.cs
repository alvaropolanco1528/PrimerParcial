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
using Primer_parcial.Entidades;
using Primer_parcial.DAL.Scripts;
using Primer_parcial.UI.Registros;
using Primer_parcial.DAL;

  

namespace Primer_parcial.UI.Registros
{
    public partial class RegistroParcial : Form
    {

        public void Limpiar()
        {
            tdescripcion.Clear();

            
        }



        public RegistroParcial()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void RegistroParcial_Load(object sender, EventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

            Limpiar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumero.Value);
            Grupos grupos = BLL.GruposBll.Buscar(id);

            if (grupos != null)
            {

            }
            else
                MessageBox.Show("El grupo no fue encontrado", "Fallo",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IDnumero.Value);
            if (BLL.GruposBll.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se Pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void Grupo_Click(object sender, EventArgs e)
        {

        }
    }
}
