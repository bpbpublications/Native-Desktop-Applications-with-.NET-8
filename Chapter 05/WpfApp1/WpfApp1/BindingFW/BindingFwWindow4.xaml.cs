using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.BindingFW
{
    /// <summary>
    /// Interaction logic for BindingFwWindow4.xaml
    /// </summary>
    public partial class BindingFwWindow4 : Window
    {
        ObservableCollection<Fruit> fruits = new ObservableCollection<Fruit>();

        public BindingFwWindow4()
        {
            InitializeComponent();

            fruits.Add(new Fruit { Name = "Apple" });
            fruits.Add(new Fruit { Name = "Mango" });
            fruits.Add(new Fruit { Name = "Banana" });
            fruits.Add(new Fruit { Name = "Orange" });

            lbFruits.ItemsSource = fruits;
            lbFruits.DisplayMemberPath = "Name";
        }


        private void lbFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                txtFruit.Text = (lbFruits.SelectedItem as Fruit).Name;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                (lbFruits.SelectedItem as Fruit).Name = txtFruit.Text;
            }
        }
    }

  
    public class Fruit : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;

                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
    }
}
