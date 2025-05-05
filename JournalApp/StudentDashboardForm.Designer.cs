namespace JournalApp
{
    partial class StudentDashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.tabAssignments = new System.Windows.Forms.TabPage();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.lblSubmission = new System.Windows.Forms.Label();
            this.txtSubmission = new System.Windows.Forms.TextBox();
            this.btnSubmitAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabAssignments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tabAssignments);
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
            // tabAssignments
            // 
            this.tabAssignments.Controls.Add(this.btnSubmitAssignment);
            this.tabAssignments.Controls.Add(this.txtSubmission);
            this.tabAssignments.Controls.Add(this.lblSubmission);
            this.tabAssignments.Controls.Add(this.dgvAssignments);
            this.tabAssignments.Location = new System.Drawing.Point(4, 22);
            this.tabAssignments.Name = "tabAssignments";
            this.tabAssignments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignments.Size = new System.Drawing.Size(752, 374);
            this.tabAssignments.Text = "Домашние задания";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(6, 6);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(740, 362);
            this.dgvSchedule.ReadOnly = true;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Location = new System.Drawing.Point(6, 6);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.Size = new System.Drawing.Size(740, 200);
            this.dgvAssignments.ReadOnly = true;
            // 
            // lblSubmission
            // 
            this.lblSubmission.AutoSize = true;
            this.lblSubmission.Location = new System.Drawing.Point(6, 210);
            this.lblSubmission.Name = "lblSubmission";
            this.lblSubmission.Size = new System.Drawing.Size(45, 13);
            this.lblSubmission.Text = "Ответ:";
            // 
            // txtSubmission
            // 
            this.txtSubmission.Location = new System.Drawing.Point(6, 226);
            this.txtSubmission.Multiline = true;
            this.txtSubmission.Name = "txtSubmission";
            this.txtSubmission.Size = new System.Drawing.Size(740, 100);
            // 
            // btnSubmitAssignment
            // 
            this.btnSubmitAssignment.Location = new System.Drawing.Point(650, 330);
            this.btnSubmitAssignment.Name = "btnSubmitAssignment";
            this.btnSubmitAssignment.Size = new System.Drawing.Size(96, 23);
            this.btnSubmitAssignment.Text = "Сдать задание";
            this.btnSubmitAssignment.Click += new System.EventHandler(this.btnSubmitAssignment_Click);
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 424);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentDashboardForm";
            this.Text = "Панель студента";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabAssignments.ResumeLayout(false);
            this.tabAssignments.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabAssignments;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Label lblSubmission;
        private System.Windows.Forms.TextBox txtSubmission;
        private System.Windows.Forms.Button btnSubmitAssignment;
   

        #endregion
    }
}