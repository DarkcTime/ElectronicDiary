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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();

            if (Model.Model.IsStudent())
            {
                SharedClass.OpenNewPage(this, new Student.ListTasks());
            }
            else
            {
                SharedClass.OpenNewPage(this, new Teacher.Groups());
            }
            // BackEnd.SharedClass.SetFrame(this.ContentFrame, new ListUsers());
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewPage(this, new Auth());    
        }
    }
}
