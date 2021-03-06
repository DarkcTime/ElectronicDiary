﻿using System;
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
    /// Interaction logic for ListTasksForTeacher.xaml
    /// </summary>
    public partial class ListTasksForTeacher : Page
    {
        Model.TeacherHelper TeacherHelper = new Model.TeacherHelper();
        public ListTasksForTeacher(Model.TeacherGroup teacherGroup)
        {
            InitializeComponent();
            LstTask.ItemsSource = TeacherHelper.GetTasks(teacherGroup);
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
