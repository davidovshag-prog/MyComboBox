using System.IO;

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

        
        private string noImage = @"images\bober.jpg";

        // Змінна для збереження шляху до обраного користувачем фото
        private string selectedImagePath = string.Empty;
        


        public MainForm()
        {
            InitializeComponent();

            cbRoles.Items.AddRange(listRoles);

           
            // Встановлюємо зображення за замовчуванням при завантаженні форми
            if (File.Exists(noImage))
            {
                pictureBox1.Image = Image.FromFile(noImage);
            }
            else
            {
                
                MessageBox.Show($"Не знайдено файл за замовчуванням: {Path.GetFullPath(noImage)}\n" +
                                "Будь ласка, створи папку 'images' поруч з .csproj файлом і додай туди фото.");
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
                MessageBox.Show("Будь ласка, заповніть усі поля!");
                return;
            }

            string photoMessage;
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                photoMessage = "Фото: не обрано (використовується стандартне)";
            }
            else
            {
                photoMessage = $"Фото: {selectedImagePath}";
            }

            MessageBox.Show($"Користувач {name} ({email})\n" +
                            $"Роль: {role}\n" +
                            $"{photoMessage}\n" +
                            $"Успішно зареєстрований!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Створюємо діалогове вікно для вибору файлу
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            // Налаштовуємо фільтр
            dlgOpenFile.Filter = "Image Files(*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";

            // Показуємо вікно
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlgOpenFile.FileName;

                // ПЕРЕВІРКА ТИПУ ФАЙЛУ
                string fileExtension = Path.GetExtension(filePath).ToLower();
                if (fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".png")
                {
                    MessageBox.Show("Помилка! Будь ласка, оберіть файл зображення формату JPG, JPEG або PNG.");
                    return; // Виходимо
                }

                // ПЕРЕВІРКА РОЗМІРУ ФАЙЛУ (5 МБ)
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Length > 5242880) // 5 * 1024 * 1024
                {
                    MessageBox.Show("Помилка! Файл занадто великий (більше 5 МБ).");
                    return; // Виходимо
                }

                // ЗБЕРІГАЄМО ШЛЯХ І ПОКАЗУЄМО ФОТО

                // Зберігаємо шлях у нашу нову змінну
                selectedImagePath = filePath;

                // Встановлюємо зображення у 'pictureBox1'
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }
    }
}