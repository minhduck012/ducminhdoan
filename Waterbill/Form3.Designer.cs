namespace Waterbill
{
    partial class Form3
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
            gbwaterbill = new GroupBox();
            butexit = new Button();
            butdelete = new Button();
            butedit = new Button();
            butadd = new Button();
            cbbcustomer = new ComboBox();
            textpeople = new TextBox();
            textthismonth = new TextBox();
            textlastmonth = new TextBox();
            textname = new TextBox();
            labpeople = new Label();
            labcustomer = new Label();
            labthismonth = new Label();
            lablastmonth = new Label();
            labname = new Label();
            lv = new ListView();
            gbwaterbill.SuspendLayout();
            SuspendLayout();
            // 
            // gbwaterbill
            // 
            gbwaterbill.Controls.Add(butexit);
            gbwaterbill.Controls.Add(butdelete);
            gbwaterbill.Controls.Add(butedit);
            gbwaterbill.Controls.Add(butadd);
            gbwaterbill.Controls.Add(cbbcustomer);
            gbwaterbill.Controls.Add(textpeople);
            gbwaterbill.Controls.Add(textthismonth);
            gbwaterbill.Controls.Add(textlastmonth);
            gbwaterbill.Controls.Add(textname);
            gbwaterbill.Controls.Add(labpeople);
            gbwaterbill.Controls.Add(labcustomer);
            gbwaterbill.Controls.Add(labthismonth);
            gbwaterbill.Controls.Add(lablastmonth);
            gbwaterbill.Controls.Add(labname);
            gbwaterbill.Location = new Point(25, 11);
            gbwaterbill.Name = "gbwaterbill";
            gbwaterbill.Size = new Size(403, 664);
            gbwaterbill.TabIndex = 2;
            gbwaterbill.TabStop = false;
            gbwaterbill.Text = "Water Bill";
            // 
            // butexit
            // 
            butexit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butexit.Location = new Point(14, 591);
            butexit.Name = "butexit";
            butexit.Size = new Size(373, 43);
            butexit.TabIndex = 13;
            butexit.Text = "Exit";
            butexit.UseVisualStyleBackColor = true;
            butexit.Click += butexit_Click;
            // 
            // butdelete
            // 
            butdelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butdelete.Location = new Point(14, 542);
            butdelete.Name = "butdelete";
            butdelete.Size = new Size(373, 43);
            butdelete.TabIndex = 12;
            butdelete.Text = "Delete";
            butdelete.UseVisualStyleBackColor = true;
            butdelete.Click += butdelete_Click;
            // 
            // butedit
            // 
            butedit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butedit.Location = new Point(14, 494);
            butedit.Name = "butedit";
            butedit.Size = new Size(373, 42);
            butedit.TabIndex = 11;
            butedit.Text = "Edit";
            butedit.UseVisualStyleBackColor = true;
            butedit.Click += butedit_Click;
            // 
            // butadd
            // 
            butadd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butadd.Location = new Point(14, 444);
            butadd.Name = "butadd";
            butadd.Size = new Size(373, 44);
            butadd.TabIndex = 6;
            butadd.Text = "Add";
            butadd.UseVisualStyleBackColor = true;
            butadd.Click += butadd_Click;
            // 
            // cbbcustomer
            // 
            cbbcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbcustomer.FormattingEnabled = true;
            cbbcustomer.Items.AddRange(new object[] { "Household", "Administrative agency", "Production unit", "Business service", "                " });
            cbbcustomer.Location = new Point(120, 311);
            cbbcustomer.Name = "cbbcustomer";
            cbbcustomer.Size = new Size(267, 36);
            cbbcustomer.TabIndex = 4;
            cbbcustomer.SelectedIndexChanged += cbbcustomer_SelectedIndexChanged;
            // 
            // textpeople
            // 
            textpeople.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textpeople.Location = new Point(190, 363);
            textpeople.Name = "textpeople";
            textpeople.ReadOnly = true;
            textpeople.Size = new Size(197, 34);
            textpeople.TabIndex = 5;
            textpeople.TextChanged += textpeople_TextChanged;
            // 
            // textthismonth
            // 
            textthismonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textthismonth.Location = new Point(14, 245);
            textthismonth.Name = "textthismonth";
            textthismonth.Size = new Size(373, 34);
            textthismonth.TabIndex = 3;
            // 
            // textlastmonth
            // 
            textlastmonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textlastmonth.Location = new Point(14, 156);
            textlastmonth.Name = "textlastmonth";
            textlastmonth.Size = new Size(373, 34);
            textlastmonth.TabIndex = 2;
            // 
            // textname
            // 
            textname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textname.Location = new Point(13, 78);
            textname.Name = "textname";
            textname.Size = new Size(374, 34);
            textname.TabIndex = 1;
            // 
            // labpeople
            // 
            labpeople.AutoSize = true;
            labpeople.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labpeople.Location = new Point(14, 369);
            labpeople.Name = "labpeople";
            labpeople.Size = new Size(171, 28);
            labpeople.TabIndex = 4;
            labpeople.Text = "How many people";
            // 
            // labcustomer
            // 
            labcustomer.AutoSize = true;
            labcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labcustomer.Location = new Point(13, 311);
            labcustomer.Name = "labcustomer";
            labcustomer.Size = new Size(101, 28);
            labcustomer.TabIndex = 3;
            labcustomer.Text = "Customer ";
            // 
            // labthismonth
            // 
            labthismonth.AutoSize = true;
            labthismonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labthismonth.Location = new Point(14, 214);
            labthismonth.Name = "labthismonth";
            labthismonth.Size = new Size(109, 28);
            labthismonth.TabIndex = 2;
            labthismonth.Text = "This month";
            // 
            // lablastmonth
            // 
            lablastmonth.AutoSize = true;
            lablastmonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lablastmonth.Location = new Point(14, 125);
            lablastmonth.Name = "lablastmonth";
            lablastmonth.Size = new Size(109, 28);
            lablastmonth.TabIndex = 1;
            lablastmonth.Text = "Last month";
            // 
            // labname
            // 
            labname.AutoSize = true;
            labname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labname.Location = new Point(14, 47);
            labname.Name = "labname";
            labname.Size = new Size(64, 28);
            labname.TabIndex = 0;
            labname.Text = "Name";
            // 
            // lv
            // 
            lv.Location = new Point(443, 21);
            lv.Name = "lv";
            lv.Size = new Size(1240, 654);
            lv.TabIndex = 3;
            lv.UseCompatibleStateImageBehavior = false;
            lv.SelectedIndexChanged += lv_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 693);
            Controls.Add(gbwaterbill);
            Controls.Add(lv);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            gbwaterbill.ResumeLayout(false);
            gbwaterbill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbwaterbill;
        private Button butexit;
        private Button butdelete;
        private Button butedit;
        private Button butadd;
        private ComboBox cbbcustomer;
        private TextBox textpeople;
        private TextBox textthismonth;
        private TextBox textlastmonth;
        private TextBox textname;
        private Label labpeople;
        private Label labcustomer;
        private Label labthismonth;
        private Label lablastmonth;
        private Label labname;
        private ListView lv;
    }
}