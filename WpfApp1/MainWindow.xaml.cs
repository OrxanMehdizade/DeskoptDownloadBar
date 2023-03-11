using System.Windows;

namespace WpfApp1
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

        private void growing_Click(object sender, RoutedEventArgs e)
        {
            Bar.Value += 5;
        }

        private void descending_Click(object sender, RoutedEventArgs e)
        {
            Bar.Value -= 5;
        }


    }
}