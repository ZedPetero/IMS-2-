using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.App
{
    public partial class ProgramControl : UserControl
    {
        public string ProgramName = "";
        public string ProgramDescription = "";
        public ProgramControl()
        {
            label1.Text = ProgramName;
            label2.Text = ProgramDescription;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
