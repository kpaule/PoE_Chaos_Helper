using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Chaos_Helper
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        #region Events
        private void FormAbout_Load(object sender, EventArgs e)
        {
            richTextBoxAbout.Text = "Chaos Helper\n" +
                "v1.1\n" +
                "https://github.com/kpaule/PoE_Chaos_Helper\n";
        }
        #endregion
    }
}
