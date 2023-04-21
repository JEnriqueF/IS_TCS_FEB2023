using System.Windows;
using System.Windows.Media;

namespace Ejemplo_Radio_Button {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void TipoSeleccion(object sender, RoutedEventArgs e) {
            string nombreColorSeleccion = "";

            if(rbManual.IsChecked == true) {
                if(rbAzul.IsChecked == true) {
                    nombreColorSeleccion = ""+rbAzul.Content;
                    gbArea.Background = Brushes.Blue;
                }else if(rbAmarillo.IsChecked == true){
                    nombreColorSeleccion = "" + rbAmarillo.Content;
                    gbArea.Background = Brushes.Yellow;
                }else if(rbRojo.IsChecked == true) {
                    nombreColorSeleccion = "" + rbRojo.Content;
                    gbArea.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0, 0));
                }else if (rbMorado.IsChecked == true) {
                    nombreColorSeleccion = "" + rbMorado.Content;
                    gbArea.Background = new SolidColorBrush( (Color) ColorConverter.ConvertFromString("#C834FF"));
                } else {
                    nombreColorSeleccion = "" + rbVerde.Content;
                    gbArea.Background = new SolidColorBrush(Colors.Green);
                }
                gbArea.Header = nombreColorSeleccion;
            }
        }

        private void rbAzul_Checked(object sender, RoutedEventArgs e) {
            if(rbAutomática.IsChecked == true) {
                gbArea.Header = rbAzul.Content;
                gbArea.Background = Brushes.Blue;
            }
        }

        private void rbAmarillo_Checked(object sender, RoutedEventArgs e) {
            if (rbAutomática.IsChecked == true) {
                gbArea.Header = rbAmarillo.Content;
                gbArea.Background = Brushes.Yellow;
            }
        }

        private void rbRojo_Checked(object sender, RoutedEventArgs e) {
            if (rbAutomática.IsChecked == true) {
                gbArea.Header = rbRojo.Content;
                gbArea.Background = Brushes.Red;
            }
        }

        private void rbMorado_Checked(object sender, RoutedEventArgs e) {
            if (rbAutomática.IsChecked == true) {
                gbArea.Header = rbMorado.Content;
                gbArea.Background = Brushes.Purple;
            }
        }

        private void rbVerde_Checked(object sender, RoutedEventArgs e) {
            if (rbAutomática.IsChecked == true) {
                gbArea.Header = rbVerde.Content;
                gbArea.Background = Brushes.Green;
            }
        }
    }
}