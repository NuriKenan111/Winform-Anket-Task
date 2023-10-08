namespace SurveyTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            name = new TextBox();
            surname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            country = new TextBox();
            label4 = new Label();
            label5 = new Label();
            city = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            pic1 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            email = new TextBox();
            label8 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(83, 58);
            name.MaxLength = 16;
            name.Name = "name";
            name.Size = new Size(228, 23);
            name.TabIndex = 0;
            // 
            // surname
            // 
            surname.Location = new Point(83, 99);
            surname.MaxLength = 16;
            surname.Name = "surname";
            surname.Size = new Size(228, 23);
            surname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 2;
            label1.Text = "Survey";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(15, 58);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 3;
            label2.Text = "Name";
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(15, 99);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(66, 19);
            label3.TabIndex = 4;
            label3.Text = "Surname";
            // 
            // country
            // 
            country.Location = new Point(83, 145);
            country.MaxLength = 16;
            country.Name = "country";
            country.Size = new Size(228, 23);
            country.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(62, 19);
            label4.TabIndex = 6;
            label4.Text = "Country";
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(15, 191);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(36, 19);
            label5.TabIndex = 7;
            label5.Text = "City";
            // 
            // city
            // 
            city.Location = new Point(83, 191);
            city.MaxLength = 16;
            city.Name = "city";
            city.Size = new Size(228, 23);
            city.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(3, 356);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(62, 19);
            label6.TabIndex = 10;
            label6.Text = "Gender:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(116, 352);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 23);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(208, 352);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 23);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            pic1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pic1.Location = new Point(99, 279);
            pic1.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            pic1.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            pic1.Name = "pic1";
            pic1.Size = new Size(228, 23);
            pic1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(1, 283);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(80, 19);
            label7.TabIndex = 15;
            label7.Text = "DateTime: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // email
            // 
            email.Location = new Point(83, 230);
            email.MaxLength = 16;
            email.Name = "email";
            email.Size = new Size(228, 23);
            email.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(12, 234);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(47, 19);
            label8.TabIndex = 18;
            label8.Text = "Email";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox3.Location = new Point(119, 312);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 23);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "True";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox4.Location = new Point(221, 312);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(63, 23);
            checkBox4.TabIndex = 20;
            checkBox4.Text = "False";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(1, 316);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(109, 19);
            label9.TabIndex = 21;
            label9.Text = "Military Status:";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(101, 405);
            button1.Name = "button1";
            button1.Size = new Size(129, 33);
            button1.TabIndex = 22;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(label8);
            Controls.Add(email);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(pic1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(city);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(country);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(surname);
            Controls.Add(name);
            Name = "Form1";
            Text = "Survay";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox surname;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox country;
        private Label label4;
        private Label label5;
        private TextBox city;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DateTimePicker pic1;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox email;
        private Label label8;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label9;
        private Button button1;
    }
}