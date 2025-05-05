namespace JournalApp
{
    partial class TeacherDashboardForm
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

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.tabAddLesson = new System.Windows.Forms.TabPage();
            this.tabAddSubject = new System.Windows.Forms.TabPage();
            this.tabAddAssignment = new System.Windows.Forms.TabPage();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblSpecialSubject = new System.Windows.Forms.Label();
            this.cmbSpecialSubject = new System.Windows.Forms.ComboBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.lblSubjectTitle = new System.Windows.Forms.Label();
            this.txtSubjectTitle = new System.Windows.Forms.TextBox();
            this.lblHourAll = new System.Windows.Forms.Label();
            this.nudHourAll = new System.Windows.Forms.NumericUpDown();
            this.lblSubjectEnding = new System.Windows.Forms.Label();
            this.dtpSubjectEnding = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.lblAssignmentSchedule = new System.Windows.Forms.Label();
            this.cmbAssignmentSchedule = new System.Windows.Forms.ComboBox();
            this.lblAssignmentTitle = new System.Windows.Forms.Label();
            this.txtAssignmentTitle = new System.Windows.Forms.TextBox();
            this.lblAssignmentDescription = new System.Windows.Forms.Label();
            this.txtAssignmentDescription = new System.Windows.Forms.TextBox();
            this.lblAssignmentDeadline = new System.Windows.Forms.Label();
            this.dtpAssignmentDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourAll)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabAddLesson.SuspendLayout();
            this.tabAddSubject.SuspendLayout();
            this.tabAddAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tabAddLesson);
            this.tabControl.Controls.Add(this.tabAddSubject);
            this.tabControl.Controls.Add(this.tabAddAssignment);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 400);
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.dgvSchedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(752, 374);
            this.tabSchedule.Text = "Расписание";
            // 
            // tabAddLesson
            // 
            this.tabAddLesson.Controls.Add(this.btnAddLesson);
            this.tabAddLesson.Controls.Add(this.dtpTimeEnd);
            this.tabAddLesson.Controls.Add(this.lblTimeEnd);
            this.tabAddLesson.Controls.Add(this.dtpTimeStart);
            this.tabAddLesson.Controls.Add(this.lblTimeStart);
            this.tabAddLesson.Controls.Add(this.cmbSpecialSubject);
            this.tabAddLesson.Controls.Add(this.lblSpecialSubject);
            this.tabAddLesson.Controls.Add(this.cmbClass);
            this.tabAddLesson.Controls.Add(this.lblClass);
            this.tabAddLesson.Controls.Add(this.cmbGroup);
            this.tabAddLesson.Controls.Add(this.lblGroup);
            this.tabAddLesson.Location = new System.Drawing.Point(4, 22);
            this.tabAddLesson.Name = "tabAddLesson";
            this.tabAddLesson.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddLesson.Size = new System.Drawing.Size(752, 374);
            this.tabAddLesson.Text = "Добавить урок";
            // 
            // tabAddSubject
            // 
            this.tabAddSubject.Controls.Add(this.btnAddSubject);
            this.tabAddSubject.Controls.Add(this.txtPeriod);
            this.tabAddSubject.Controls.Add(this.lblPeriod);
            this.tabAddSubject.Controls.Add(this.dtpSubjectEnding);
            this.tabAddSubject.Controls.Add(this.lblSubjectEnding);
            this.tabAddSubject.Controls.Add(this.nudHourAll);
            this.tabAddSubject.Controls.Add(this.lblHourAll);
            this.tabAddSubject.Controls.Add(this.txtSubjectTitle);
            this.tabAddSubject.Controls.Add(this.lblSubjectTitle);
            this.tabAddSubject.Location = new System.Drawing.Point(4, 22);
            this.tabAddSubject.Name = "tabAddSubject";
            this.tabAddSubject.Size = new System.Drawing.Size(752, 374);
            this.tabAddSubject.Text = "Добавить предмет";
            // 
            // tabAddAssignment
            // 
            this.tabAddAssignment.Controls.Add(this.btnAddAssignment);
            this.tabAddAssignment.Controls.Add(this.dtpAssignmentDeadline);
            this.tabAddAssignment.Controls.Add(this.lblAssignmentDeadline);
            this.tabAddAssignment.Controls.Add(this.txtAssignmentDescription);
            this.tabAddAssignment.Controls.Add(this.lblAssignmentDescription);
            this.tabAddAssignment.Controls.Add(this.txtAssignmentTitle);
            this.tabAddAssignment.Controls.Add(this.lblAssignmentTitle);
            this.tabAddAssignment.Controls.Add(this.cmbAssignmentSchedule);
            this.tabAddAssignment.Controls.Add(this.lblAssignmentSchedule);
            this.tabAddAssignment.Location = new System.Drawing.Point(4, 22);
            this.tabAddAssignment.Name = "tabAddAssignment";
            this.tabAddAssignment.Size = new System.Drawing.Size(752, 374);
            this.tabAddAssignment.Text = "Добавить задание";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(6, 6);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(740, 362);
            this.dgvSchedule.ReadOnly = true;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(30, 30);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 13);
            this.lblGroup.Text = "Группа:";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(120, 27);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 21);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(30, 60);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(62, 13);
            this.lblClass.Text = "Аудитория:";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(120, 57);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(200, 21);
            // 
            // lblSpecialSubject
            // 
            this.lblSpecialSubject.AutoSize = true;
            this.lblSpecialSubject.Location = new System.Drawing.Point(30, 90);
            this.lblSpecialSubject.Name = "lblSpecialSubject";
            this.lblSpecialSubject.Size = new System.Drawing.Size(54, 13);
            this.lblSpecialSubject.Text = "Предмет:";
            // 
            // cmbSpecialSubject
            // 
            this.cmbSpecialSubject.FormattingEnabled = true;
            this.cmbSpecialSubject.Location = new System.Drawing.Point(120, 87);
            this.cmbSpecialSubject.Name = "cmbSpecialSubject";
            this.cmbSpecialSubject.Size = new System.Drawing.Size(200, 21);
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(30, 120);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(50, 13);
            this.lblTimeStart.Text = "Начало:";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeStart.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpTimeStart.Location = new System.Drawing.Point(120, 117);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(200, 20);
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(30, 150);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(46, 13);
            this.lblTimeEnd.Text = "Конец:";
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpTimeEnd.Location = new System.Drawing.Point(120, 147);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(200, 20);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(120, 190);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(120, 23);
            this.btnAddLesson.Text = "Добавить урок";
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // lblSubjectTitle
            // 
            this.lblSubjectTitle.AutoSize = true;
            this.lblSubjectTitle.Location = new System.Drawing.Point(30, 30);
            this.lblSubjectTitle.Name = "lblSubjectTitle";
            this.lblSubjectTitle.Size = new System.Drawing.Size(62, 13);
            this.lblSubjectTitle.Text = "Название:";
            // 
            // txtSubjectTitle
            // 
            this.txtSubjectTitle.Location = new System.Drawing.Point(120, 27);
            this.txtSubjectTitle.Name = "txtSubjectTitle";
            this.txtSubjectTitle.Size = new System.Drawing.Size(200, 20);
            // 
            // lblHourAll
            // 
            this.lblHourAll.AutoSize = true;
            this.lblHourAll.Location = new System.Drawing.Point(30, 60);
            this.lblHourAll.Name = "lblHourAll";
            this.lblHourAll.Size = new System.Drawing.Size(41, 13);
            this.lblHourAll.Text = "Часы:";
            // 
            // nudHourAll
            // 
            this.nudHourAll.Location = new System.Drawing.Point(120, 57);
            this.nudHourAll.Name = "nudHourAll";
            this.nudHourAll.Size = new System.Drawing.Size(100, 20);
            // 
            // lblSubjectEnding
            // 
            this.lblSubjectEnding.AutoSize = true;
            this.lblSubjectEnding.Location = new System.Drawing.Point(30, 90);
            this.lblSubjectEnding.Name = "lblSubjectEnding";
            this.lblSubjectEnding.Size = new System.Drawing.Size(68, 13);
            this.lblSubjectEnding.Text = "Окончание:";
            // 
            // dtpSubjectEnding
            // 
            this.dtpSubjectEnding.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubjectEnding.Location = new System.Drawing.Point(120, 87);
            this.dtpSubjectEnding.Name = "dtpSubjectEnding";
            this.dtpSubjectEnding.Size = new System.Drawing.Size(200, 20);
            this.dtpSubjectEnding.ShowCheckBox = true;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(30, 120);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(50, 13);
            this.lblPeriod.Text = "Период:";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(120, 117);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(200, 20);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(120, 160);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(120, 23);
            this.btnAddSubject.Text = "Добавить предмет";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lblAssignmentSchedule
            // 
            this.lblAssignmentSchedule.AutoSize = true;
            this.lblAssignmentSchedule.Location = new System.Drawing.Point(30, 30);
            this.lblAssignmentSchedule.Name = "lblAssignmentSchedule";
            this.lblAssignmentSchedule.Size = new System.Drawing.Size(41, 13);
            this.lblAssignmentSchedule.Text = "Урок:";
            // 
            // cmbAssignmentSchedule
            // 
            this.cmbAssignmentSchedule.FormattingEnabled = true;
            this.cmbAssignmentSchedule.Location = new System.Drawing.Point(120, 27);
            this.cmbAssignmentSchedule.Name = "cmbAssignmentSchedule";
            this.cmbAssignmentSchedule.Size = new System.Drawing.Size(300, 21);
            // 
            // lblAssignmentTitle
            // 
            this.lblAssignmentTitle.AutoSize = true;
            this.lblAssignmentTitle.Location = new System.Drawing.Point(30, 60);
            this.lblAssignmentTitle.Name = "lblAssignmentTitle";
            this.lblAssignmentTitle.Size = new System.Drawing.Size(62, 13);
            this.lblAssignmentTitle.Text = "Название:";
            // 
            // txtAssignmentTitle
            // 
            this.txtAssignmentTitle.Location = new System.Drawing.Point(120, 57);
            this.txtAssignmentTitle.Name = "txtAssignmentTitle";
            this.txtAssignmentTitle.Size = new System.Drawing.Size(300, 20);
            // 
            // lblAssignmentDescription
            // 
            this.lblAssignmentDescription.AutoSize = true;
            this.lblAssignmentDescription.Location = new System.Drawing.Point(30, 90);
            this.lblAssignmentDescription.Name = "lblAssignmentDescription";
            this.lblAssignmentDescription.Size = new System.Drawing.Size(60, 13);
            this.lblAssignmentDescription.Text = "Описание:";
            // 
            // txtAssignmentDescription
            // 
            this.txtAssignmentDescription.Location = new System.Drawing.Point(120, 87);
            this.txtAssignmentDescription.Multiline = true;
            this.txtAssignmentDescription.Name = "txtAssignmentDescription";
            this.txtAssignmentDescription.Size = new System.Drawing.Size(300, 100);
            // 
            // lblAssignmentDeadline
            // 
            this.lblAssignmentDeadline.AutoSize = true;
            this.lblAssignmentDeadline.Location = new System.Drawing.Point(30, 190);
            this.lblAssignmentDeadline.Name = "lblAssignmentDeadline";
            this.lblAssignmentDeadline.Size = new System.Drawing.Size(42, 13);
            this.lblAssignmentDeadline.Text = "Срок:";
            // 
            // dtpAssignmentDeadline
            // 
            this.dtpAssignmentDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAssignmentDeadline.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpAssignmentDeadline.Location = new System.Drawing.Point(120, 187);
            this.dtpAssignmentDeadline.Name = "dtpAssignmentDeadline";
            this.dtpAssignmentDeadline.Size = new System.Drawing.Size(200, 20);
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Location = new System.Drawing.Point(120, 220);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(120, 23);
            this.btnAddAssignment.Text = "Добавить задание";
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // TeacherDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 424);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeacherDashboardForm";
            this.Text = "Панель преподавателя";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourAll)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabAddLesson.ResumeLayout(false);
            this.tabAddLesson.PerformLayout();
            this.tabAddSubject.ResumeLayout(false);
            this.tabAddSubject.PerformLayout();
            this.tabAddAssignment.ResumeLayout(false);
            this.tabAddAssignment.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabAddLesson;
        private System.Windows.Forms.TabPage tabAddSubject;
        private System.Windows.Forms.TabPage tabAddAssignment;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblSpecialSubject;
        private System.Windows.Forms.ComboBox cmbSpecialSubject;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Label lblSubjectTitle;
        private System.Windows.Forms.TextBox txtSubjectTitle;
        private System.Windows.Forms.Label lblHourAll;
        private System.Windows.Forms.NumericUpDown nudHourAll;
        private System.Windows.Forms.Label lblSubjectEnding;
        private System.Windows.Forms.DateTimePicker dtpSubjectEnding;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label lblAssignmentSchedule;
        private System.Windows.Forms.ComboBox cmbAssignmentSchedule;
        private System.Windows.Forms.Label lblAssignmentTitle;
        private System.Windows.Forms.TextBox txtAssignmentTitle;
        private System.Windows.Forms.Label lblAssignmentDescription;
        private System.Windows.Forms.TextBox txtAssignmentDescription;
        private System.Windows.Forms.Label lblAssignmentDeadline;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDeadline;
        private System.Windows.Forms.Button btnAddAssignment;
    }
}