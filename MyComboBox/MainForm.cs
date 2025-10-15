namespace MyComboBox
{
    public partial class MainForm : Form
    {
        RolesNames[] listRoles =
        {
            new RolesNames(1, "����"),
            new RolesNames(2, "��������"),
            new RolesNames(3, "���������"),
            new RolesNames(4, "���������")
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
                MessageBox.Show("���� �����, �������� �� ����!");
                return;
            }

            MessageBox.Show($"���������� {name} ({email})\n����: {role}\n������ �������������!");
        }
    }
}
