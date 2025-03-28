using System.Windows.Controls;

namespace Test_ItLab
{
    public partial class Page4 : Page
    {
        public Page4(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}