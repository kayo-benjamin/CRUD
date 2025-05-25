namespace CRUD.Forms
{
    partial class ListCargo
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ListViewCargo = new ListView();
            ColumnId = new ColumnHeader();
            ColumnName = new ColumnHeader();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ListViewCargo);
            flowLayoutPanel1.Location = new Point(12, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(388, 192);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ListViewCargo
            // 
            ListViewCargo.Alignment = ListViewAlignment.Default;
            ListViewCargo.Columns.AddRange(new ColumnHeader[] { ColumnId, ColumnName });
            ListViewCargo.Font = new Font("Arial", 9F);
            ListViewCargo.GridLines = true;
            ListViewCargo.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewCargo.Location = new Point(3, 3);
            ListViewCargo.Name = "ListViewCargo";
            ListViewCargo.Size = new Size(385, 189);
            ListViewCargo.TabIndex = 0;
            ListViewCargo.UseCompatibleStateImageBehavior = false;
            ListViewCargo.View = View.Details;
            // 
            // ColumnId
            // 
            ColumnId.Text = "Id";
            ColumnId.Width = 50;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Nome";
            ColumnName.Width = 326;
            // 
            // ListCargo
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 226);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Arial", 9F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListCargo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD - List Cargos";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ListView ListViewCargo;
        private ColumnHeader ColumnId;
        private ColumnHeader ColumnName;
    }
}