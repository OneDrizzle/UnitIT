using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace UnitItWPF.MVVM.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
        }



        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void add_New_Customer_Button_Click(object sender, RoutedEventArgs e)
        {

           /* SqlConnection conn = new SqlConnection("Server=10.56.8.35;Database=B_EKSDB01_2021;User Id=B_EKS01;Password=B_OPENDB01");

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT * INTO [CUSTOMERS] (CustomerName)values(@nm)";
                cmd.Parameters.AddWithValue("@nm", Datagrid_Customers.ItemsSource);
                cmd.Connection = conn;


            
                SqlConnection conn = new SqlConnection("Server=10.56.8.35;Database=B_EKSDB01_2021;User Id=B_EKS01;Password=B_OPENDB01");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO [CUSTOMERS] (CustomerName) VALUES (@nm))";
                cmd.Parameters.AddWithValue("@nm", textbox_New_Customer.Text);
                cmd.Connection = conn;

                int a = cmd.ExecuteNonQuery();

                if (a == 1)
                {
                    MessageBox.Show("Data added");

                }*/
            }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=10.56.8.35;Database=B_EKSDB01_2021;User Id=B_EKS01;Password=B_OPENDB01");

            try
            {
                conn.Open();
                string Query = "SELECT * FROM CUSTOMERS  ";
                SqlCommand createCommand = new SqlCommand(Query, conn);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Customers");
                dataAdp.Fill(dt);
                Datagrid_Customers.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);

                conn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textbox_New_Customer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
    

