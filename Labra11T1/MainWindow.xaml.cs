using System.Windows;

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
            List.Clear();
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
                List.Text += "Lemonade";
            }
        }
    }
}