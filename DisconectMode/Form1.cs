using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DisconectMode
{
    public partial class Form1 : Form
    {
        SqlConnection Conn;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ConnectionString);
            adapter = new SqlDataAdapter();
            dt = new DataTable();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select St_Id,St_Fname,St_Lname,St_Address from Student", Conn);
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);

            dgv_student.DataSource = dt;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr[0] = txt_id.Text;
            dr[1] = txt_fname.Text;
            dr[2] = txt_laname.Text;
            dr[3] = txt_address.Text;
            dt.Rows.Add(dr);
            MessageBox.Show("Data Added");
        }
        int rowIndex = 0;
        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            txt_id.Text = dt.Rows[rowIndex][0].ToString();
            txt_fname.Text = dt.Rows[rowIndex][1].ToString();
            txt_laname.Text = dt.Rows[rowIndex][2].ToString();
            txt_address.Text = dt.Rows[rowIndex][3].ToString();
            btn_add.Enabled = false;
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            txt_id.ReadOnly = true;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dt.Rows[rowIndex][0] = txt_id.Text;
            dt.Rows[rowIndex][1] = txt_fname.Text;
            dt.Rows[rowIndex][2] = txt_laname.Text;
            dt.Rows[rowIndex][3] = txt_address.Text;
            MessageBox.Show("Data Edited");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            dt.Rows[rowIndex].Delete();
            MessageBox.Show("Data Deleted");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand insertcmd = new SqlCommand("insert into [dbo].[Student]([St_Id],[St_Fname],[St_Lname],[St_Address]) values(@id,@fname,@lname,@address)", Conn);
            insertcmd.Parameters.Add("@id", SqlDbType.Int,10,"St_Id");
            insertcmd.Parameters.Add("@fname", SqlDbType.VarChar, 20, "St_Fname");
            insertcmd.Parameters.Add("@lname", SqlDbType.VarChar, 20, "St_Lname");
            insertcmd.Parameters.Add("@address", SqlDbType.VarChar, 100, "St_Address");

            SqlCommand updatecmd = new SqlCommand("update [dbo].[Student] set [St_Fname] = @fname, [St_Lname] = @lname,[St_Address] = @address where [St_Id] = @id", Conn);
            updatecmd.Parameters.Add("@id", SqlDbType.Int, 10, "St_Id");
            updatecmd.Parameters.Add("@fname", SqlDbType.VarChar, 20, "St_Fname");
            updatecmd.Parameters.Add("@lname", SqlDbType.VarChar, 20, "St_Lname");
            updatecmd.Parameters.Add("@address", SqlDbType.VarChar, 100, "St_Address");

            SqlCommand deletecmd = new SqlCommand("delete from [dbo].[Student] where [St_Id] = @id", Conn);
            deletecmd.Parameters.Add("@id", SqlDbType.Int, 10, "St_Id");

            adapter.InsertCommand = insertcmd;
            adapter.UpdateCommand = updatecmd;
            adapter.DeleteCommand = deletecmd;
            adapter.Update(dt);
            Form1_Load(null, null);

        }
    }
}