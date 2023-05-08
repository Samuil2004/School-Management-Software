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
    /// Interaction logic for Sports.xaml
    /// </summary>
    public partial class Sports : Window
    {
        public Sports()
        {
            InitializeComponent();
        }

        private void Button_ClickSubmit(object sender, RoutedEventArgs e)
        {
            TeacherIntro1 p = new TeacherIntro1();
            p.Show();
            this.Close();
        }

       

        private void Button_ClickEdit(object sender, RoutedEventArgs e)
        {


            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                if (sqlCon1.State == ConnectionState.Closed)
                {
                    sqlCon1.Open();

                    string query = "Update SportGrades set SportFitnessTest = '" + this.Grade.Text + "'  where Id ='" + this.ID.Text + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon1);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully edited");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}

