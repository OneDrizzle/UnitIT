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
using UnitItWPF.MVVM.ViewModel;

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
            DataContext = mvm;
        }

        MainViewModel mvm = new MainViewModel();

        


        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Add_New_Customer_Button_Click(object sender, RoutedEventArgs e)
        {
            string name = textbox_New_Customer.Text;
            mvm.cRepo.customers.Add(name);
        }


        private void Button_Showcomponent(object sender, RoutedEventArgs e)
        {
            IEnumerable<UnitITICBM.Models.Customer> listToView = mvm.cRepo.customers.GetAll();
            Datagrid_Customers.ItemsSource = listToView;
            Datagrid_Customers.DataContext = mvm.Update_Datagrid();
            
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }


        private void Textbox_New_Customer_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
    

