using IMS.Infustructure.Data;

namespace IMS.Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPrograms();
        }
        private void LoadPrograms()
        {
            using (var _context = new AppDbContext())
            {
                dataGridView1.DataSource = _context.Programs.ToList();
            }
        }
    }
}
