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
    /// Interaction logic for StudentLogIn.xaml
    /// </summary>

   

    public partial class StudentLogIn : Window
    {
        public StudentLogIn()
        {
            InitializeComponent();

            string username = this.StudentUsername.Text;

        }
                



        public void Button_ClickSubmit(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");
            try
            {
                if (sqlCon1.State == ConnectionState.Closed)
                    sqlCon1.Open();
                string query = "SELECT COUNT(1) FROM AllStudents where Email=@Email and @Password=@Password";

                SqlCommand cmd = new SqlCommand(query, sqlCon1);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SchoolID", this.SchoolID.Text);
                cmd.Parameters.AddWithValue("@Email", this.StudentUsername.Text);
                cmd.Parameters.AddWithValue("@Password", this.StudentPassword.Password);

               

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {


                    //---tova trqbva da go pogledna oshte vednuj, ne znam zashto trqbwa da e takava komandata tuka----

                    StudentInto1 p = new StudentInto1();
                    p.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The username or the password or the School ID are not correct!");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
