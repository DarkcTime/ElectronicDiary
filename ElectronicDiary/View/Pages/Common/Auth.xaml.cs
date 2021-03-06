﻿using ElectronicDiary.BackEnd;
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
            try
            {

                if (this.txtLogin.Text != "" && this.txtPassword.Text != "")
                {
                    if (model.IsAuth(this.txtLogin.Text, this.txtPassword.Text)) SharedClass.OpenNewPage(this, new MainMenu());
                    else SharedClass.MessageBoxWarning("Неправильный логин или пароль");
                }
                else
                {
                    SharedClass.MessageBoxWarning("Все поля должны быть заполнены");
                }
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }

        private void CreateAccountClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
