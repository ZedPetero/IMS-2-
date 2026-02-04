using IMS.Domain.Models;
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
        private void LoadPrograms(string? searchTerm = null)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    if (string.IsNullOrEmpty(searchTerm))
                        dataGridView1.DataSource = _context.Programs.ToList();
                    else
                        dataGridView1.DataSource = _context.Programs
                            .Where(p => p.Id.ToString().Contains(searchTerm) ||
                                        p.Name.ToLower().Contains(searchTerm) ||
                                        p.Description.ToLower().Contains(searchTerm))
                            .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPrograms(textBoxSearch.Text.ToLower());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    if (string.IsNullOrEmpty(textBoxId.Text.Trim()))
                    {
                        var program = new Programs
                        {
                            Name = textBoxName.Text.Trim(),
                            Description = textBoxDescription.Text.Trim()
                        };

                        _context.Programs.Add(program);
                    }
                    else
                    {
                        var ProgramId = int.Parse(textBoxId.Text.Trim());
                        var entity = _context.Programs.Find(ProgramId);
                        if (entity != null)
                        {
                            entity.Name = textBoxName.Text.Trim();
                            entity.Description = textBoxDescription.Text.Trim();
                        }
                        else
                        {
                            MessageBox.Show("Program not found for update.");
                            return;
                        }
                        _context.Programs.Update(entity);
                    }

                    _context.SaveChanges();

                    MessageBox.Show("Program saved/updated succesfully");
                    LoadPrograms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new AppDbContext())
                {
                    if (string.IsNullOrEmpty(textBoxName.Text.Trim()))
                    {
                        MessageBox.Show("Please enter a valid Program ID to delete");
                        return;
                    }
                    var programId = int.Parse(textBoxId.Text.Trim());
                    var entity = _context.Programs.FirstOrDefault(p => p.Id == programId);
                    if (entity != null)
                    {
                        _context.Programs.Remove(entity);
                        _context.SaveChanges();
                        MessageBox.Show("Program deleted succesfully!");
                        LoadPrograms();
                    }
                    else
                    {
                        MessageBox.Show("Program not found for deletion");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
