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

namespace Project1
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

        

        private void Button_ClickTeacher(object sender, RoutedEventArgs e)
        {
            TeacherLogInNew b =  new TeacherLogInNew ();
            b.Show();
            this.Close();
        }

        private void Button_ClickStudent(object sender, RoutedEventArgs e)
        {
            StudentLogIn a = new StudentLogIn();
            a.Show();
            this.Close();
        }

        private void Button_ClickAdmin(object sender, RoutedEventArgs e)
        {
            AdminLogIn a = new AdminLogIn();
            a.Show();
            this.Close();

        }
    }
}
