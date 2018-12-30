using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UniversityForm : MaterialSkin.Controls.MaterialForm
    {
        public UniversityForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange500, Primary.Orange900, Primary.Green900, Accent.Red400, TextShade.WHITE);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            RegisterForm n = new RegisterForm();
            n.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Data n = new Data();
            n.Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Payoff open = new Payoff();
            open.Show();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Course_select_student open = new Course_select_student();
            open.Show();
        }
    }
}
