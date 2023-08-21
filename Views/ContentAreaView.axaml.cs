using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GUIMvvM.Views;

public partial class ContentAreaView : UserControl
{


    static ContentAreaView? instance;

   public static object Efiel;  
    public ContentAreaView()
    {
        InitializeComponent();
        instance = instance ?? this; 
        

    }

    public static void Navigate(UserControl control)
    {

        if (instance == null) return;

        instance.Content = control;

    }

}