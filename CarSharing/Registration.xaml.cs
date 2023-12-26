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

namespace CarSharing
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.Users.Count(x => x.Login == txbLogin.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!",
                                "Ошибка регистрации",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                User userObj = new User()
                {
                    Login = txbLogin.Text,
                    Password = txbPassword.Text,
                    Name = txbFio.Text,
                    IdRole = CmbRole.SelectedIndex
                };

                DbConnect.entObj.Users.Add(userObj);
                DbConnect.entObj.SaveChanges();
            }
        }
    }
}
