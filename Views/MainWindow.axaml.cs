using Avalonia.Controls;
using Avalonia.Interactivity;
using GUIMvvM.ViewModels;

namespace GUIMvvM.Views
{
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();
        }

        void HomeClick(object e, RoutedEventArgs a)
        {
            if(e is Button btn)
            {
                Model.Hej.IsVisible = true;

                (this.DataContext as MainWindowViewModel).Ersynlig = false; 
            }
        }
    }
}