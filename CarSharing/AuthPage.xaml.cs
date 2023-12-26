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
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DbConnect.entObj.Users.FirstOrDefault(x=>x.Login == txbLogin.Text && x.Password == psbPassword.Password);

                if (user == null) 
                {
                    MessageBox.Show("Такого пользователя нет!",
                                    "Ошибка входа",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);

                }
                else 
                {
                    switch (user.IdRole)
                    {
                        case 1:
                            MessageBox.Show("Добро пожаловать!",
                                            "Вход",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new ListCars());
                            break;
                        case 2:
                            MessageBox.Show("Добро пожаловать!",
                                            "Вход",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Information);
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Registration());
        }
    }
}
