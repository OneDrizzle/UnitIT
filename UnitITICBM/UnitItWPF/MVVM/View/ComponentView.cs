using System.Collections.Generic;
using System.Data.Linq;
using System.Windows;
using System.Windows.Controls;
using UnitItWPF.MVVM.ViewModel;

namespace UnitItWPF.MVVM.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class ComponentView : UserControl
    {
        public ComponentView()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        MainViewModel mvm = new MainViewModel();



        private void Button_Showcomponent(object sender, RoutedEventArgs e)
        {
            IEnumerable<UnitITICBM.Models.CI> listToView = mvm.cRepo.GetAll();
            Datagrid_Component.ItemsSource = listToView;
        }

        private void Ændre_Komponent_Button_Checked(object sender, RoutedEventArgs e)
        {
            if (mvm.SelectedItem != null && mvm.SelectedItem is UnitITICBM.Models.CI c)
            {
                IEnumerable<UnitITICBM.Models.CI> listToView = mvm.cRepo.GetAll(c.Customer.CustomerID);
                Datagrid_Component.ItemsSource = listToView;
            }

            else
            {

                MessageBox.Show("Kunde ikke valgt!");

            }
        }

        private void Slet_Komponent_Button_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Textbox_New_Component_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_New_Component_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

  

}

