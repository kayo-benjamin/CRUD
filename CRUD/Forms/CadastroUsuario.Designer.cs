namespace CRUD
{
    partial class FormCadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnCreateUser = new Button();
            GBUserBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            TxtBoxPass = new TextBox();
            TxtBoxEmail = new TextBox();
            LabelFieldUsuario = new Label();
            LabelFieldEmail = new Label();
            LabelFormCPF = new Label();
            LabelFieldPassword = new Label();
            LabelFormTelefone = new Label();
            TxtBoxUser = new TextBox();
            TxtBoxTelefone = new MaskedTextBox();
            TxtBoxCPF = new MaskedTextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            LabelFormDataNasc = new Label();
            ComboBoxSex = new ComboBox();
            LabelFormSex = new Label();
            LabelFormCargo = new Label();
            LabelFormEndereco = new Label();
            ComboBoxCargo = new ComboBox();
            TxtBoxAddress = new TextBox();
            MTextBoxDateNasc = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            GBUserBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(BtnCreateUser, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 325);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(949, 114);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnCreateUser
            // 
            BtnCreateUser.Font = new Font("Arial", 9F);
            BtnCreateUser.Location = new Point(477, 60);
            BtnCreateUser.Name = "BtnCreateUser";
            BtnCreateUser.Size = new Size(155, 29);
            BtnCreateUser.TabIndex = 0;
            BtnCreateUser.Text = "&Criar";
            BtnCreateUser.UseVisualStyleBackColor = true;
            BtnCreateUser.Click += BtnCreateUser_Click;
            // 
            // GBUserBox
            // 
            GBUserBox.Controls.Add(tableLayoutPanel2);
            GBUserBox.Location = new Point(12, 12);
            GBUserBox.Name = "GBUserBox";
            GBUserBox.Size = new Size(471, 284);
            GBUserBox.TabIndex = 1;
            GBUserBox.TabStop = false;
            GBUserBox.Text = "Usuario";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(TxtBoxPass, 1, 4);
            tableLayoutPanel2.Controls.Add(TxtBoxEmail, 1, 1);
            tableLayoutPanel2.Controls.Add(LabelFieldUsuario, 0, 0);
            tableLayoutPanel2.Controls.Add(LabelFieldEmail, 0, 1);
            tableLayoutPanel2.Controls.Add(LabelFormCPF, 0, 2);
            tableLayoutPanel2.Controls.Add(LabelFieldPassword, 0, 4);
            tableLayoutPanel2.Controls.Add(LabelFormTelefone, 0, 3);
            tableLayoutPanel2.Controls.Add(TxtBoxUser, 1, 0);
            tableLayoutPanel2.Controls.Add(TxtBoxTelefone, 1, 3);
            tableLayoutPanel2.Controls.Add(TxtBoxCPF, 1, 2);
            tableLayoutPanel2.Location = new Point(6, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(440, 246);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtBoxPass
            // 
            TxtBoxPass.Font = new Font("Arial", 9F);
            TxtBoxPass.Location = new Point(223, 203);
            TxtBoxPass.MaxLength = 20;
            TxtBoxPass.Name = "TxtBoxPass";
            TxtBoxPass.Size = new Size(210, 25);
            TxtBoxPass.TabIndex = 9;
            // 
            // TxtBoxEmail
            // 
            TxtBoxEmail.Font = new Font("Arial", 9F);
            TxtBoxEmail.Location = new Point(223, 53);
            TxtBoxEmail.MaxLength = 72;
            TxtBoxEmail.Name = "TxtBoxEmail";
            TxtBoxEmail.Size = new Size(210, 25);
            TxtBoxEmail.TabIndex = 6;
            // 
            // LabelFieldUsuario
            // 
            LabelFieldUsuario.AutoEllipsis = true;
            LabelFieldUsuario.AutoSize = true;
            LabelFieldUsuario.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFieldUsuario.Location = new Point(3, 0);
            LabelFieldUsuario.Name = "LabelFieldUsuario";
            LabelFieldUsuario.Size = new Size(58, 17);
            LabelFieldUsuario.TabIndex = 1;
            LabelFieldUsuario.Text = "&Usuário";
            LabelFieldUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFieldEmail
            // 
            LabelFieldEmail.AutoEllipsis = true;
            LabelFieldEmail.AutoSize = true;
            LabelFieldEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFieldEmail.Location = new Point(3, 50);
            LabelFieldEmail.Name = "LabelFieldEmail";
            LabelFieldEmail.Size = new Size(45, 17);
            LabelFieldEmail.TabIndex = 2;
            LabelFieldEmail.Text = "&Email";
            LabelFieldEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFormCPF
            // 
            LabelFormCPF.AutoEllipsis = true;
            LabelFormCPF.AutoSize = true;
            LabelFormCPF.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormCPF.Location = new Point(3, 100);
            LabelFormCPF.Name = "LabelFormCPF";
            LabelFormCPF.Size = new Size(38, 17);
            LabelFormCPF.TabIndex = 3;
            LabelFormCPF.Text = "&CPF";
            LabelFormCPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFieldPassword
            // 
            LabelFieldPassword.AutoEllipsis = true;
            LabelFieldPassword.AutoSize = true;
            LabelFieldPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFieldPassword.Location = new Point(3, 200);
            LabelFieldPassword.Name = "LabelFieldPassword";
            LabelFieldPassword.Size = new Size(50, 17);
            LabelFieldPassword.TabIndex = 0;
            LabelFieldPassword.Text = "&Senha";
            LabelFieldPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFormTelefone
            // 
            LabelFormTelefone.AutoEllipsis = true;
            LabelFormTelefone.AutoSize = true;
            LabelFormTelefone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormTelefone.Location = new Point(3, 150);
            LabelFormTelefone.Name = "LabelFormTelefone";
            LabelFormTelefone.Size = new Size(62, 17);
            LabelFormTelefone.TabIndex = 4;
            LabelFormTelefone.Text = "&Telefone";
            LabelFormTelefone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtBoxUser
            // 
            TxtBoxUser.Font = new Font("Arial", 9F);
            TxtBoxUser.Location = new Point(223, 3);
            TxtBoxUser.MaxLength = 32;
            TxtBoxUser.Name = "TxtBoxUser";
            TxtBoxUser.Size = new Size(210, 25);
            TxtBoxUser.TabIndex = 5;
            // 
            // TxtBoxTelefone
            // 
            TxtBoxTelefone.Location = new Point(223, 153);
            TxtBoxTelefone.Mask = "(999) 000-0000";
            TxtBoxTelefone.Name = "TxtBoxTelefone";
            TxtBoxTelefone.Size = new Size(210, 27);
            TxtBoxTelefone.TabIndex = 10;
            // 
            // TxtBoxCPF
            // 
            TxtBoxCPF.Location = new Point(223, 103);
            TxtBoxCPF.Mask = "000\\.000\\.000\\-00";
            TxtBoxCPF.Name = "TxtBoxCPF";
            TxtBoxCPF.Size = new Size(210, 27);
            TxtBoxCPF.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Location = new Point(489, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 284);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(LabelFormDataNasc, 0, 3);
            tableLayoutPanel3.Controls.Add(ComboBoxSex, 1, 2);
            tableLayoutPanel3.Controls.Add(LabelFormSex, 0, 2);
            tableLayoutPanel3.Controls.Add(LabelFormCargo, 0, 1);
            tableLayoutPanel3.Controls.Add(LabelFormEndereco, 0, 0);
            tableLayoutPanel3.Controls.Add(ComboBoxCargo, 1, 1);
            tableLayoutPanel3.Controls.Add(TxtBoxAddress, 1, 0);
            tableLayoutPanel3.Controls.Add(MTextBoxDateNasc, 1, 3);
            tableLayoutPanel3.Location = new Point(6, 26);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(440, 246);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // LabelFormDataNasc
            // 
            LabelFormDataNasc.AutoEllipsis = true;
            LabelFormDataNasc.AutoSize = true;
            LabelFormDataNasc.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormDataNasc.Location = new Point(3, 195);
            LabelFormDataNasc.Name = "LabelFormDataNasc";
            LabelFormDataNasc.Size = new Size(141, 17);
            LabelFormDataNasc.TabIndex = 11;
            LabelFormDataNasc.Text = "&Data de Nascimento";
            LabelFormDataNasc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboBoxSex
            // 
            ComboBoxSex.Font = new Font("Arial", 9F);
            ComboBoxSex.FormattingEnabled = true;
            ComboBoxSex.Items.AddRange(new object[] { "M", "F" });
            ComboBoxSex.Location = new Point(223, 157);
            ComboBoxSex.Name = "ComboBoxSex";
            ComboBoxSex.Size = new Size(72, 25);
            ComboBoxSex.TabIndex = 9;
            // 
            // LabelFormSex
            // 
            LabelFormSex.AutoEllipsis = true;
            LabelFormSex.AutoSize = true;
            LabelFormSex.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormSex.Location = new Point(3, 154);
            LabelFormSex.Name = "LabelFormSex";
            LabelFormSex.Size = new Size(41, 17);
            LabelFormSex.TabIndex = 8;
            LabelFormSex.Text = "&Sexo";
            LabelFormSex.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFormCargo
            // 
            LabelFormCargo.AutoEllipsis = true;
            LabelFormCargo.AutoSize = true;
            LabelFormCargo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormCargo.Location = new Point(3, 119);
            LabelFormCargo.Name = "LabelFormCargo";
            LabelFormCargo.Size = new Size(48, 17);
            LabelFormCargo.TabIndex = 6;
            LabelFormCargo.Text = "&Cargo";
            LabelFormCargo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFormEndereco
            // 
            LabelFormEndereco.AutoEllipsis = true;
            LabelFormEndereco.AutoSize = true;
            LabelFormEndereco.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormEndereco.Location = new Point(3, 0);
            LabelFormEndereco.Name = "LabelFormEndereco";
            LabelFormEndereco.Size = new Size(71, 17);
            LabelFormEndereco.TabIndex = 1;
            LabelFormEndereco.Text = "&Endereço";
            LabelFormEndereco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboBoxCargo
            // 
            ComboBoxCargo.Font = new Font("Arial", 9F);
            ComboBoxCargo.FormattingEnabled = true;
            ComboBoxCargo.Location = new Point(223, 122);
            ComboBoxCargo.Name = "ComboBoxCargo";
            ComboBoxCargo.Size = new Size(210, 25);
            ComboBoxCargo.TabIndex = 7;
            // 
            // TxtBoxAddress
            // 
            TxtBoxAddress.Font = new Font("Arial", 9F);
            TxtBoxAddress.Location = new Point(223, 3);
            TxtBoxAddress.Multiline = true;
            TxtBoxAddress.Name = "TxtBoxAddress";
            TxtBoxAddress.Size = new Size(210, 93);
            TxtBoxAddress.TabIndex = 10;
            // 
            // MTextBoxDateNasc
            // 
            MTextBoxDateNasc.Font = new Font("Arial", 9F);
            MTextBoxDateNasc.Location = new Point(223, 198);
            MTextBoxDateNasc.Mask = "00/00/0000";
            MTextBoxDateNasc.Name = "MTextBoxDateNasc";
            MTextBoxDateNasc.Size = new Size(93, 25);
            MTextBoxDateNasc.TabIndex = 12;
            MTextBoxDateNasc.ValidatingType = typeof(DateTime);
            // 
            // FormCadUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 451);
            Controls.Add(groupBox1);
            Controls.Add(GBUserBox);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD - Cadastro de Usuario";
            tableLayoutPanel1.ResumeLayout(false);
            GBUserBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnCreateUser;
        private GroupBox GBUserBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LabelFieldPassword;
        private Label LabelFieldUsuario;
        private Label LabelFieldEmail;
        private Label LabelFormCPF;
        private TextBox TxtBoxPass;
        private TextBox TxtBoxEmail;
        private Label LabelFormTelefone;
        private TextBox TxtBoxUser;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LabelFormCargo;
        private Label LabelFormEndereco;
        private ComboBox ComboBoxSex;
        private Label LabelFormSex;
        private ComboBox ComboBoxCargo;
        private TextBox TxtBoxAddress;
        private Label LabelFormDataNasc;
        private MaskedTextBox TxtBoxTelefone;
        private MaskedTextBox TxtBoxCPF;
        private MaskedTextBox MTextBoxDateNasc;
    }
}