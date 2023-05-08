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
using System.Data.SqlClient;
using System.Data;

namespace Project1
{
    /// <summary>
    /// Interaction logic for AdminLogIn.xaml
    /// </summary>
    public partial class AdminLogIn : Window
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void Button_ClickSubmit(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");
            try
            {
                if (sqlCon1.State == ConnectionState.Closed)
                    sqlCon1.Open();
                string query = "SELECT COUNT(1) FROM AllAdmins where Email=@Email and @Password=@Password";

                SqlCommand cmd = new SqlCommand(query, sqlCon1);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", this.AdminUsername.Text);
                cmd.Parameters.AddWithValue("@Password", this.AdminPassword.Password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    AddAPerson p = new AddAPerson();
                    p.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The username or the password are not correct!");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
