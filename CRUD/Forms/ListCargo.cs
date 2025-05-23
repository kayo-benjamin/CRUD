using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Services;

namespace CRUD.Forms
{
    public partial class ListCargo : Form
    {
        public ListCargo()
        {
            InitializeComponent();
            LoadCargos();
        }

        private void LoadCargos()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ListViewCargo.Items.Clear();

                var cargoService = new CargoService();

                var cargos = cargoService.GetCargoList();

                foreach (var cargo in cargos)
                {
                    var listItem = new ListViewItem(Convert.ToString(cargo.Id));
                    listItem.SubItems.Add(cargo.TipoNome);
                    ListViewCargo.Items.Add(listItem);
                }
                MessageBox.Show($"{cargos.Count} cargo(s) carregado(s).", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
