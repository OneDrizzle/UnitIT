using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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


        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Textbox_New_Customer_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Ændre_Komponent_Button_Checked(object sender, RoutedEventArgs e)
        {
            if (mvm.SelectedItem != null)
            {
                IEnumerable<UnitITICBM.Models.CI> listToView = mvm.cRepo.GetAll(mvm.SelectedItem.CustomerID);
                Datagrid_Customers.ItemsSource = listToView;
            }

            else
            {

                MessageBox.Show("Kunde ikke valgt!");

            }
        }

        private void Slet_Komponent_Button_Checked(object sender, RoutedEventArgs e)
        {

            mvm.cRepo.Delete(mvm.SelectedItem.CustomerID);
            //IEnumerable<UnitITICBM.Persistance.CustomerRepositoryDB> CustomerToDelete = mvm.cRepo.Delete(ID = mvm.SelectedItem.CustomerID);
            //Datagrid_Customers.SelectedItem = CustomerToDelete;
        }
    }
}


