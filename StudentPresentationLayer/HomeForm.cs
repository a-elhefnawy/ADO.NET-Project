using StudentBussinessLayer;
using System.Data;

namespace StudentPresentationLayer
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            List<Student> students = StudentCmd.GetAll();
            dgv_student.DataSource = students;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Id = int.Parse(txt_id.Text),
                St_Fname = txt_fname.Text,
                St_Lname = txt_lname.Text,
                St_Address = txt_address.Text,
            };
            int result = StudentCmd.insert(student);

            if (result > 0)
            {
                MessageBox.Show("Data Added");
                List<Student> students = StudentCmd.GetAll();
                dgv_student.DataSource = students;
            }
        }

        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_student.Rows[e.RowIndex];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_fname.Text = row.Cells[1].Value.ToString();
            txt_lname.Text = row.Cells[2].Value.ToString();
            txt_address.Text = row.Cells[3].Value.ToString();
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_add.Enabled = false;
            txt_id.ReadOnly=true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Id = int.Parse(txt_id.Text),
                St_Fname = txt_fname.Text,
                St_Lname = txt_lname.Text,
                St_Address = txt_address.Text,
            };
            int result = StudentCmd.update(student);

            if (result > 0)
            {
                MessageBox.Show("Data Edited");
                List<Student> students = StudentCmd.GetAll();
                dgv_student.DataSource = students;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int Id=int.Parse(txt_id.Text);
            int result=StudentCmd.delete(Id);
            if (result > 0)
            {
                MessageBox.Show("Data DELETED");
                List<Student> students = StudentCmd.GetAll();
                dgv_student.DataSource = students;
            }

        }
    }
}