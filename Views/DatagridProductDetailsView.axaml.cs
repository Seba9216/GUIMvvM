using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GUIMvvM.Models;
using GUIMvvM.ViewModels;

namespace GUIMvvM.Views;

public partial class DatagridProductDetailsView : UserControl
{
    public DatagridProductDetailsView()
    {
        InitializeComponent();
        DataContext = new DatagridProductDetailsViewModel(ContentAreaView.Efiel as Produkt);
    }
}