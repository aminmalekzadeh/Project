using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class RegisterForm : MaterialSkin.Controls.MaterialForm
    {
        class coursemodel 
        {
          public  int id;
            public string coursename;
        }
        class Majormodel
        {
            public int id;
            public string Title;
        }
        List<coursemodel> courselist = new List<coursemodel>();
        List<Majormodel> majorlist = new List<Majormodel>();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");
        public RegisterForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange500, Primary.Orange900, Primary.Green900, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton1.Font = new Font("IRANSans", 20, FontStyle.Bold);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            LoadCourse();
            LoadMajor();
            
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
                    n.coursename =  (string)reader["NameCourse"];
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


        public void LoadMajor()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            con.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from Major";
            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Majormodel n = new Majormodel();
                    n.id = (int)reader["ID"];
                    n.Title = (string)reader["Title"];
                    majorlist.Add(n);
                    comboBox2.Items.Add(reader["Title"]);


                }
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            con.Close();
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtphonenumber.Text != "" && txtinternationalcode.Text !="" && txtfamilyname.Text != "" &&
                txtage.Text != "" && (!radiobtnmale.Checked || !radiobtnfamel.Checked) && (!radiobtnstudent.Checked || !radiobtnteacher.Checked))
            {

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = con;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "INSERT INTO Person(Name,Lastname,age,internationalcode,phonenumber,sex) OUTPUT inserted.ID values(@Name,@Lastname,@age,@internationalcode,@phonenumber,@sex)";
                sqlcmd.Parameters.AddWithValue("@Name", txtname.Text);
                sqlcmd.Parameters.AddWithValue("@Lastname", txtfamilyname.Text);
                sqlcmd.Parameters.AddWithValue("@age", txtage.Text);
                sqlcmd.Parameters.AddWithValue("@internationalcode", txtinternationalcode.Text);
                sqlcmd.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text);
                if (radiobtnmale.Checked)
                    sqlcmd.Parameters.AddWithValue("@sex", "Male");
                else
                    sqlcmd.Parameters.AddWithValue("@sex", "Female");
                




                try
                {
                    con.Open();
                    int id = (int)sqlcmd.ExecuteScalar();
                   
                    
                    if (radiobtnstudent.Checked)
                    {

                        sqlcmd.CommandText = "INSERT INTO Student(person_id,major_id) VALUES(@person_id,@major_id);";
                        sqlcmd.Parameters.AddWithValue("@person_id", "" + id);
                        sqlcmd.Parameters.AddWithValue("@major_id", "" + majorlist[comboBox2.SelectedIndex].id);
                        sqlcmd.ExecuteNonQuery();

                    }

                    else if (radiobtnteacher.Checked)
                    {
                        sqlcmd.CommandText = "INSERT INTO Teacher(person_id)OUTPUT inserted.ID VALUES(@id)";
                        sqlcmd.Parameters.AddWithValue("@id", "" + id);
                    
                        int id1 = (int)sqlcmd.ExecuteScalar();
                        sqlcmd.CommandText = "INSERT INTO tch_cr(teacher_id,Course_id) VALUES(@teacher_id,@Course_id)";
                        sqlcmd.Parameters.AddWithValue("@teacher_id", "" + id1);
                        sqlcmd.Parameters.AddWithValue("@Course_id", "" + courselist[comboBox1.SelectedIndex].id);
                        sqlcmd.ExecuteNonQuery();


                    }





                    MessageBox.Show("Data Saved!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                con.Close();
            }
            else
            {
                MessageBox.Show("اطلاعات را کامل وارد کنید");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnteacher_Click(object sender, EventArgs e)
        {

        }

        private void radiobtnteacher_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void radiobtnstudent_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
