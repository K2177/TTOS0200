using System.Windows;

namespace Labra10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int cars;
        int trucks;
        private void Trucks_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            TrucksNum.Text = trucks.ToString();
        }
        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            CarsNum.Text = cars.ToString();
        }
    }
}