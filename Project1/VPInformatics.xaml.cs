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
    /// Interaction logic for VPInformatics.xaml
    /// </summary>
    public partial class VPInformatics : Window
    {
        public VPInformatics()
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
                string query = "SELECT COUNT(1) FROM AllStudents where Id=@Id and @Password=@Password";

                SqlCommand cmd = new SqlCommand(query, sqlCon1);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.ID.Text);
                cmd.Parameters.AddWithValue("@Password", this.StudentPassword.Password);



                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {



                    StudentGradesPagePrint t = new StudentGradesPagePrint();
                    t.Show();
                  
                    string query2 = $"select * from InformaticsGrades where Id = {this.ID.Text}";
                    SqlCommand cmd1 = new SqlCommand(query2, sqlCon1);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    t.table.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    this.Close();
                    sqlCon1.Close();


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
