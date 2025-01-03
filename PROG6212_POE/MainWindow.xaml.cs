﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG_POE_PART3_ST10278170
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount createAccountWindow = new CreateAccount();
            createAccountWindow.Show();
            
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LecturerLogin lecturerLogin = new LecturerLogin();
            lecturerLogin.Show();
            
        }

        private void CoordinatorLogin_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorLogin coordinatorLogin = new CoordinatorLogin();
            coordinatorLogin.Show();
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Close the application
        }

        private void HRView_Click(object sender, RoutedEventArgs e)
        {
            HRView hrView = new HRView();
            hrView.Show();
        }
    }
}