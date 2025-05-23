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

namespace CRUD.Forms
{
    public partial class CadastroCargo : Form
    {
        public CadastroCargo()
        {
            InitializeComponent();
        }

        private void BtnCreateCargo_Click(object sender, EventArgs e)
        {
            if (TxtBoxCargo.Text != "") {
                Cargo cargo = new Cargo
                {
                   TipoNome = TxtBoxCargo.Text
                };
                CargoService cargoService = new CargoService();
                if ( cargoService.CreateCargo(cargo))
                {
                    MessageBox.Show("Sucesso ao salvar o Cargo");
                }
            }
        }
    }
}
