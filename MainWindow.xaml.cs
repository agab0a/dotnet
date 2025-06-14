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

namespace WpfApp1
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
        QlbenhNhanContext db = new QlbenhNhanContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgvHienThi.ItemsSource = (from bn in db.BenhNhans
                                      where bn.SongayNv <= 20
                                      orderby bn.SongayNv descending
                                      select new
                                      {
                                          bn.Mabn,
                                          bn.Hoten,
                                          bn.Diachi,
                                          bn.SongayNv,
                                          bn.Makhoa,
                                          VienPhi = bn.SongayNv * 60000
                                      }).ToList();

        }
    } 
}