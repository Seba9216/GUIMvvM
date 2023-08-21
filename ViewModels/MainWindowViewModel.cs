using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using GUIMvvM.Models;
using GUIMvvM.Views;
using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reflection;

namespace GUIMvvM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        


        public MainWindowViewModel()
        {
            model = new DataGridProductViewModel();
            model2 = new DatagridProductDetailsViewModel();
            model.PropertyChanged += Model_PropertyChanged;
            model.clickdatagridEvent += Model_clickdatagridEvent;
        }

        private bool _ersynlig;

        public bool Ersynlig
        {
            get
            {
                return _ersynlig;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _ersynlig, value, nameof(Ersynlig));
            }
        }
        private void Model_clickdatagridEvent(object sender, ClickdatagridEvent e)
        {
           
            Ersynlig = true;
            model2.Produkt = e.Clicked;
            

        }

        private void Model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            

        }

        public DataGridProductViewModel model { get; set; }


        public DatagridProductDetailsViewModel model2 { get; set; }

   

    }




}