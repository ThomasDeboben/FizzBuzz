namespace FizzBuzzWpf
{
    using System.Windows;

    using FizzBuzzLib;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The run fizz buzz.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event argument.</param>
        private void RunFizzBuzz(object sender, RoutedEventArgs e)
        {
            var fizzbuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                var result = fizzbuzz.GetFizzBuzzFormattedString(i);
                this.FizzBuzzListBox.Items.Add(result);
            }
        }
    }
}
