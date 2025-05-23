namespace CRUD.Forms
{
    partial class FormLoading
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
            ProgressLoadingCommon = new ProgressBar();
            SuspendLayout();
            // 
            // ProgressLoadingCommon
            // 
            ProgressLoadingCommon.Location = new Point(62, 62);
            ProgressLoadingCommon.Name = "ProgressLoadingCommon";
            ProgressLoadingCommon.Size = new Size(222, 29);
            ProgressLoadingCommon.TabIndex = 0;
            ProgressLoadingCommon.UseWaitCursor = true;
            // 
            // FormLoading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 148);
            Controls.Add(ProgressLoadingCommon);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLoading";
            ShowInTaskbar = false;
            Text = "Carregando";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar ProgressLoadingCommon;
    }
}