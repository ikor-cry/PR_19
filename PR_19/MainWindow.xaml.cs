using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_19
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            DEBILCHIC user = new DEBILCHIC();

            user.Name = NameInput.Text;
            user.Email = EmailInput.Text;
            user.Password = PasswordInput.Password;

            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Введите имя и пароль!");
                return;
            }

            if (!user.Email.Contains("@"))
            {
                MessageBox.Show("В Email должна быть @!");
                return;
            }

            user.IsAgreed = AgreeCheckBox.IsChecked == true;

            if (!user.IsAgreed)
            {
                MessageBox.Show("Надо согласиться с правилами!");
                return;
            }

            MessageBox.Show("Успех!\n" + user.GetInfo());
        }

    }
}