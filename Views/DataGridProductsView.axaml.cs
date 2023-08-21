using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using GUIMvvM.Models;
using GUIMvvM.ViewModels;

namespace GUIMvvM.Views;

public partial class DataGridProductsView : UserControl
{
    public DataGridProductsView()
    {
        InitializeComponent();
        DataContext= new DataGridProductViewModel();
        Hej.Tapped += chosen;

    }

    public void chosen(object sender, RoutedEventArgs e)
    {
        
        if (sender is DataGrid data)
        {
            var item = data.SelectedItem as Produkt;
            if (item == null) return;
            ContentAreaView.Efiel = item; 
            ContentAreaView.Navigate(new DatagridProductDetailsView());
        }
    }
}