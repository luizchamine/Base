using System;
using System.Windows.Forms;
using BLL;
using Model;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;

        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("cadastro realizado.");
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;

            usuarioBLL.Inserir(usuario);
            if (inserindoNovo == true)
                usuarioBLL.Alterar(usuario);
            else
                usuarioBLL.Alterar(usuario);
            
        }

        private void buttonSalvarECadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("cadastro realizado.");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
            nomeUsuarioTextBox.Focus();

        }
    }
}
