using JournalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace JournalApp
{
    public partial class StudentDashboardForm : Form
    {
        private readonly SchoolContext _context;
        private readonly Student _student;

        public StudentDashboardForm(Student student)
        {
            InitializeComponent();
            _context = new SchoolContext();
            _student = student;
            this.Text = $"Панель студента: {_student.Name}";
            LoadSchedule();
            LoadAssignments();
        }

        private void LoadSchedule()
        {
           
            var schedule = _context.Scdedules
                .Include(s => s.Group)
                .Include(s => s.Class)
                .Include(s => s.SpecialSubject)
                    .ThenInclude(ss => ss.Subject)
                .Include(s => s.SpecialSubject)
                    .ThenInclude(ss => ss.Teacher)
                .Where(s => s.GroupId == _student.GroupId)
                .Select(s => new
                {
                    s.Id,
                    Group = s.Group.Title,
                    Subject = s.SpecialSubject.Subject.Title,
                    Teacher = s.SpecialSubject.Teacher.Name,
                    Class = s.Class.Title,
                    Type = s.Class.Type,
                    TimeStart = s.TimeStart,
                    TimeEnd = s.TimeEnd
                })
                .ToList();

            dgvSchedule.DataSource = schedule;
            
            dgvSchedule.Columns["Id"].Visible = false;
            dgvSchedule.Columns["Group"].HeaderText = "Группа";
            dgvSchedule.Columns["Subject"].HeaderText = "Предмет";
            dgvSchedule.Columns["Teacher"].HeaderText = "Преподаватель";
            dgvSchedule.Columns["Class"].HeaderText = "Аудитория";
            dgvSchedule.Columns["Type"].HeaderText = "Тип занятия";
            dgvSchedule.Columns["TimeStart"].HeaderText = "Начало";
            dgvSchedule.Columns["TimeEnd"].HeaderText = "Конец";
        }

        private void LoadAssignments()
        {
            
            var assignments = _context.Assignments
                .Include(a => a.Subject)
                .Include(a => a.Scdedule)
                    .ThenInclude(s => s.Group)
                .Where(a => a.Scdedule.GroupId == _student.GroupId)
                .Select(a => new
                {
                    a.Id,
                    Subject = a.Subject.Title,
                    a.Title,
                    a.Description,
                    a.Deadline,
                    ScheduleId = a.ScdeduleId
                })
                .ToList();

            dgvAssignments.DataSource = assignments;
            dgvAssignments.Columns["Id"].Visible = false;
            dgvAssignments.Columns["Subject"].HeaderText = "Предмет";
            dgvAssignments.Columns["Title"].HeaderText = "Название";
            dgvAssignments.Columns["Description"].HeaderText = "Описание";
            dgvAssignments.Columns["Deadline"].HeaderText = "Срок сдачи";
            dgvAssignments.Columns["ScheduleId"].Visible = false;
        }

        private void btnSubmitAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задание для сдачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string submissionText = txtSubmission.Text.Trim();
            if (string.IsNullOrEmpty(submissionText))
            {
                MessageBox.Show("Введите ответ на задание.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int assignmentId = (int)dgvAssignments.SelectedRows[0].Cells["Id"].Value;
                var assignment = _context.Assignments.Find(assignmentId);

                if (assignment.Deadline < DateTime.Now)
                {
                    MessageBox.Show("Срок сдачи задания истёк.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                MessageBox.Show($"Задание '{assignment.Title}' сдано! Ответ: {submissionText}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubmission.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сдаче задания: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
