using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Interaction logic for ParticipationForTeachers.xaml
    /// </summary>
    public partial class ParticipationForTeachers : Window
    {
        public ParticipationForTeachers()
        {
            InitializeComponent();
        }

        private void Button_ClickEdit(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                if (sqlCon1.State == ConnectionState.Closed)
                {
                    sqlCon1.Open();

                    string query = "Update Participation2 set Attendance = '" + this.Grade.Text + "'  where Id ='" + this.ID.Text + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon1);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully edited");

                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_ClickSubmit(object sender, RoutedEventArgs e)
        {
            TeacherIntro1 a = new TeacherIntro1();
            a.Show();
            this.Close();
        }
    }
}
