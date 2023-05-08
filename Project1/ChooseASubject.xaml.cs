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
    /// Interaction logic for ChooseASubject.xaml
    /// </summary>
    public partial class ChooseASubject : Window
    {
        public ChooseASubject()
        {
            InitializeComponent();
        }

        private void Button_ClickMathematics(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                Math t = new Math();
                t.Show();
                sqlCon1.Open();
                string query = "select * from MathGrades";
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

        private void Button_ClickBG(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                GradesForTeachers t = new GradesForTeachers();
                t.Show();
                sqlCon1.Open();
                string query = "select * from BGLanguageGrades";
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

        private void Button_ClickPhysics(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                Physics t = new Physics();
                t.Show();
                sqlCon1.Open();
                string query = "select * from PhysicsGrades";
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

        private void Button_ClickSports(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                Sports t = new Sports();
                t.Show();
                sqlCon1.Open();
                string query = "select * from SportGrades";
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

        private void Button_ClickCivics(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                Civics t = new Civics();
                t.Show();
                sqlCon1.Open();
                string query = "select * from CivicsGrades";
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

        private void Button_ClickELL(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                ELL t = new ELL();
                t.Show();
                sqlCon1.Open();
                string query = "select * from ELLGrades";
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

        private void Button_ClickInformatics(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(@"Data Source=LAPTOP-3OEEIDU4; Initial Catalog = FinalProject2; Integrated Security = True");

            try
            {
                Informatics t = new Informatics();
                t.Show();
                sqlCon1.Open();
                string query = "select * from InformaticsGrades";
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
    }
}
