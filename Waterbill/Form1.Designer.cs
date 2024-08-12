namespace Waterbill
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
            labname = new Label();
            labpass = new Label();
            textname = new TextBox();
            textpass = new TextBox();
            butlogin = new Button();
            butexit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labname
            // 
            labname.AutoSize = true;
            labname.BackColor = Color.White;
            labname.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labname.Location = new Point(357, 197);
            labname.Name = "labname";
            labname.Size = new Size(150, 38);
            labname.TabIndex = 0;
            labname.Text = "User name";
            // 
            // labpass
            // 
            labpass.AutoSize = true;
            labpass.BackColor = Color.White;
            labpass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labpass.Location = new Point(357, 274);
            labpass.Name = "labpass";
            labpass.Size = new Size(132, 38);
            labpass.TabIndex = 1;
            labpass.Text = "Password";
            // 
            // textname
            // 
            textname.BackColor = Color.White;
            textname.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textname.Location = new Point(989, 197);
            textname.Name = "textname";
            textname.Size = new Size(364, 43);
            textname.TabIndex = 2;
            // 
            // textpass
            // 
            textpass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textpass.Location = new Point(989, 269);
            textpass.Name = "textpass";
            textpass.PasswordChar = '*';
            textpass.Size = new Size(364, 43);
            textpass.TabIndex = 3;
            // 
            // butlogin
            // 
            butlogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butlogin.Location = new Point(540, 420);
            butlogin.Name = "butlogin";
            butlogin.Size = new Size(94, 42);
            butlogin.TabIndex = 4;
            butlogin.Text = "Login";
            butlogin.UseVisualStyleBackColor = true;
            butlogin.Click += butlogin_Click;
            // 
            // butexit
            // 
            butexit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butexit.Location = new Point(925, 420);
            butexit.Name = "butexit";
            butexit.Size = new Size(94, 42);
            butexit.TabIndex = 5;
            butexit.Text = "Exit";
            butexit.UseVisualStyleBackColor = true;
            butexit.Click += butexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 63);
            label1.Name = "label1";
            label1.Size = new Size(365, 50);
            label1.TabIndex = 6;
            label1.Text = "Minh Duc's water bill";
            // 
            // Form1
            // 
            AcceptButton = butlogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = butexit;
            ClientSize = new Size(1683, 697);
            Controls.Add(label1);
            Controls.Add(butexit);
            Controls.Add(butlogin);
            Controls.Add(textpass);
            Controls.Add(textname);
            Controls.Add(labpass);
            Controls.Add(labname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labname;
        private Label labpass;
        private TextBox textname;
        private TextBox textpass;
        private Button butlogin;
        private Button butexit;
        private Label label1;
    }
}
