using JournalApp.Models;

namespace JournalApp
{
    public partial class Form1 : Form
    {
        private readonly SchoolContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new SchoolContext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("������� ����� � ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = _context.Students
                .FirstOrDefault(s => s.Login == login && s.Password == password);

            if (student != null)
            {
                MessageBox.Show($"����� ����������, ������� {student.Name}!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new StudentDashboardForm(student).ShowDialog();
                this.Close();
                return;
            }

            var teacher = _context.Teachers
                .FirstOrDefault(t => t.Login == login && t.Password == password);

            if (teacher != null)
            {
                MessageBox.Show($"����� ����������, ������������� {teacher.Name}!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new TeacherDashboardForm(teacher).ShowDialog();
                this.Close();
                return;
            }

            MessageBox.Show("�������� ����� ��� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
