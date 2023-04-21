using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace PatronObserver {
    public partial class MainWindow : Window {
        List<string> listaColores = new List<string>();
        ObservableCollection<string> listaColoresObserver = new ObservableCollection<string>();

        public MainWindow() {
            InitializeComponent();
            listaColores.Add("Rojo");
            cbColores.ItemsSource = listaColoresObserver;
        }

        private void agregarColor(object sender, RoutedEventArgs e) {
            string nuevoColor = tbColor.Text;
            
            if(nuevoColor.Length > 0 ) {
                /*listaColores.Add(nuevoColor);
                cbColores.ItemsSource = null;
                cbColores.ItemsSource = listaColores;*/

                listaColoresObserver.Add(nuevoColor);
                tbColor.Text = "";
            }
        }
    }
}
