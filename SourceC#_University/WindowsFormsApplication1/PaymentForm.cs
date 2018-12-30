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
    public partial class PaymentForm : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");
       public int id;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from Payment where student_id = @studentid";
           
            sqlcmd.Parameters.AddWithValue("@studentid", ""+id);
           // sqlcmd.ExecuteReader();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
            DataTable dtRecord = new DataTable();
            sqldataadapter.Fill(dtRecord);

            for (int i = 0; i < dtRecord.Rows.Count; i++)
            {
                string[] arr = new string[10];
                ListViewItem itm;
                
                arr[0] = ((decimal)dtRecord.Rows[i]["Amountpayment"]).ToString();
                arr[1] = ((int)dtRecord.Rows[i]["ID"]).ToString();
              
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
            con.Close();
        }
    }
}
