using System.Windows.Controls;
using System.Windows;

namespace Test_ItLab
{
    public partial class Page2 : Page
    {
        private readonly MainViewModel _viewModel;

        public Page2(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
        }

        private void OpenPdf1_Click(object sender, RoutedEventArgs e) => _viewModel.OpenPdf("/Components/Documents/document1.pdf");
        private void OpenPdf2_Click(object sender, RoutedEventArgs e) => _viewModel.OpenPdf("/Components/Documents/document2.pdf");
        private void Submit_Click(object sender, RoutedEventArgs e) => _viewModel.NavigateToPage3();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.NavigateToPage3();
        }
    }
}