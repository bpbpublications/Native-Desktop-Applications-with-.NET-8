using System;
using System.Collections.Generic;
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
    /// Interaction logic for BindingFwWindow2.xaml
    /// </summary>
    public partial class BindingFwWindow2 : Window
    {
        public BindingFwWindow2()
        {
            InitializeComponent();
            
            txtBG.DataContext = sPanel;

            //Binding binding = new Binding("Background");
            ////binding.Source = sPanel;
            //binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            //txtBG.SetBinding(TextBox.TextProperty, binding);

        }
    }
}
