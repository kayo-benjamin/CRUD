using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Models;
using CRUD.Services;

namespace CRUD
{
    public partial class FormCadUsuario : Form
    {
        public FormCadUsuario()
        {
            InitializeComponent();
            LoadCargos();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Nome = TxtBoxUser.Text,
                Email = TxtBoxEmail.Text,
                Senha = TxtBoxPass.Text,
                CPF = TxtBoxCPF.Text,
                Telefone = TxtBoxTelefone.Text,
                Endereco = TxtBoxAddress.Text,
                Sexo = ComboBoxSex.SelectedItem?.ToString(),
                TipoId = (ComboBoxCargo.SelectedItem as dynamic)?.Id,
                DataNascimento = DateTime.TryParse(MTextBoxDateNasc.Text, out var date) ? date : null
            };

            UserService userService = new UserService();
            userService.CreateUser(user);
        }

        private void LoadCargos()
        {
            ComboBoxCargo.Items.Clear();

            var cargoService = new CargoService();
            var cargos = cargoService.GetCargoList();

            // Adiciona os cargos ao ComboBox
            foreach (var cargo in cargos)
            {
                ComboBoxCargo.Items.Add(new { Id = cargo.Id, TipoNome = cargo.TipoNome });
            }

            ComboBoxCargo.DisplayMember = "TipoNome"; // O que será exibido na interface
            ComboBoxCargo.ValueMember = "Id"; // O valor interno associado a cada item
        }

    }
}
