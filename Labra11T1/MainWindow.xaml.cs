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

namespace Labra11T1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Milk.IsChecked)
            {
                List.Text += "Milk\n";
            }
            if ((bool)Butter.IsChecked)
            {
                List.Text += "Butter\n";
            }
            if ((bool)Chicken.IsChecked)
            {
                List.Text += "Chicken\n";
            }
            if ((bool)Beer.IsChecked)
            {
                List.Text += "Beer\n";
            }
            if ((bool)Lemonade.IsChecked)
            {
                List.Text += "Lemonade\n";
            }
        }
    }
}