namespace CRUD.Forms
{
    partial class DatabaseConfig
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
            LabelStatusConnection = new Label();
            labelPostgreVersion = new Label();
            labelConnections = new Label();
            ChkDatabaseConnected = new CheckBox();
            panel1 = new Panel();
            LabelDatabaseName = new Label();
            labelValueVersion = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelValueConnections = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(LabelStatusConnection);
            flowLayoutPanel1.Controls.Add(labelPostgreVersion);
            flowLayoutPanel1.Controls.Add(labelConnections);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(138, 230);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // LabelStatusConnection
            // 
            LabelStatusConnection.AutoSize = true;
            LabelStatusConnection.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelStatusConnection.Location = new Point(3, 0);
            LabelStatusConnection.Name = "LabelStatusConnection";
            LabelStatusConnection.Size = new Size(54, 17);
            LabelStatusConnection.TabIndex = 0;
            LabelStatusConnection.Text = "Status:";
            LabelStatusConnection.TextAlign = ContentAlignment.MiddleCenter;
            LabelStatusConnection.UseMnemonic = false;
            // 
            // labelPostgreVersion
            // 
            labelPostgreVersion.AutoSize = true;
            labelPostgreVersion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPostgreVersion.Location = new Point(3, 17);
            labelPostgreVersion.Name = "labelPostgreVersion";
            labelPostgreVersion.Size = new Size(57, 17);
            labelPostgreVersion.TabIndex = 2;
            labelPostgreVersion.Text = "Versão:";
            labelPostgreVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConnections
            // 
            labelConnections.AutoSize = true;
            labelConnections.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConnections.Location = new Point(3, 34);
            labelConnections.Name = "labelConnections";
            labelConnections.Size = new Size(120, 17);
            labelConnections.TabIndex = 3;
            labelConnections.Text = "Conexões Ativas:";
            labelConnections.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChkDatabaseConnected
            // 
            ChkDatabaseConnected.AutoCheck = false;
            ChkDatabaseConnected.AutoSize = true;
            ChkDatabaseConnected.Cursor = Cursors.No;
            ChkDatabaseConnected.Enabled = false;
            ChkDatabaseConnected.Location = new Point(3, 3);
            ChkDatabaseConnected.Name = "ChkDatabaseConnected";
            ChkDatabaseConnected.Size = new Size(18, 17);
            ChkDatabaseConnected.TabIndex = 1;
            ChkDatabaseConnected.TabStop = false;
            ChkDatabaseConnected.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(LabelDatabaseName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 83);
            panel1.TabIndex = 1;
            // 
            // LabelDatabaseName
            // 
            LabelDatabaseName.AutoSize = true;
            LabelDatabaseName.Dock = DockStyle.Left;
            LabelDatabaseName.FlatStyle = FlatStyle.Popup;
            LabelDatabaseName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Underline);
            LabelDatabaseName.Location = new Point(0, 0);
            LabelDatabaseName.Name = "LabelDatabaseName";
            LabelDatabaseName.Size = new Size(208, 35);
            LabelDatabaseName.TabIndex = 0;
            LabelDatabaseName.Text = "$DatabaseName";
            LabelDatabaseName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValueVersion
            // 
            labelValueVersion.AutoSize = true;
            labelValueVersion.Location = new Point(3, 23);
            labelValueVersion.Name = "labelValueVersion";
            labelValueVersion.Size = new Size(0, 20);
            labelValueVersion.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(ChkDatabaseConnected);
            flowLayoutPanel2.Controls.Add(labelValueVersion);
            flowLayoutPanel2.Controls.Add(labelValueConnections);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(156, 101);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(108, 230);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // labelValueConnections
            // 
            labelValueConnections.AutoSize = true;
            labelValueConnections.Font = new Font("Arial", 9F);
            labelValueConnections.Location = new Point(3, 43);
            labelValueConnections.Name = "labelValueConnections";
            labelValueConnections.Size = new Size(0, 17);
            labelValueConnections.TabIndex = 3;
            // 
            // DatabaseConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 343);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabaseConfig";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD - Database Config";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label LabelDatabaseName;
        private Label LabelStatusConnection;
        private CheckBox ChkDatabaseConnected;
        private Label labelPostgreVersion;
        private Label labelValueVersion;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelConnections;
        private Label labelValueConnections;
    }
}