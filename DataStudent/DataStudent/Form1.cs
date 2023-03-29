using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DataStudent
{
    public partial class DataStudent : Form
    {
        List<StudentAll> studentAlls = new List<StudentAll>();
        List<double> allgrade = new List<double>();
        int Allstd = 0;
        public DataStudent()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, EventArgs e)
        {

            string name = Namebox.Text;
            string id = IDbox.Text;
            string birth = Birthbox.Text;
            string hight = Hightbox.Text;
            string grade = Gradebox.Text;
            string branch = Branchbox.Text;

            Allstd = Allstd + 1;

            float iGrades = Int32.Parse(grade);
            int iage = Int32.Parse(birth);
            int Ages = 2023 - iage;
            allgrade.Add(iGrades);
            allgrade.Sort();
            this.MaxGrade.Text = allgrade.First().ToString();
            this.MinGrade.Text = allgrade.Last().ToString();

            dataGridView1.Rows.Add(name, id, Ages,hight,iGrades, branch);

            this.Namebox.Text = "";
            this.IDbox.Text = "";
            this.Birthbox.Text = "";
            this.Hightbox.Text = "";
            this.Gradebox.Text = "";
            this.Branchbox.Text = "";

            Allstudent.Text = Allstd.ToString();

        }

        private void Gradebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataStudent_Load(object sender, EventArgs e)
        {

        }

        private void Hightbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}