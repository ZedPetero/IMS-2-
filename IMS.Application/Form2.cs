using IMS.Infustructure.Data;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadForms();
        }

        public void LoadForms()
        {
            using (var _context = new AppDbContext())
            {
                var programs = _context.Programs.ToList();
                foreach (var program in programs)
                {
                    var programControl = new ProgramControl();
                    programControl.ProgramName = program.Name ?? "{Needs Updating}";
                    programControl.ProgramDescription = program.Description ?? "{Needs Updating}";
                    flowLayoutPanel1.Controls.Add(programControl);
                }
            }
        }
    }
}
