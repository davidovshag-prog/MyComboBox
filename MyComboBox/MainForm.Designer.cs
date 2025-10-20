namespace MyComboBox
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cbRoles = new ComboBox();
            btnRegister = new Button();
            btnSelectFile = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Ім'я:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 140);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 180);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Роль:";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cbRoles
            // 
            cbRoles.Location = new Point(220, 177);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(150, 23);
            cbRoles.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(220, 220);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Зареєструвати";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(391, 100);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(144, 44);
            btnSelectFile.TabIndex = 10;
            btnSelectFile.Text = "Оберіть фото";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(391, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 100);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(457, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSelectFile);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(cbRoles);
            Controls.Add(btnRegister);
            Name = "MainForm";
            Text = "Реєстрація користувача";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cbRoles;
        private Button btnRegister;
        private Button btnSelectFile;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
