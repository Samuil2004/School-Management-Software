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
    /// Interaction logic for AddAPerson.xaml
    /// </summary>
    public partial class AddAPerson : Window
    {
        public AddAPerson()
        {
            InitializeComponent();
        }

        private void Button_ClickStudent(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                if (sqlCon1.State == ConnectionState.Closed)
                    sqlCon1.Open();
                string query = "INSERT INTO AllStudents (SchoolID, FirstName, LastName, Email, Password) values ('" + this.SchoolID.Text + "','" + this.FirstName.Text + "','" + this.LastName.Text + "', '" + this.Username.Text + "', '" + this.Password.Password + "')";

                SqlCommand cmd = new SqlCommand(query, sqlCon1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully added");
                MainWindow p = new MainWindow();
                p.Show();
                this.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_ClickTeacher(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                if (sqlCon1.State == ConnectionState.Closed)
                    sqlCon1.Open();
                string query = "INSERT INTO AllTeachers (SchoolID, FirstName, LastName, Email, Password) values ('" + this.SchoolID.Text + "','" + this.FirstName.Text + "','" + this.LastName.Text + "', '" + this.Username.Text + "', '" + this.Password.Password + "')";

                SqlCommand cmd = new SqlCommand(query, sqlCon1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully added");
                MainWindow p = new MainWindow();
                p.Show();
                this.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
