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
    /// Interaction logic for StudentsGradesPage.xaml
    /// </summary>
    public partial class StudentsGradesPage : Window
    {
        public StudentsGradesPage()
        {
            InitializeComponent();
        }

        private void Button_ClickBG(object sender, RoutedEventArgs e)
        {
            VpBG a = new VpBG();
            a.Show();
            this.Close();
        }

        private void Button_ClickELL(object sender, RoutedEventArgs e)
        {
            VPELL a = new VPELL();
            a.Show();
            this.Close();
        }

        private void Button_ClickMathematics(object sender, RoutedEventArgs e)
        {
            VerificationPage a = new VerificationPage();
            a.Show();
            this.Close();
        }

        private void Button_ClickCivics(object sender, RoutedEventArgs e)
        {
            VPCivics a = new VPCivics();
            a.Show();
            this.Close();
        }

        private void Button_ClickPhysics(object sender, RoutedEventArgs e)
        {
            VPPhysics a = new VPPhysics();
            a.Show();
            this.Close();
        }

        private void Button_ClickSports(object sender, RoutedEventArgs e)
        {
            VPSports a = new VPSports();
            a.Show();
            this.Close();
        }

        private void Button_ClickInformatics(object sender, RoutedEventArgs e)
        {
            VPInformatics a = new VPInformatics();
            a.Show();
            this.Close();
        }
    }
}
