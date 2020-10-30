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

namespace ElectronicDiary.View.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для Groups.xaml
    /// </summary>
    public partial class Groups : Page
    {
        Model.TeacherHelper TeacherHelper = new Model.TeacherHelper();

        public Groups()
        {
            InitializeComponent();
            LStSubject.ItemsSource = TeacherHelper.GetTeacherSubjects();
            LstGroup.ItemsSource = TeacherHelper.GetTeacherGroups();
        }

        private void LStSubject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LstGroup.ItemsSource = TeacherHelper.GetTeacherGroups((LStSubject.SelectedItem as Model.TeacherSubject));
        }

        private void LstGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((LstGroup.SelectedItem as Model.TeacherGroup).Group.Name);
        }
    }
}
