using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp16.ViewModels;
using WpfApp3.Command;

namespace WpfApp3.Views
{

    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {



            MainViewModel? viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                int selectedIndex = combo.SelectedIndex;




                marka.Text = viewModel.markaNames[selectedIndex];
                model.Text = viewModel.modelNames[selectedIndex];
                year.Text = viewModel.yearNames[selectedIndex];
            }

        }
        private void CarImage_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Tıklanan arabaya ait bilgileri almak için bir model sınıfı oluşturabilirsiniz
            CarInfo selectedCar = new CarInfo();

            Image clickedImage = sender as Image;
            if (clickedImage != null && clickedImage.Tag is string carTag)
            {
                // Araba etiketini kullanarak hangi arabaya tıklandığını anlayabiliriz
                switch (carTag)
                {
                    case "Priora":
                        selectedCar.Model = "Priora";
                        selectedCar.Motor = "2.0L Benzin";
                        selectedCar.Year = 2022;
                        selectedCar.Kilometers = 15000;
                        selectedCar.Price = 25000;
                        selectedCar.Color = "Mavi";
                        selectedCar.ImageSource = "/image/priora.jpg";
                        break;
                    case "Tuareg":
                        selectedCar.Model = "Tuareg";
                        selectedCar.Motor = "3.2L benzin";
                        selectedCar.Year = 2008;
                        selectedCar.Kilometers = 12000;
                        selectedCar.Price = 35000;
                        selectedCar.Color = "qara";
                        selectedCar.ImageSource = "/Image/tuareg.jpg";
                        break;
                    case "4Goz":
                        selectedCar.Model = "Mercedes e320";
                        selectedCar.Motor = "3.2L benzin";
                        selectedCar.Year = 1999;
                        selectedCar.Kilometers = 123000;
                        selectedCar.Price = 15000;
                        selectedCar.Color = "Gri";
                        selectedCar.ImageSource = "/Image/4goz.jpg";
                        break;
                    case "e60":
                        selectedCar.Model = "BMW e60";
                        selectedCar.Motor = "5.5L Benzin";
                        selectedCar.Year = 1999;
                        selectedCar.Kilometers = 12000;
                        selectedCar.Price = 15000;
                        selectedCar.Color = "Gri";
                        selectedCar.ImageSource = "//Image/60kuza.jpg";
                        break;
                    case "camry":
                        selectedCar.Model = "camry";
                        selectedCar.Motor = "2.5L Benzin";
                        selectedCar.Year = 2022;
                        selectedCar.Kilometers = 0;
                        selectedCar.Price = 35000;
                        selectedCar.Color = "white";
                        selectedCar.ImageSource = "/Image/camry.jpg";
                        break;
                    case "2107":
                        selectedCar.Model = "2107";
                        selectedCar.Motor = "2.5L Benzin";
                        selectedCar.Year = 2022;
                        selectedCar.Kilometers = 0;
                        selectedCar.Price = 35000;
                        selectedCar.Color = "white";
                        selectedCar.ImageSource = "/Image/07.jpg";
                        break;
                    // Diğer arabalar için de case'ler ekleyin
                    default:
                        break;
                }

                // Yeni pencereyi açıp bilgileri göstermek için CarDetailsView adında yeni bir pencere oluşturun
                CarDetailsView carDetailsView = new CarDetailsView(selectedCar);
                carDetailsView.Show();
            }
        }

        // CarInfo adında basit bir arabaya ait bilgileri içeren bir model sınıfı tanımlayın
        public class CarInfo
        {
            public string Model { get; set; }
            public string Motor { get; set; }
            public int Year { get; set; }
            public int Kilometers { get; set; }
            public decimal Price { get; set; }
            public string Color { get; set; }
            public string ImageSource { get; internal set; }
        }
    }

}
    


 
