using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuthorizationWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizePage.xaml
    /// </summary>
    public partial class AuthorizePage : Page
    {
        public AuthorizePage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTb.Text;
            var password = PasswordTb.Password;
            var loginUser = "Admin";
            var passwordUser = "1111";
            if (login == loginUser && password == passwordUser)
            {
                MessageBox.Show("Здравствуй админушка");
                NavigationService.Navigate(new AnketaPage());
            }
            else MessageBox.Show("От тебя воняет");
        }
    }
}
