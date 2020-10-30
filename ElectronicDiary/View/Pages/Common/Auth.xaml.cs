using ElectronicDiary.BackEnd;
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

namespace ElectronicDiary.View.Pages.Common
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {

        Model.Model model = new Model.Model(); 

        public Auth()
        {
            InitializeComponent();
        }

        private void AuthClick(object sender, RoutedEventArgs e)
        {
            /*
            if (string.IsNullOrWhiteSpace(this.txtLogin.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                if () OpenNewWindowAndCloseThis(CloseWindow, new View.Areas.Users.MainWindow());
                else MessageBoxWarning("Неправильный логин или пароль");
            }
            else SharedClass.MessageBoxWarning("Все поля должны быть заполнены");
            //SharedClass.OpenNewPage(this, new MainMenu());
            */
        }

        private void CreateAccountClick(object sender, RoutedEventArgs e)
        {
            //SharedClass.OpenNewPage(this, new CreateAccount());
        }
    }
}
