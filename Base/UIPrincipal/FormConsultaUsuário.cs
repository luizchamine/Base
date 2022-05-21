using BLL;
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
            using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource))
            {
                frm.ShowDialog();
            }
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
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
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
            if (MessageBox.Show("tem certeza que deseja excluir este registro?",
                "atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["id"]);
            usuarioBLL.Excluir(id);
            usuarioBindingSource.RemoveCurrent();
            MessageBox.Show("usuário excluído.");
        }
    }
}
