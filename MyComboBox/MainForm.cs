using System.IO;

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

        
        private string noImage = @"images\bober.jpg";

        // ����� ��� ���������� ����� �� �������� ������������ ����
        private string selectedImagePath = string.Empty;
        


        public MainForm()
        {
            InitializeComponent();

            cbRoles.Items.AddRange(listRoles);

           
            // ������������ ���������� �� ������������� ��� ����������� �����
            if (File.Exists(noImage))
            {
                pictureBox1.Image = Image.FromFile(noImage);
            }
            else
            {
                
                MessageBox.Show($"�� �������� ���� �� �������������: {Path.GetFullPath(noImage)}\n" +
                                "���� �����, ������ ����� 'images' ����� � .csproj ������ � ����� ���� ����.");
            }
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

            string photoMessage;
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                photoMessage = "����: �� ������ (��������������� ����������)";
            }
            else
            {
                photoMessage = $"����: {selectedImagePath}";
            }

            MessageBox.Show($"���������� {name} ({email})\n" +
                            $"����: {role}\n" +
                            $"{photoMessage}\n" +
                            $"������ �������������!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� �������� ���� ��� ������ �����
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            // ����������� ������
            dlgOpenFile.Filter = "Image Files(*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";

            // �������� ����
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlgOpenFile.FileName;

                // ����²��� ���� �����
                string fileExtension = Path.GetExtension(filePath).ToLower();
                if (fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".png")
                {
                    MessageBox.Show("�������! ���� �����, ������ ���� ���������� ������� JPG, JPEG ��� PNG.");
                    return; // ��������
                }

                // ����²��� ���̲�� ����� (5 ��)
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Length > 5242880) // 5 * 1024 * 1024
                {
                    MessageBox.Show("�������! ���� ������� ������� (����� 5 ��).");
                    return; // ��������
                }

                // ���в����� ���� � �����Ӫ�� ����

                // �������� ���� � ���� ���� �����
                selectedImagePath = filePath;

                // ������������ ���������� � 'pictureBox1'
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }
    }
}