using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace felkarurablo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();


        int balance = 100;
        int spinCost = 10;

		List<string> symbols = new List<string>()
		{
			"kep1.jfif",
			"kep2.jfif",
			"kep3.jfif",
			
		};


		public MainWindow()
        {
            InitializeComponent();
            

        
        }

        private void Spin()
        {
			int index = random.Next(symbols.Count);

			string selectedImage = symbols[index];

			slotImage1.Source = new BitmapImage(new Uri(selectedImage, UriKind.Relative));
			slotImage2.Source = new BitmapImage(new Uri(selectedImage, UriKind.Relative));
			slotImage3.Source = new BitmapImage(new Uri(selectedImage, UriKind.Relative));
		}

		private void spinButton_Click(object sender, RoutedEventArgs e)
		{
			Spin();
		}
	}
}