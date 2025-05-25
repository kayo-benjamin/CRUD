using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Helpers;

namespace CRUD.Forms
{
    public partial class DatabaseConfig : Form
    {
        public DatabaseConfig()
        {
            InitializeComponent();
            GetConfig();
        }
        
        private void GetConfig()
        {
            if (!Connected())
            {
                LabelDatabaseName.Text = "Falha na conexão, verificar se o serviço está ligado";
                LabelDatabaseName.ForeColor = Color.Red;
                ChkDatabaseConnected.Checked = false;
            } else {
                LabelDatabaseName.Text = DatabaseHelper.DatabaseName;
                labelValueVersion.Text = DatabaseHelper.PostgreSqlVersion;
                labelValueConnections.Text = Convert.ToString(DatabaseHelper.ActiveConnections);
                ChkDatabaseConnected.Checked = true;
            }
        }

        private static bool Connected()
        {
            bool connected = DatabaseHelper.IsConnected;
            if (!connected) { 
                return DatabaseHelper.TestConnection();
            }
            return connected;
        }
    }
}
