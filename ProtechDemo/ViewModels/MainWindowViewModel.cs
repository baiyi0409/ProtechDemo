using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProtechDemo.Models;

namespace ProtechDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        CreateMenuBar();
    }
    
    [ObservableProperty] private ObservableCollection<MenuBar> menuBars;
    
    private void CreateMenuBar()
    {
        MenuBars = new ObservableCollection<MenuBar>();
        MenuBars.Add(new MenuBar(){Icon = "",DisplayName = "Catalog"});
        MenuBars.Add(new MenuBar(){Icon = "",DisplayName = "BestSellers"});
    }
    
    [ObservableProperty] private object content;
    
    [RelayCommand]
    private void Navigate(MenuBar item)
    {
        if (item == null || string.IsNullOrWhiteSpace(item.DisplayName))
            return;
        
        var viewModelName = $"{item.DisplayName}ViewModel";
        Type viewModelType = Assembly.GetExecutingAssembly().GetTypes()
            .FirstOrDefault(t => t.Name.Equals(viewModelName, StringComparison.OrdinalIgnoreCase));
        
        if (viewModelType != null && typeof(ViewModelBase).IsAssignableFrom(viewModelType))
        {
            // 使用 Activator 创建 ViewModel 实例
            Content = Activator.CreateInstance(viewModelType);
        }
    }
}