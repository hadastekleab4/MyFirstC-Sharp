
namespace C_sharpconectwithDatabase
{
    partial class Form1
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
            this.BtnStudent = new System.Windows.Forms.Button();
            this.BtnGrade = new System.Windows.Forms.Button();
            this.BtnCourse = new System.Windows.Forms.Button();
            this.BtnDepartment = new System.Windows.Forms.Button();
            this.BtnFaculty = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CMBDepartment = new System.Windows.Forms.ComboBox();
            this.BtnSerchByName = new System.Windows.Forms.Button();
            this.BtnSerchByDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStudent
            // 
            this.BtnStudent.Location = new System.Drawing.Point(36, 40);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Size = new System.Drawing.Size(261, 78);
            this.BtnStudent.TabIndex = 0;
            this.BtnStudent.Text = "Get All Student";
            this.BtnStudent.UseVisualStyleBackColor = true;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // BtnGrade
            // 
            this.BtnGrade.Location = new System.Drawing.Point(1310, 40);
            this.BtnGrade.Name = "BtnGrade";
            this.BtnGrade.Size = new System.Drawing.Size(261, 78);
            this.BtnGrade.TabIndex = 1;
            this.BtnGrade.Text = "Get All Grade";
            this.BtnGrade.UseVisualStyleBackColor = true;
            // 
            // BtnCourse
            // 
            this.BtnCourse.Location = new System.Drawing.Point(980, 40);
            this.BtnCourse.Name = "BtnCourse";
            this.BtnCourse.Size = new System.Drawing.Size(261, 78);
            this.BtnCourse.TabIndex = 2;
            this.BtnCourse.Text = "Get All Courses";
            this.BtnCourse.UseVisualStyleBackColor = true;
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.Location = new System.Drawing.Point(659, 40);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.Size = new System.Drawing.Size(261, 78);
            this.BtnDepartment.TabIndex = 3;
            this.BtnDepartment.Text = "Get All Department";
            this.BtnDepartment.UseVisualStyleBackColor = true;
            this.BtnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // BtnFaculty
            // 
            this.BtnFaculty.Location = new System.Drawing.Point(336, 40);
            this.BtnFaculty.Name = "BtnFaculty";
            this.BtnFaculty.Size = new System.Drawing.Size(261, 78);
            this.BtnFaculty.TabIndex = 4;
            this.BtnFaculty.Text = "Get All Faculty";
            this.BtnFaculty.UseVisualStyleBackColor = true;
            this.BtnFaculty.Click += new System.EventHandler(this.BtnFaculty_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(61, 303);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1418, 476);
            this.dataGridView.TabIndex = 5;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(61, 147);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(790, 47);
            this.TxtName.TabIndex = 6;
            // 
            // CMBDepartment
            // 
            this.CMBDepartment.FormattingEnabled = true;
            this.CMBDepartment.Location = new System.Drawing.Point(61, 216);
            this.CMBDepartment.Name = "CMBDepartment";
            this.CMBDepartment.Size = new System.Drawing.Size(790, 33);
            this.CMBDepartment.TabIndex = 7;
            // 
            // BtnSerchByName
            // 
            this.BtnSerchByName.Location = new System.Drawing.Point(1051, 131);
            this.BtnSerchByName.Name = "BtnSerchByName";
            this.BtnSerchByName.Size = new System.Drawing.Size(479, 63);
            this.BtnSerchByName.TabIndex = 8;
            this.BtnSerchByName.Text = "Serch By Name";
            this.BtnSerchByName.UseVisualStyleBackColor = true;
            this.BtnSerchByName.Click += new System.EventHandler(this.BtnSerchByName_Click);
            // 
            // BtnSerchByDepartment
            // 
            this.BtnSerchByDepartment.Location = new System.Drawing.Point(1051, 216);
            this.BtnSerchByDepartment.Name = "BtnSerchByDepartment";
            this.BtnSerchByDepartment.Size = new System.Drawing.Size(479, 65);
            this.BtnSerchByDepartment.TabIndex = 9;
            this.BtnSerchByDepartment.Text = "Serch By Department";
            this.BtnSerchByDepartment.UseVisualStyleBackColor = true;
            this.BtnSerchByDepartment.Click += new System.EventHandler(this.BtnSerchByDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 813);
            this.Controls.Add(this.BtnSerchByDepartment);
            this.Controls.Add(this.BtnSerchByName);
            this.Controls.Add(this.CMBDepartment);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BtnFaculty);
            this.Controls.Add(this.BtnDepartment);
            this.Controls.Add(this.BtnCourse);
            this.Controls.Add(this.BtnGrade);
            this.Controls.Add(this.BtnStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStudent;
        private System.Windows.Forms.Button BtnGrade;
        private System.Windows.Forms.Button BtnCourse;
        private System.Windows.Forms.Button BtnDepartment;
        private System.Windows.Forms.Button BtnFaculty;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CMBDepartment;
        private System.Windows.Forms.Button BtnSerchByName;
        private System.Windows.Forms.Button BtnSerchByDepartment;
    }
}

