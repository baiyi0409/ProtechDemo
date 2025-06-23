using CommunityToolkit.Mvvm.ComponentModel;
using ProtechDemo.ViewModels;

namespace ProtechDemo.Models;

public partial class Goods:ViewModelBase
{
    /// <summary>
    /// 商品图片路径
    /// </summary>
    [ObservableProperty] private string imageUrl;
    
    /// <summary>
    /// 商品名称
    /// </summary>
    [ObservableProperty] private string name;
    
    /// <summary>
    /// 商品品牌
    /// </summary>
    [ObservableProperty] private string brand;

    /// <summary>
    /// 商品折扣
    /// </summary>
    [ObservableProperty] private double discount;
    
    /// <summary>
    /// 商品价格
    /// </summary>
    [ObservableProperty] private string price;

    /// <summary>
    /// 商品折扣价格
    /// </summary>
    [ObservableProperty] private string discountPrice;
    
    /// <summary>
    /// 商品评分
    /// </summary>
    [ObservableProperty] private string score;
    
    /// <summary>
    /// 是否喜欢
    /// </summary>
    [ObservableProperty] private bool favorite;
}