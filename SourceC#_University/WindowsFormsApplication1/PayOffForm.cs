using MaterialSkin;
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
    public partial class Payoff : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");

        public Payoff()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange500, Primary.Orange900, Primary.Green900, Accent.Red400, TextShade.WHITE);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();
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

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
            Pay open = new Pay();
            open.id = int.Parse((materialListView1.SelectedItems[0].Text));
          
            open.Show();
            con.Close();
        }
    }
}
