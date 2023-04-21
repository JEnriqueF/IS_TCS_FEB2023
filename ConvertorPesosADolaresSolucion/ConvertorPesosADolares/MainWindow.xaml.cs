using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConvertorPesosADolares{
    public partial class MainWindow : Window{
        double valorDolar = 17.99, pesos, dolares, resultadoADolar, resultadoAPeso;

        public MainWindow(){
            InitializeComponent();
        }

        private void LeerPesos(object sender, TextChangedEventArgs e){
            if (!string.IsNullOrEmpty(tbPesos.Text) && double.TryParse(tbPesos.Text, out pesos)){
                resultadoADolar = pesos / valorDolar;
                lbResultadoEnDolares.Text = "$" + pesos + " MXN son $" + resultadoADolar + " USD.";
            }else{
                lbResultadoEnDolares.Text = "Introduce un valor numérico.";
            }
        }

        private void LeerDolares(object sender, TextChangedEventArgs e){
            if(!string.IsNullOrEmpty(tbDolares.Text) && double.TryParse(tbDolares.Text, out dolares)){
                resultadoAPeso = dolares * valorDolar;
                lbResultadoEnPesos.Text = "$" + dolares + " USD son $" + resultadoAPeso + " MXN.";
            }else{
                lbResultadoEnPesos.Text = "Introduce un valor numérico.";
            }
        }
    }
}