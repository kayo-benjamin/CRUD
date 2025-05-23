using CRUD.Helpers;
using CRUD.Services;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarStatusConexao();
        }
        private void AtualizarStatusConexao()
        {
            bool conectado = DatabaseHelper.TestConnection();

            if (conectado)
            {
                labelConnection.Text = "Status Conectado";
                labelConnection.ForeColor = Color.Green;
            }
            else
            {
                labelConnection.Text = "Status Desconectado";
                labelConnection.ForeColor = Color.Red;
            }
        }

        private void btnVerifyConnection_Click(object sender, EventArgs e)
        {
            AtualizarStatusConexao();
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                listView1.Items.Clear();

                var userService = new UserService();

                var users = userService.GetAllUsers();

                foreach (var user in users)
                {
                    var listItem = new ListViewItem(user.Nome);
                    listItem.SubItems.Add(user.Email);
                    listView1.Items.Add(listItem);
                }

                MessageBox.Show($"{users.Count} usuário(s) carregado(s).", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FormCadUsuario form2 = new FormCadUsuario();
            form2.ShowDialog();
        }
    }
}
