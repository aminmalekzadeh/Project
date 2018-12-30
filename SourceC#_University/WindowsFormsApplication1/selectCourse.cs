using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class selectCourseForm : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");
        List<coursemodel> courselist = new List<coursemodel>();
       public int student_id;
       public string studentname;
        public selectCourseForm()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = con;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "INSERT INTO st_cr(student_id,course_id) VALUES(@student_id,@course_id)";
                sqlcmd.Parameters.AddWithValue("@student_id", "" + student_id);
                sqlcmd.Parameters.AddWithValue("@course_id", "" + courselist[comboBox1.SelectedIndex].id);
                sqlcmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }
                   
        }

        private void Form9_Load(object sender, EventArgs e)
        {
           // selectCourseForm f = new selectCourseForm();
           
            LoadCourse();

        }
        public void LoadCourse()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            con.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from Course";
            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    coursemodel n = new coursemodel();
                    n.id = (int)reader["ID"];
                    n.coursename = (string)reader["NameCourse"];
                    courselist.Add(n);
                    comboBox1.Items.Add(reader["NameCourse"]);


                }
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            con.Close();

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
