namespace WindowsFormsApplication1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtfamilyname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtinternationalcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtphonenumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radiobtnmale = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtnstudent = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtnfamel = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtnteacher = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "شماره ملی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "شماره تماس";
            // 
            // txtname
            // 
            this.txtname.Depth = 0;
            this.txtname.Hint = "";
            this.txtname.Location = new System.Drawing.Point(314, 140);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.MaxLength = 32767;
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.Size = new System.Drawing.Size(213, 23);
            this.txtname.TabIndex = 7;
            this.txtname.TabStop = false;
            this.txtname.UseSystemPasswordChar = false;
            // 
            // txtfamilyname
            // 
            this.txtfamilyname.Depth = 0;
            this.txtfamilyname.Hint = "";
            this.txtfamilyname.Location = new System.Drawing.Point(314, 199);
            this.txtfamilyname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfamilyname.MaxLength = 32767;
            this.txtfamilyname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfamilyname.Name = "txtfamilyname";
            this.txtfamilyname.PasswordChar = '\0';
            this.txtfamilyname.SelectedText = "";
            this.txtfamilyname.SelectionLength = 0;
            this.txtfamilyname.SelectionStart = 0;
            this.txtfamilyname.Size = new System.Drawing.Size(213, 23);
            this.txtfamilyname.TabIndex = 8;
            this.txtfamilyname.TabStop = false;
            this.txtfamilyname.UseSystemPasswordChar = false;
            // 
            // txtinternationalcode
            // 
            this.txtinternationalcode.Depth = 0;
            this.txtinternationalcode.Hint = "";
            this.txtinternationalcode.Location = new System.Drawing.Point(314, 256);
            this.txtinternationalcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtinternationalcode.MaxLength = 32767;
            this.txtinternationalcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtinternationalcode.Name = "txtinternationalcode";
            this.txtinternationalcode.PasswordChar = '\0';
            this.txtinternationalcode.SelectedText = "";
            this.txtinternationalcode.SelectionLength = 0;
            this.txtinternationalcode.SelectionStart = 0;
            this.txtinternationalcode.Size = new System.Drawing.Size(213, 23);
            this.txtinternationalcode.TabIndex = 9;
            this.txtinternationalcode.TabStop = false;
            this.txtinternationalcode.UseSystemPasswordChar = false;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Depth = 0;
            this.txtphonenumber.Hint = "";
            this.txtphonenumber.Location = new System.Drawing.Point(314, 411);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphonenumber.MaxLength = 32767;
            this.txtphonenumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.PasswordChar = '\0';
            this.txtphonenumber.SelectedText = "";
            this.txtphonenumber.SelectionLength = 0;
            this.txtphonenumber.SelectionStart = 0;
            this.txtphonenumber.Size = new System.Drawing.Size(213, 23);
            this.txtphonenumber.TabIndex = 10;
            this.txtphonenumber.TabStop = false;
            this.txtphonenumber.UseSystemPasswordChar = false;
            // 
            // radiobtnmale
            // 
            this.radiobtnmale.AutoSize = true;
            this.radiobtnmale.Depth = 0;
            this.radiobtnmale.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtnmale.Location = new System.Drawing.Point(124, 25);
            this.radiobtnmale.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtnmale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtnmale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtnmale.Name = "radiobtnmale";
            this.radiobtnmale.Ripple = true;
            this.radiobtnmale.Size = new System.Drawing.Size(59, 30);
            this.radiobtnmale.TabIndex = 12;
            this.radiobtnmale.TabStop = true;
            this.radiobtnmale.Text = "male";
            this.radiobtnmale.UseVisualStyleBackColor = true;
            // 
            // radiobtnstudent
            // 
            this.radiobtnstudent.AutoSize = true;
            this.radiobtnstudent.Depth = 0;
            this.radiobtnstudent.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtnstudent.Location = new System.Drawing.Point(138, 22);
            this.radiobtnstudent.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtnstudent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtnstudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtnstudent.Name = "radiobtnstudent";
            this.radiobtnstudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtnstudent.Ripple = true;
            this.radiobtnstudent.Size = new System.Drawing.Size(76, 30);
            this.radiobtnstudent.TabIndex = 13;
            this.radiobtnstudent.TabStop = true;
            this.radiobtnstudent.Text = "student";
            this.radiobtnstudent.UseVisualStyleBackColor = true;
            this.radiobtnstudent.CheckedChanged += new System.EventHandler(this.radiobtnstudent_CheckedChanged);
            // 
            // radiobtnfamel
            // 
            this.radiobtnfamel.AutoSize = true;
            this.radiobtnfamel.Depth = 0;
            this.radiobtnfamel.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtnfamel.Location = new System.Drawing.Point(35, 25);
            this.radiobtnfamel.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtnfamel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtnfamel.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtnfamel.Name = "radiobtnfamel";
            this.radiobtnfamel.Ripple = true;
            this.radiobtnfamel.Size = new System.Drawing.Size(64, 30);
            this.radiobtnfamel.TabIndex = 14;
            this.radiobtnfamel.TabStop = true;
            this.radiobtnfamel.Text = "famel";
            this.radiobtnfamel.UseVisualStyleBackColor = true;
            // 
            // radiobtnteacher
            // 
            this.radiobtnteacher.AutoSize = true;
            this.radiobtnteacher.Depth = 0;
            this.radiobtnteacher.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtnteacher.Location = new System.Drawing.Point(29, 22);
            this.radiobtnteacher.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtnteacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtnteacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtnteacher.Name = "radiobtnteacher";
            this.radiobtnteacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtnteacher.Ripple = true;
            this.radiobtnteacher.Size = new System.Drawing.Size(79, 30);
            this.radiobtnteacher.TabIndex = 15;
            this.radiobtnteacher.TabStop = true;
            this.radiobtnteacher.Text = "Teacher";
            this.radiobtnteacher.UseVisualStyleBackColor = true;
            this.radiobtnteacher.CheckedChanged += new System.EventHandler(this.radiobtnteacher_CheckedChanged);
            this.radiobtnteacher.Click += new System.EventHandler(this.radiobtnteacher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnteacher);
            this.groupBox1.Controls.Add(this.radiobtnstudent);
            this.groupBox1.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(261, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع عضویت";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtnfamel);
            this.groupBox2.Controls.Add(this.radiobtnmale);
            this.groupBox2.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 302);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(213, 84);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جنسیت";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(247, 531);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(38, 36);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "ثبت";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "سن";
            // 
            // txtage
            // 
            this.txtage.Depth = 0;
            this.txtage.Hint = "";
            this.txtage.Location = new System.Drawing.Point(314, 486);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtage.MaxLength = 32767;
            this.txtage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtage.Name = "txtage";
            this.txtage.PasswordChar = '\0';
            this.txtage.SelectedText = "";
            this.txtage.SelectionLength = 0;
            this.txtage.SelectionStart = 0;
            this.txtage.Size = new System.Drawing.Size(213, 23);
            this.txtage.TabIndex = 11;
            this.txtage.TabStop = false;
            this.txtage.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(15, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(261, 184);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انتخاب درس";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 25);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 229);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(261, 184);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "انتخاب رشته";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 30);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 29);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 42);
            this.label4.TabIndex = 22;
            this.label4.Text = "ثبت نام";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtinternationalcode);
            this.Controls.Add(this.txtfamilyname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtfamilyname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtinternationalcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtphonenumber;
        private MaterialSkin.Controls.MaterialRadioButton radiobtnmale;
        private MaterialSkin.Controls.MaterialRadioButton radiobtnstudent;
        private MaterialSkin.Controls.MaterialRadioButton radiobtnfamel;
        private MaterialSkin.Controls.MaterialRadioButton radiobtnteacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
    }
}