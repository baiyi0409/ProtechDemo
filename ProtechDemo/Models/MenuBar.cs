using CommunityToolkit.Mvvm.ComponentModel;
using ProtechDemo.ViewModels;

namespace ProtechDemo.Models;

public partial class MenuBar: ViewModelBase
{
    /// <summary>
    /// 图标
    /// </summary>
    [ObservableProperty] private string icon;

    /// <summary>
    /// 名称
    /// </summary>
    [ObservableProperty] private string displayName;
}