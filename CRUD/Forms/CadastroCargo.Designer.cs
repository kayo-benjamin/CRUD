namespace CRUD.Forms
{
    partial class CadastroCargo
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
            splitContainer1 = new SplitContainer();
            BtnCreateCargo = new Button();
            TxtBoxCargo = new TextBox();
            LabelFormCargo = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCreateCargo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtBoxCargo);
            splitContainer1.Panel2.Controls.Add(LabelFormCargo);
            splitContainer1.Size = new Size(522, 252);
            splitContainer1.SplitterDistance = 174;
            splitContainer1.TabIndex = 0;
            // 
            // BtnCreateCargo
            // 
            BtnCreateCargo.Location = new Point(38, 211);
            BtnCreateCargo.Name = "BtnCreateCargo";
            BtnCreateCargo.Size = new Size(94, 29);
            BtnCreateCargo.TabIndex = 0;
            BtnCreateCargo.Text = "Salvar";
            BtnCreateCargo.UseVisualStyleBackColor = true;
            BtnCreateCargo.Click += BtnCreateCargo_Click;
            // 
            // TxtBoxCargo
            // 
            TxtBoxCargo.Location = new Point(53, 120);
            TxtBoxCargo.MaxLength = 50;
            TxtBoxCargo.Name = "TxtBoxCargo";
            TxtBoxCargo.Size = new Size(230, 25);
            TxtBoxCargo.TabIndex = 1;
            // 
            // LabelFormCargo
            // 
            LabelFormCargo.AutoSize = true;
            LabelFormCargo.Location = new Point(144, 87);
            LabelFormCargo.Name = "LabelFormCargo";
            LabelFormCargo.Size = new Size(48, 17);
            LabelFormCargo.TabIndex = 0;
            LabelFormCargo.Text = "Cargo";
            // 
            // CadastroCargo
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 252);
            Controls.Add(splitContainer1);
            Font = new Font("Arial", 9F);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CadastroCargo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD - Cargo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label LabelFormCargo;
        private Button BtnCreateCargo;
        private TextBox TxtBoxCargo;
    }
}