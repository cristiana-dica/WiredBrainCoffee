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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WiredBrainCoffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Add_Customer(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMovNavigation_Click(object sender, RoutedEventArgs e)
        {
            var column = Grid.GetColumn(customerListGrid);

            var newColumn = column == 0 ? 2 : 0;

            customerListGrid.SetValue(Grid.ColumnProperty, newColumn);

        }
    }
}
