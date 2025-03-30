using System.Windows.Controls;
using System.Windows;

namespace Test_ItLab
{
    public partial class Page3 : Page
    {
        private readonly MainViewModel _viewModel;

        public Page3(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
            Loaded += (s, e) => Box1.Focus();
        }

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.Length == 1)
            {
                if (box == Box1) Box2.Focus();
                else if (box == Box2) Box3.Focus();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) => _viewModel.VerifyCode();
        private void OpenPdf1_Click(object sender, RoutedEventArgs e) => _viewModel.OpenPdf("../Documents/document1.pdf");
        private void OpenPdf2_Click(object sender, RoutedEventArgs e) => _viewModel.OpenPdf("../Documents/document2.pdf");
    }
}