using System.Windows;

namespace WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyOtherClick;

        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            myOtherLabel.Content = "Copyright 2016 joedaouddotcom";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Github commit 
            myLabel.Content = "Hello world!";
            myLabel.Opacity = 100;



        }
    }
}
