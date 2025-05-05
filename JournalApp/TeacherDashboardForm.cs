using JournalApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalApp
{
    public partial class TeacherDashboardForm: Form
    {
        private readonly SchoolContext _context;
        private readonly Teacher _teacher;
        public TeacherDashboardForm(Teacher teacher)
        {
            InitializeComponent();
            _context = new SchoolContext();
            _teacher = teacher;
            this.Text = $"Панель преподавателя: {_teacher.Name}";
            LoadSchedule();
            LoadComboBoxes();
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
                .Where(s => s.SpecialSubject.TeacherId == _teacher.Id)
                .Select(s => new
                {
                    s.Id,
                    Group = s.Group.Title,
                    Subject = s.SpecialSubject.Subject.Title,
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
            dgvSchedule.Columns["Class"].HeaderText = "Аудитория";
            dgvSchedule.Columns["Type"].HeaderText = "Тип занятия";
            dgvSchedule.Columns["TimeStart"].HeaderText = "Начало";
            dgvSchedule.Columns["TimeEnd"].HeaderText = "Конец";
        }

        private void LoadComboBoxes()
        {
           
            var groups = _context.Groups.ToList();
            cmbGroup.DataSource = groups;
            cmbGroup.DisplayMember = "Title";
            cmbGroup.ValueMember = "Id";

            
            var classes = _context.Classes.ToList();
            cmbClass.DataSource = classes;
            cmbClass.DisplayMember = "Title";
            cmbClass.ValueMember = "Id";

            
            var specialSubjects = _context.SpecialSubjects
                .Include(ss => ss.Subject)
                .Where(ss => ss.TeacherId == _teacher.Id)
                .ToList();
            cmbSpecialSubject.DataSource = specialSubjects;
            cmbSpecialSubject.DisplayMember = "Subject.Title";
            cmbSpecialSubject.ValueMember = "Id";

            
            var schedules = _context.Scdedules
                .Include(s => s.Group)
                .Include(s => s.SpecialSubject)
                    .ThenInclude(ss => ss.Subject)
                .Where(s => s.SpecialSubject.TeacherId == _teacher.Id)
                .Select(s => new { s.Id, Display = $"{s.Group.Title} - {s.SpecialSubject.Subject.Title} ({s.TimeStart})" })
                .ToList();
            cmbAssignmentSchedule.DataSource = schedules;
            cmbAssignmentSchedule.DisplayMember = "Display";
            cmbAssignmentSchedule.ValueMember = "Id";
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue == null || cmbClass.SelectedValue == null || cmbSpecialSubject.SelectedValue == null)
            {
                MessageBox.Show("Выберите группу, аудиторию и предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpTimeStart.Value >= dtpTimeEnd.Value)
            {
                MessageBox.Show("Время начала должно быть раньше времени окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var lesson = new Scdedule
                {
                    GroupId = (int)cmbGroup.SelectedValue,
                    ClassId = (int)cmbClass.SelectedValue,
                    SpecialSubjectId = (int)cmbSpecialSubject.SelectedValue,
                    TimeStart = dtpTimeStart.Value,
                    TimeEnd = dtpTimeEnd.Value
                };

                _context.Scdedules.Add(lesson);
                _context.SaveChanges();

                MessageBox.Show("Урок успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchedule();
                LoadComboBoxes(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении урока: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string title = txtSubjectTitle.Text.Trim();
            int hourAll = (int)nudHourAll.Value;
            string period = txtPeriod.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(period))
            {
                MessageBox.Show("Заполните название и период.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var subject = new Subject
                {
                    Title = title,
                    HourAll = hourAll,
                    Endind = dtpSubjectEnding.Checked ? dtpSubjectEnding.Value : (DateTime?)null,
                    Period = period
                };

                _context.Subjects.Add(subject);
                _context.SaveChanges();

               
                var specialSubject = new SpecialSubject
                {
                    SubjectId = subject.Id,
                    TeacherId = _teacher.Id
                };

                _context.SpecialSubjects.Add(specialSubject);
                _context.SaveChanges();

                MessageBox.Show("Предмет успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubjectTitle.Clear();
                nudHourAll.Value = 0;
                txtPeriod.Clear();
                dtpSubjectEnding.Checked = false;
                LoadComboBoxes(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении предмета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            string title = txtAssignmentTitle.Text.Trim();
            string description = txtAssignmentDescription.Text.Trim();
            DateTime deadline = dtpAssignmentDeadline.Value;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || cmbAssignmentSchedule.SelectedValue == null)
            {
                MessageBox.Show("Заполните все поля и выберите урок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deadline < DateTime.Now)
            {
                MessageBox.Show("Срок сдачи не может быть в прошлом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var scheduleId = (int)cmbAssignmentSchedule.SelectedValue;
                var schedule = _context.Scdedules
                    .Include(s => s.SpecialSubject)
                    .First(s => s.Id == scheduleId);

                var assignment = new Assignment
                {
                    SubjectId = schedule.SpecialSubject.SubjectId,
                    Title = title,
                    ScdeduleId = scheduleId,
                    Description = description,
                    Deadline = deadline
                };

                _context.Assignments.Add(assignment);
                _context.SaveChanges();

                MessageBox.Show("Задание успешно добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAssignmentTitle.Clear();
                txtAssignmentDescription.Clear();
                dtpAssignmentDeadline.Value = DateTime.Now.AddDays(7);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении задания: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
