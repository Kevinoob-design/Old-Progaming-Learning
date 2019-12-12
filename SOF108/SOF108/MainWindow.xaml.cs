using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SOF108
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ConexionBDD c = new ConexionBDD();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadingData()
        {
            c.CargarDatosEmploye(DataShowEmploye);
            c.CargarDatosHistory(DataShowHistory);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadingData();
        }
    }
}
