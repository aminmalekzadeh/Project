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
    public partial class Pay : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9O9KELH\AMIN;Initial Catalog=Univercity;Integrated Security=True");
        public int id;
        public Pay()
        {
            InitializeComponent();
          
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {


            try
            {
                
                con.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = con;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "INSERT INTO Payment(Amountpayment,student_id) VALUES(@Amountpayment,@student_id)";
              //  int id1 = (int)sqlcmd.ExecuteScalar();
                sqlcmd.Parameters.AddWithValue("@student_id", "" + id);
                sqlcmd.Parameters.AddWithValue("@Amountpayment", ""+  materialSingleLineTextField1.Text);
               
                
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcmd);
                DataTable dtRecord = new DataTable();
                sqldataadapter.Fill(dtRecord);
                MessageBox.Show("شهریه با موفقیت پرداخت شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
