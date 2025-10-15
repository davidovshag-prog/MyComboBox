namespace MyComboBox
{
    public partial class MainForm : Form
    {
        RolesNames[] listRoles =
        {
            new RolesNames(1, "Адмін"),
            new RolesNames(2, "Менеджер"),
            new RolesNames(3, "Продавець"),
            new RolesNames(4, "Складовик")
        };

        public MainForm()
        {
            InitializeComponent();

            cbRoles.Items.AddRange(listRoles);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            var role = cbRoles.SelectedItem;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || role == null)
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!");
                return;
            }

            MessageBox.Show($"Користувач {name} ({email})\nРоль: {role}\nУспішно зареєстрований!");
        }
    }
}
