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
using System.Configuration;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Data : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");

        public Data()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange500, Primary.Orange900, Primary.Green900, Accent.Red400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            materialListView1.Items.Clear();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
           // sqlcmd.CommandText = "SELECT * From Person inner join Student on Person.id = Student.person_id inner join Major on Student.major_id = Major.id";
            sqlcmd.CommandText = "SELECT Person.ID,Person.Name,Person.Lastname,Person.internationalcode,Person.age,Person.phonenumber,Person.sex ,Student.ID AS st_id,Student.major_id,Student.person_id,Major.ID,Major.Title from Person inner join Student on Person.id = Student.person_id inner join Major on Student.major_id = Major.id";

            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;
                arr[0] = ((int)dtRecord.Rows[i]["st_id"]).ToString();
                arr[1] = (string)dtRecord.Rows[i]["Name"];
                arr[2] = (string)dtRecord.Rows[i]["Lastname"];
                arr[3] = ((int)dtRecord.Rows[i]["age"]).ToString();
                arr[4] = ((string)dtRecord.Rows[i]["phonenumber"]);
                arr[5] = (string)dtRecord.Rows[i]["sex"];
                arr[6] = (string)dtRecord.Rows[i]["internationalcode"];
                arr[7] = (string)dtRecord.Rows[i]["Title"];
                itm = new ListViewItem(arr);
                materialListView1.Items.Add(itm);
              
            }
            con.Close();
            
            

        }

        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
         
             PaymentForm m = new PaymentForm();
             m.id = int.Parse((materialListView1.SelectedItems[0].Text));
             m.Show();
             con.Close();
            }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT * From Person";

            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;
                arr[0] = ((int)dtRecord.Rows[i]["ID"]).ToString();
                arr[1] = (string)dtRecord.Rows[i]["Name"];
                arr[2] = (string)dtRecord.Rows[i]["Lastname"];
                arr[3] = (string)dtRecord.Rows[i]["internationalcode"];
                arr[4] = ((string)dtRecord.Rows[i]["phonenumber"]);
                arr[5] = (string)dtRecord.Rows[i]["sex"];
                arr[6] = ((int)dtRecord.Rows[i]["age"]).ToString();
                itm = new ListViewItem(arr);
                materialListView2.Items.Add(itm);

            }
            con.Close();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            materialListView3.Items.Clear();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT Person.ID,Person.Name,Person.Lastname,Person.internationalcode,Person.age,Person.phonenumber,Person.sex, Teacher.ID AS teacher_id,Teacher.person_id from Person inner join Teacher on Person.id = Teacher.person_id";

            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;
                arr[0] = ((int)dtRecord.Rows[i]["teacher_id"]).ToString();
                arr[1] = (string)dtRecord.Rows[i]["Name"];
                arr[2] = (string)dtRecord.Rows[i]["Lastname"];
                arr[3] = (string)dtRecord.Rows[i]["internationalcode"];
                arr[4] = ((string)dtRecord.Rows[i]["phonenumber"]);
                arr[5] = (string)dtRecord.Rows[i]["sex"];
                arr[6] = ((int)dtRecord.Rows[i]["age"]).ToString();
                itm = new ListViewItem(arr);
                materialListView3.Items.Add(itm);

            }
            con.Close();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialListView3_DoubleClick(object sender, EventArgs e)
        {
            
            CourseTeacher m = new CourseTeacher();
            m.id = int.Parse(materialListView3.SelectedItems[0].Text);
            m.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            materialListView1.Items.Clear();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT Person.ID,Person.Name,Person.Lastname,Person.internationalcode,Person.age,Person.phonenumber,Person.sex ,Student.ID AS st_id,Student.major_id,Student.person_id,Major.ID,Major.Title from Person inner join Student on Person.id = Student.person_id inner join Major on Student.major_id = Major.id where Person.Name like @name";
            sqlcmd.Parameters.AddWithValue("@name", "" + '%' + textBox1.Text + '%');

            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;
                arr[0] = ((int)dtRecord.Rows[i]["st_id"]).ToString();
                arr[1] = (string)dtRecord.Rows[i]["Name"];
                arr[2] = (string)dtRecord.Rows[i]["Lastname"];
                arr[3] = ((int)dtRecord.Rows[i]["age"]).ToString();
                arr[4] = ((string)dtRecord.Rows[i]["phonenumber"]);
                arr[5] = (string)dtRecord.Rows[i]["sex"];
                arr[6] = (string)dtRecord.Rows[i]["internationalcode"];
                arr[7] = (string)dtRecord.Rows[i]["Title"];
                itm = new ListViewItem(arr);
                materialListView1.Items.Add(itm);

            }
            con.Close();
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            materialListView3.Items.Clear();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            // sqlcmd.CommandText = "SELECT * From Person inner join Student on Person.id = Student.person_id inner join Major on Student.major_id = Major.id";
            sqlcmd.CommandText = "SELECT Person.ID,Person.Name,Person.Lastname,Person.internationalcode,Person.age,Person.phonenumber,Person.sex, Teacher.ID AS teacher_id,Teacher.person_id from Person inner join Teacher on Person.id = Teacher.person_id where Person.Name like @name";
            sqlcmd.Parameters.AddWithValue("@name", "" + '%' + textBox2.Text + '%');

            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;
                arr[0] = ((int)dtRecord.Rows[i]["teacher_id"]).ToString();
                arr[1] = (string)dtRecord.Rows[i]["Name"];
                arr[2] = (string)dtRecord.Rows[i]["Lastname"];
                arr[3] = ((int)dtRecord.Rows[i]["age"]).ToString();
                arr[4] = ((string)dtRecord.Rows[i]["phonenumber"]);
                arr[5] = (string)dtRecord.Rows[i]["sex"];
                arr[6] = (string)dtRecord.Rows[i]["internationalcode"];
                //arr[7] = (string)dtRecord.Rows[i]["Title"];
                itm = new ListViewItem(arr);
                materialListView3.Items.Add(itm);

            }
            con.Close();
        }

        private void materialListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

