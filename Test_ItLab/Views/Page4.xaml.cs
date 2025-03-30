using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Test_ItLab
{
    public partial class Page4 : Page
    {
        private readonly MainViewModel _viewModel;
        public Page4(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;

            Task.WaitAll(new Task[] { Task.Delay(2000) });
            _viewModel.NavigateToPage1();

        }
        private void OpenPdf1_Click(object sender, RoutedEventArgs e) => _viewModel.OpenPdf("../Documents/document1.pdf");
        private void OpenPdf2_Click(object sender, RoutedEventArgs e) => _viewModel.OpenPdf("../Documents/document2.pdf");
    }
}