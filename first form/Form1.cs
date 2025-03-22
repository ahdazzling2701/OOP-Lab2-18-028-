namespace first_form
{
    public partial class Form1 : Form
    {
        public static string Student_Name = " ";
        public static string Roll_ = " ";
        public static string Reg_Id = " ";
        public static string Semester_ = " ";
        public static string Blood_Group_ = " ";
        public static string Gender_ = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string roll = txtRoll.Text;
            int reg = int.Parse(txtId.Text);
            string semester = txtSemester.Text;
            string blood = txtBlood.Text;

            Student_Name = txtName.Text;
            Roll_ = txtRoll.Text;
            Reg_Id = txtId.Text;
            Semester_ = txtSemester.Text;
            Blood_Group_ = txtBlood.Text;
            Gender_ = rbtnmale.Text;
            string gender;
            if (rbtnmale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "images only . | *.jpg;*.jpeg;*png;*.gif;";
            DialogResult dr = openfd.ShowDialog();
            imagePictureBox.Image = Image.FromFile(openfd.FileName);
            imagepathlabel1.Text = openfd.FileName;
            MessageBox.Show(" , your name is : " + name + " , your roll is : " + roll + " , reg is :" + reg + " , semester:" + semester + ",blood group :" + blood + ", gender : " + gender);

            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void imagepathlabel1_Click(object sender, EventArgs e)
        {

        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
