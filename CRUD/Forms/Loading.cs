using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD.Forms
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int progress)
        {
            if (ProgressLoadingCommon.InvokeRequired)
            {
                ProgressLoadingCommon.Invoke(new Action(() => ProgressLoadingCommon.Value = progress));
            }
            else
            {
                ProgressLoadingCommon.Value = progress;
            }
        }
    }
}
