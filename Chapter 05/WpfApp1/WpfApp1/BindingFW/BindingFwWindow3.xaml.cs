using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1.BindingFW
{
    /// <summary>
    /// Interaction logic for BindingFwWindow3.xaml
    /// </summary>
    public partial class BindingFwWindow3 : Window
    {
        ObservableCollection<string> fruits = new ObservableCollection<string>();

        public BindingFwWindow3()
        {
            InitializeComponent();

            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Orange");

            lbFruits.ItemsSource = fruits;

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lbFruits.SelectedItem != null)
            {
                string selectedFruit = lbFruits.SelectedItem.ToString();
                fruits.Remove(selectedFruit);

                MessageBox.Show($"Fruit { selectedFruit } removed.");
            }
        }

        private void lbFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbFruits.SelectedItem != null)
            {
                txtFruit.Text = lbFruits.SelectedItem as string;

            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                fruits[lbFruits.SelectedIndex] = txtFruit.Text;
            }
        }

        
    }
}
