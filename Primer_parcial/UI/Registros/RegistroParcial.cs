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

  

namespace Primer_parcial.UI.Registros
{
    public partial class RegistroParcial : Form
    {
        public RegistroParcial()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grupos grupo = LlenarClase();
            bool paso = false;
            if (InumericDown.value == 0)
                paso = BLL.GruposBll.Guardar(grupo);
            else
                paso = BLL.GruposBll.Modificar(LlenarClase());

            if (paso)

                MessageBox.Show("Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", MessageBoxDefaultButton.OK, MessageBoxIcon, ErrorBlinkStyle);

        }

        private void RegistroParcial_Load(object sender, EventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
