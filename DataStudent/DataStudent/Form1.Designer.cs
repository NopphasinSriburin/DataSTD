namespace DataStudent
{
    partial class DataStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Save = new Button();
            Namebox = new TextBox();
            IDbox = new TextBox();
            Birthbox = new TextBox();
            Hightbox = new TextBox();
            Gradebox = new TextBox();
            Branchbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MaxGrade = new TextBox();
            MinGrade = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            NameData = new DataGridViewTextBoxColumn();
            IDdata = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Hightdata = new DataGridViewTextBoxColumn();
            Gradedata = new DataGridViewTextBoxColumn();
            Branchdata = new DataGridViewTextBoxColumn();
            Allstudent = new TextBox();
            Student = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new Point(225, 304);
            Save.Name = "Save";
            Save.Size = new Size(124, 38);
            Save.TabIndex = 0;
            Save.Text = "บันทึก";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Namebox
            // 
            Namebox.Location = new Point(190, 40);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(196, 27);
            Namebox.TabIndex = 1;
            // 
            // IDbox
            // 
            IDbox.Location = new Point(190, 85);
            IDbox.Name = "IDbox";
            IDbox.Size = new Size(196, 27);
            IDbox.TabIndex = 2;
            // 
            // Birthbox
            // 
            Birthbox.Location = new Point(190, 130);
            Birthbox.Name = "Birthbox";
            Birthbox.Size = new Size(196, 27);
            Birthbox.TabIndex = 3;
            // 
            // Hightbox
            // 
            Hightbox.Location = new Point(190, 177);
            Hightbox.Name = "Hightbox";
            Hightbox.Size = new Size(196, 27);
            Hightbox.TabIndex = 5;
            Hightbox.TextChanged += Hightbox_TextChanged;
            // 
            // Gradebox
            // 
            Gradebox.Location = new Point(190, 220);
            Gradebox.Name = "Gradebox";
            Gradebox.Size = new Size(196, 27);
            Gradebox.TabIndex = 6;
            Gradebox.TextChanged += Gradebox_TextChanged;
            // 
            // Branchbox
            // 
            Branchbox.Location = new Point(190, 262);
            Branchbox.Name = "Branchbox";
            Branchbox.Size = new Size(196, 27);
            Branchbox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 43);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 8;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 88);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 9;
            label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 137);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "ปีเกิด ค.ศ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 184);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "ส่วนสูง";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 227);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 13;
            label6.Text = "เกรด";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 269);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 14;
            label7.Text = "สาขา";
            // 
            // MaxGrade
            // 
            MaxGrade.Location = new Point(507, 336);
            MaxGrade.Name = "MaxGrade";
            MaxGrade.Size = new Size(164, 27);
            MaxGrade.TabIndex = 16;
            // 
            // MinGrade
            // 
            MinGrade.Location = new Point(773, 336);
            MinGrade.Name = "MinGrade";
            MinGrade.Size = new Size(164, 27);
            MinGrade.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 339);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 19;
            label8.Text = "Max Grade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(689, 339);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 20;
            label9.Text = "Min Grade";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameData, IDdata, Age, Hightdata, Gradedata, Branchdata });
            dataGridView1.Location = new Point(420, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(801, 287);
            dataGridView1.TabIndex = 21;
            // 
            // NameData
            // 
            NameData.HeaderText = "Name";
            NameData.MinimumWidth = 6;
            NameData.Name = "NameData";
            NameData.Width = 125;
            // 
            // IDdata
            // 
            IDdata.HeaderText = "ID";
            IDdata.MinimumWidth = 6;
            IDdata.Name = "IDdata";
            IDdata.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // Hightdata
            // 
            Hightdata.HeaderText = "Hight";
            Hightdata.MinimumWidth = 6;
            Hightdata.Name = "Hightdata";
            Hightdata.Width = 125;
            // 
            // Gradedata
            // 
            Gradedata.HeaderText = "Grade";
            Gradedata.MinimumWidth = 6;
            Gradedata.Name = "Gradedata";
            Gradedata.Width = 125;
            // 
            // Branchdata
            // 
            Branchdata.HeaderText = "Branch";
            Branchdata.MinimumWidth = 6;
            Branchdata.Name = "Branchdata";
            Branchdata.Width = 125;
            // 
            // Allstudent
            // 
            Allstudent.Location = new Point(1026, 336);
            Allstudent.Name = "Allstudent";
            Allstudent.Size = new Size(185, 27);
            Allstudent.TabIndex = 22;
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.Location = new Point(960, 339);
            Student.Name = "Student";
            Student.Size = new Size(60, 20);
            Student.TabIndex = 23;
            Student.Text = "Student";
            // 
            // DataStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 410);
            Controls.Add(Student);
            Controls.Add(Allstudent);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(MinGrade);
            Controls.Add(MaxGrade);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Branchbox);
            Controls.Add(Gradebox);
            Controls.Add(Hightbox);
            Controls.Add(Birthbox);
            Controls.Add(IDbox);
            Controls.Add(Namebox);
            Controls.Add(Save);
            Name = "DataStudent";
            Text = "Data";
            Load += DataStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save;
        private TextBox Namebox;
        private TextBox IDbox;
        private TextBox Birthbox;
        private TextBox Hightbox;
        private TextBox Gradebox;
        private TextBox Branchbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox MaxGrade;
        private TextBox MinGrade;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private TextBox Allstudent;
        private Label Student;
        private DataGridViewTextBoxColumn NameData;
        private DataGridViewTextBoxColumn IDdata;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Hightdata;
        private DataGridViewTextBoxColumn Gradedata;
        private DataGridViewTextBoxColumn Branchdata;
    }
}