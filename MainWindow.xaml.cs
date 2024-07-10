using System.Collections.ObjectModel;
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

namespace CoinViewUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollection<CryptoCurrency> Cryptocurrencies { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;

        // Inicializar la colección de criptomonedas (esto es un ejemplo, debes llenarla con datos reales)
        Cryptocurrencies = new ObservableCollection<CryptoCurrency>
        {
            new CryptoCurrency { Name = "Bitcoin", Price = "$4000", Change = "0.05 %", MarketCap = "750M" },
            new CryptoCurrency { Name = "Ethereum", Price = "$2500", Change = "-0.02 %", MarketCap = "300M" },
            new CryptoCurrency { Name = "Bitcoin", Price = "$4000", Change = "0.05 %", MarketCap = "750M" }
        };
    }
    public class CryptoCurrency
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Change { get; set; }
        public string MarketCap { get; set; }
    }

}