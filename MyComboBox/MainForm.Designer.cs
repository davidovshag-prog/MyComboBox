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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 60);
            label1.Text = "Ім'я:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 100);
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 140);
            label3.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 180);
            label4.Text = "Роль:";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 57);
            txtName.Size = new Size(150, 23);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 97);
            txtEmail.Size = new Size(150, 23);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 137);
            txtPassword.Size = new Size(150, 23);
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cbRoles
            // 
            cbRoles.Location = new Point(220, 177);
            cbRoles.Size = new Size(150, 23);
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(220, 220);
            btnRegister.Size = new Size(150, 30);
            btnRegister.Text = "Зареєструвати";
            btnRegister.Click += btnRegister_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
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
    }
}
