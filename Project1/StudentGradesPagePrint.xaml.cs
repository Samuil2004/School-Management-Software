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
using System.Windows.Shapes;

namespace Project1
{
    /// <summary>
    /// Interaction logic for StudentGradesPagePrint.xaml
    /// </summary>
    public partial class StudentGradesPagePrint : Window
    {
        public StudentGradesPagePrint()
        {
            InitializeComponent();
        }

        private void Button_ClickSubmit(object sender, RoutedEventArgs e)
        {
            StudentInto1 a = new StudentInto1();
            a.Show();
            this.Close();
        }
    }
}
