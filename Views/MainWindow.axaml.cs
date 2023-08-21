using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GUIMvvM.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentAreaView.Navigate(new DataGridProductsView()); 

        }

        void HomeClick(object e, RoutedEventArgs a)
        {
            if(e is Button btn)
            {
                ContentAreaView.Navigate(new DataGridProductsView());
            }
        }
    }
}