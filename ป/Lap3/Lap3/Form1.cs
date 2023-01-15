namespace Lap3
{
    public partial class Form1 : Form
    {
        List<Student>StudentList = new List<Student>();
        List<double> GradeList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.textBox1.Text;
                string studentid = this.textBox2.Text;
                string birthyear = this.textBox3.Text;
                string hight = this.textBox4.Text;
                double grade = double.Parse(this.textBox5.Text);
                string branch = this.textBox6.Text;

                Student student = new Student(name, studentid, birthyear, hight, grade, branch);

                StudentList.Add(student);
                BindingSource source = new BindingSource();
                source.DataSource = StudentList;
                this.dataGridView1.DataSource = source;

                foreach (var val in StudentList)
                {
                    this.GradeList.Add(val.Grade);
                }
                double Maxgrade = GradeList.Max();
                double Mingrade = GradeList.Min();

                int allStudent = StudentList.Count();

                this.label7.Text = allStudent.ToString();
                this.label8.Text = Maxgrade.ToString();
                this.label9.Text = Mingrade.ToString();
            }
            catch
            {
                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}