using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConsultaUsuário : Form
    {
        public FormConsultaUsuário()
        {
            InitializeComponent();
        }

        private void FormConsultaUsuário_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaUsuário_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(null, null);
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
