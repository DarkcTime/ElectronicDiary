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

namespace ElectronicDiary.View.Pages.Student
{
    /// <summary>
    /// Interaction logic for ListTasks.xaml
    /// </summary>
    public partial class ListTasks : Page
    {
        Model.StudentHelper student = new Model.StudentHelper(); 

        public ListTasks()
        {
            InitializeComponent();
            this.LStSubject.ItemsSource = student.GetStudentSubjects();
            this.LstGroup.ItemsSource = student.GetStudentTasks(student.GetTeacherSubject());
        }
    }
}
