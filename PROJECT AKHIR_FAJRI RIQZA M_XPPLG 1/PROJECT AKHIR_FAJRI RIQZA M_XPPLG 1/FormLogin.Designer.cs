namespace PROJECT_AKHIR_FAJRI_RIQZA_M_XPPLG_1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblUsername = new Label();
            lblPassword = new Label();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnlogin = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(67, 53);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(67, 83);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password  :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Location = new Point(12, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 157);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(18, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 27);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(18, 83);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 24);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(154, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(154, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 2;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Black;
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(79, 594);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(212, 44);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 749);
            Controls.Add(btnlogin);
            Controls.Add(groupBox1);
            Name = "FormLogin";
            Text = "Form Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private GroupBox groupBox1;
        private Button btnlogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}