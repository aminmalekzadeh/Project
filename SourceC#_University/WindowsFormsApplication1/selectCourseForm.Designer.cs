namespace WindowsFormsApplication1
{
    partial class Course_select_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_family = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITem_international = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BackColor = System.Drawing.Color.White;
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.item_name,
            this.item_family,
            this.item_age,
            this.Item_PhoneNumber,
            this.item_sex,
            this.ITem_international,
            this.columnHeader10});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.ForeColor = System.Drawing.Color.Black;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HoverSelection = true;
            this.materialListView1.LabelEdit = true;
            this.materialListView1.Location = new System.Drawing.Point(-1, 83);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(689, 406);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            this.materialListView1.DoubleClick += new System.EventHandler(this.materialListView1_DoubleClick);
            // 
            // item_id
            // 
            this.item_id.Text = "ID";
            this.item_id.Width = 50;
            // 
            // item_name
            // 
            this.item_name.Text = "Name";
            this.item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_name.Width = 120;
            // 
            // item_family
            // 
            this.item_family.Text = "Family";
            this.item_family.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_family.Width = 150;
            // 
            // item_age
            // 
            this.item_age.Text = "Age";
            this.item_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_age.Width = 150;
            // 
            // Item_PhoneNumber
            // 
            this.Item_PhoneNumber.Text = "PhoneNumber";
            this.Item_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Item_PhoneNumber.Width = 150;
            // 
            // item_sex
            // 
            this.item_sex.Text = "Sex";
            this.item_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_sex.Width = 150;
            // 
            // ITem_international
            // 
            this.ITem_international.Text = "InterNationalCode";
            this.ITem_international.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ITem_international.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Major";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 100;
            // 
            // Course_select_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 501);
            this.Controls.Add(this.materialListView1);
            this.Name = "Course_select_student";
            this.Text = "Select Course Student";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader item_family;
        private System.Windows.Forms.ColumnHeader item_age;
        private System.Windows.Forms.ColumnHeader Item_PhoneNumber;
        private System.Windows.Forms.ColumnHeader item_sex;
        private System.Windows.Forms.ColumnHeader ITem_international;
        private System.Windows.Forms.ColumnHeader columnHeader10;


    }
}