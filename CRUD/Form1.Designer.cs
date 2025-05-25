namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreateUser = new Button();
            button2 = new Button();
            btnLoadUsers = new Button();
            button4 = new Button();
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnEmail = new ColumnHeader();
            columnSex = new ColumnHeader();
            columnCPF = new ColumnHeader();
            columnEndereco = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelConnection = new Label();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            tabelasToolStripMenuItem = new ToolStripMenuItem();
            propriedadesToolStripMenuItem = new ToolStripMenuItem();
            testarConexãoToolStripMenuItem = new ToolStripMenuItem();
            tipoToolStripMenuItem = new ToolStripMenuItem();
            adicionarTipoToolStripMenuItem = new ToolStripMenuItem();
            listarTiposToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCreateUser);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(btnLoadUsers);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(1, 105);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(332, 331);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCreateUser
            // 
            btnCreateUser.FlatStyle = FlatStyle.System;
            btnCreateUser.Location = new Point(3, 3);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(326, 43);
            btnCreateUser.TabIndex = 1;
            btnCreateUser.Text = "&Criar";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += BtnCreateUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 52);
            button2.Name = "button2";
            button2.Size = new Size(326, 43);
            button2.TabIndex = 2;
            button2.Text = "&Alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnLoadUsers
            // 
            btnLoadUsers.Location = new Point(3, 101);
            btnLoadUsers.Name = "btnLoadUsers";
            btnLoadUsers.Size = new Size(326, 43);
            btnLoadUsers.TabIndex = 3;
            btnLoadUsers.Text = "&Ler";
            btnLoadUsers.UseVisualStyleBackColor = true;
            btnLoadUsers.Click += BtnLoadUsers_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 150);
            button4.Name = "button4";
            button4.Size = new Size(326, 43);
            button4.TabIndex = 4;
            button4.Text = "&Deletar";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnEmail, columnSex, columnCPF, columnEndereco });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(853, 331);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Nome";
            columnName.Width = 100;
            // 
            // columnEmail
            // 
            columnEmail.Text = "Email";
            columnEmail.TextAlign = HorizontalAlignment.Center;
            columnEmail.Width = 200;
            // 
            // columnSex
            // 
            columnSex.Text = "Sex";
            columnSex.TextAlign = HorizontalAlignment.Center;
            // 
            // columnCPF
            // 
            columnCPF.Text = "CPF";
            columnCPF.TextAlign = HorizontalAlignment.Center;
            columnCPF.Width = 80;
            // 
            // columnEndereco
            // 
            columnEndereco.Text = "Endereco";
            columnEndereco.TextAlign = HorizontalAlignment.Center;
            columnEndereco.Width = 409;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listView1, 0, 0);
            tableLayoutPanel1.Location = new Point(339, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(859, 337);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelConnection
            // 
            labelConnection.AutoSize = true;
            labelConnection.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConnection.Location = new Point(1046, 78);
            labelConnection.Name = "labelConnection";
            labelConnection.Size = new Size(0, 24);
            labelConnection.TabIndex = 1;
            labelConnection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1210, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bancoDeDadosToolStripMenuItem, tipoToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "&Settings";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tabelasToolStripMenuItem, propriedadesToolStripMenuItem, testarConexãoToolStripMenuItem });
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(224, 26);
            bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            // 
            // tabelasToolStripMenuItem
            // 
            tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            tabelasToolStripMenuItem.Size = new Size(193, 26);
            tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // propriedadesToolStripMenuItem
            // 
            propriedadesToolStripMenuItem.Name = "propriedadesToolStripMenuItem";
            propriedadesToolStripMenuItem.Size = new Size(193, 26);
            propriedadesToolStripMenuItem.Text = "Propriedades";
            propriedadesToolStripMenuItem.Click += PropriedadesToolStripMenuItem_Click;
            // 
            // testarConexãoToolStripMenuItem
            // 
            testarConexãoToolStripMenuItem.Name = "testarConexãoToolStripMenuItem";
            testarConexãoToolStripMenuItem.Size = new Size(193, 26);
            testarConexãoToolStripMenuItem.Text = "Testar Conexão";
            testarConexãoToolStripMenuItem.Click += TestarConexãoToolStripMenuItem_Click;
            // 
            // tipoToolStripMenuItem
            // 
            tipoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarTipoToolStripMenuItem, listarTiposToolStripMenuItem });
            tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            tipoToolStripMenuItem.Size = new Size(224, 26);
            tipoToolStripMenuItem.Text = "&Tipo";
            // 
            // adicionarTipoToolStripMenuItem
            // 
            adicionarTipoToolStripMenuItem.Name = "adicionarTipoToolStripMenuItem";
            adicionarTipoToolStripMenuItem.Size = new Size(224, 26);
            adicionarTipoToolStripMenuItem.Text = "Adicionar Tipo";
            adicionarTipoToolStripMenuItem.Click += AdicionarTipoToolStripMenuItem_Click;
            // 
            // listarTiposToolStripMenuItem
            // 
            listarTiposToolStripMenuItem.Name = "listarTiposToolStripMenuItem";
            listarTiposToolStripMenuItem.Size = new Size(224, 26);
            listarTiposToolStripMenuItem.Text = "Listar Tipos";
            listarTiposToolStripMenuItem.Click += ListarTiposToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 451);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelConnection);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD - Trabalho";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreateUser;
        private Button button2;
        private Button btnLoadUsers;
        private Button button4;
        private ListView listView1;
        private ColumnHeader columnName;
        private ColumnHeader columnEmail;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelConnection;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem tabelasToolStripMenuItem;
        private ToolStripMenuItem propriedadesToolStripMenuItem;
        private ColumnHeader columnSex;
        private ColumnHeader columnCPF;
        private ToolStripMenuItem testarConexãoToolStripMenuItem;
        private ColumnHeader columnEndereco;
        private ToolStripMenuItem tipoToolStripMenuItem;
        private ToolStripMenuItem adicionarTipoToolStripMenuItem;
        private ToolStripMenuItem listarTiposToolStripMenuItem;
    }
}
