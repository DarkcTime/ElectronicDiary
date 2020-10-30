using ElectronicDiary.BackEnd;
using ElectronicDiary.View.Pages.Student;
using ElectronicDiary.View.Pages.Teacher;
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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();

            if (Model.Model.IsStudent())
            {
                this.ContentFrame.Content = new ListTasks();
            }
            else
            {
                this.ContentFrame.Content = new Groups();
            }

        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewPage(this, new Auth());
        }
    }
}
