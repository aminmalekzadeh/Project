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
    public partial class CourseTeacher : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");
       public  int id;
        public CourseTeacher()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from tch_cr inner join Course on tch_cr.Course_id = Course.ID where tch_cr.teacher_id =  @teacherid";

            sqlcmd.Parameters.AddWithValue("@teacherid", "" + id);
            // sqlcmd.ExecuteReader();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;

                arr[0] = ((string)dtRecord.Rows[i]["NameCourse"]).ToString();
                arr[1] = ((int)dtRecord.Rows[i]["NumberUnit"]).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
            con.Close();
        }
    }
}
