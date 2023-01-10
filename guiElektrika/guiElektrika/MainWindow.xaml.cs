using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace guiElektrika
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ElektrikaEntities ee = new ElektrikaEntities();
            DateTime dt = DateTime.Parse("18.8.2013");
            var mpoh = from p in ee.Meritve
                       where DbFunctions.TruncateTime(p.ZapisČas.Value) == dt
                       group p by p.ZapisČas.Value.Hour into g
                       select new { ura = g.Key, moč = g.Average(a => a.kW1 + a.kW2 + a.kW3) };
            CollectionViewSource cvs = (CollectionViewSource)this.FindResource("cvs");
            cvs.Source = mpoh;
        }
    }
}
