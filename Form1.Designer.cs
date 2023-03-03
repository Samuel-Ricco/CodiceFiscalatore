namespace CodiceFiscalatore
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_comune = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.txtb_surname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lbl_birthDate = new System.Windows.Forms.Label();
            this.rbtn_M = new System.Windows.Forms.RadioButton();
            this.rbtn_F = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_cf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(36, 23);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(36, 58);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(54, 15);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_comune
            // 
            this.lbl_comune.AutoSize = true;
            this.lbl_comune.Location = new System.Drawing.Point(36, 131);
            this.lbl_comune.Name = "lbl_comune";
            this.lbl_comune.Size = new System.Drawing.Size(106, 15);
            this.lbl_comune.TabIndex = 3;
            this.lbl_comune.Text = "Comune di nascità";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(201, 20);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(100, 23);
            this.txtb_name.TabIndex = 4;
            // 
            // txtb_surname
            // 
            this.txtb_surname.Location = new System.Drawing.Point(201, 55);
            this.txtb_surname.Name = "txtb_surname";
            this.txtb_surname.Size = new System.Drawing.Size(100, 23);
            this.txtb_surname.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(201, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(36, 181);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(25, 15);
            this.lb_sex.TabIndex = 7;
            this.lb_sex.Text = "Sex";
            // 
            // lbl_birthDate
            // 
            this.lbl_birthDate.AutoSize = true;
            this.lbl_birthDate.Location = new System.Drawing.Point(36, 98);
            this.lbl_birthDate.Name = "lbl_birthDate";
            this.lbl_birthDate.Size = new System.Drawing.Size(59, 15);
            this.lbl_birthDate.TabIndex = 8;
            this.lbl_birthDate.Text = "Birth Date";
            // 
            // rbtn_M
            // 
            this.rbtn_M.AutoSize = true;
            this.rbtn_M.Location = new System.Drawing.Point(200, 165);
            this.rbtn_M.Name = "rbtn_M";
            this.rbtn_M.Size = new System.Drawing.Size(51, 19);
            this.rbtn_M.TabIndex = 9;
            this.rbtn_M.TabStop = true;
            this.rbtn_M.Text = "Male\r\n";
            this.rbtn_M.UseVisualStyleBackColor = true;
            // 
            // rbtn_F
            // 
            this.rbtn_F.AutoSize = true;
            this.rbtn_F.Location = new System.Drawing.Point(201, 190);
            this.rbtn_F.Name = "rbtn_F";
            this.rbtn_F.Size = new System.Drawing.Size(63, 19);
            this.rbtn_F.TabIndex = 10;
            this.rbtn_F.TabStop = true;
            this.rbtn_F.Text = "Female";
            this.rbtn_F.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(526, 23);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(214, 74);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_cf
            // 
            this.lbl_cf.AutoSize = true;
            this.lbl_cf.Location = new System.Drawing.Point(614, 155);
            this.lbl_cf.Name = "lbl_cf";
            this.lbl_cf.Size = new System.Drawing.Size(82, 15);
            this.lbl_cf.TabIndex = 12;
            this.lbl_cf.Text = "Codice Fiscale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cf);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rbtn_F);
            this.Controls.Add(this.rbtn_M);
            this.Controls.Add(this.lbl_birthDate);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtb_surname);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.lbl_comune);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private Label lbl_surname;
        private DateTimePicker dateTimePicker1;
        private Label lbl_comune;
        private TextBox txtb_name;
        private TextBox txtb_surname;
        private TextBox textBox3;
        private Label lb_sex;
        private Label lbl_birthDate;
        private RadioButton rbtn_M;
        private RadioButton rbtn_F;
        private Button btn_start;
        private Label lbl_cf;
    }
}