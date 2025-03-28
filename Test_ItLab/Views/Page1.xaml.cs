using System.Windows.Controls;
using System.Windows;

namespace Test_ItLab
{
    public partial class Page1 : Page
    {
        private readonly MainViewModel _viewModel;

        public Page1(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.NavigateToPage2();
        }
    }
}