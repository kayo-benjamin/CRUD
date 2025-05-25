using CRUD.Forms;
using CRUD.Helpers;
using CRUD.Services;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void BtnLoadUsers_Click(object sender, EventArgs e)
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
                    listItem.SubItems.Add(user.Sexo);
                    listItem.SubItems.Add(user.CPF);
                    listItem.SubItems.Add(user.Endereco);
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

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            FormCadUsuario form2 = new FormCadUsuario();
            form2.ShowDialog();
        }

        private void TestarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarStatusConexao();
        }

        private void PropriedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loadingForm = new FormLoading();
            loadingForm.StartPosition = FormStartPosition.CenterScreen;
            loadingForm.Show();

            for (int i = 0; i <= 100; i += 10)
            {

                loadingForm.UpdateProgress(i);

                AtualizarStatusConexao();

                if (DatabaseHelper.IsConnected)
                {
                    loadingForm.Close();
                }
            }

            // Exibe a janela de configurações
            DatabaseConfig databaseHelp = new DatabaseConfig();
            databaseHelp.ShowDialog();
        }

        private void AdicionarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCargo cadCargo = new CadastroCargo();
            cadCargo.ShowDialog();
        }

        private void ListarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCargo listCargo = new ListCargo();
            listCargo.ShowDialog();
        }
    }
}
