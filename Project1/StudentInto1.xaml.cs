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
    /// Interaction logic for StudentInto1.xaml
    /// </summary>
    public partial class StudentInto1 : Window
    {
        public StudentInto1()
        {
            InitializeComponent();
        }

        private void Button_ClickSchedule(object sender, RoutedEventArgs e)
        {
            StudentSchedule p = new StudentSchedule();
            p.Show();
            this.Close();
        }

        private void Button_ClickGrades(object sender, RoutedEventArgs e)
        {
            StudentsGradesPage p = new StudentsGradesPage();
            p.Show();
            this.Close();

            //SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            //try
            //{
            //    StudentsGradesPage p = new StudentsGradesPage();
            //    p.Show();
            //    sqlCon1.Open();
            //    string query = $"select avg(sum(MathTest,MathQuiz,MathHomework,MathClasswork,MathFinalExam))\r\n  from MathGrades\r\nwhere Email = {StudentLogIn.StudentUsername} ";

            //}


            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //this.Close();
        }

        private void Button_ClickTeachers(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

                try
                {
                    TeachersSubjects t = new TeachersSubjects();
                    t.Show();
                    sqlCon1.Open();
                    string query = "select * from TeacherSubject";
                    SqlCommand cmd = new SqlCommand(query, sqlCon1);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    t.table.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    this.Close();
                    sqlCon1.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        

        private void Button_ClickParticipation(object sender, RoutedEventArgs e)
        {
            VPP p = new VPP();
            p.Show();
            this.Close();
        }

        
    }
}
