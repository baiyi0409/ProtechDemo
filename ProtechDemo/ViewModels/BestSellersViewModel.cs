using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using ProtechDemo.Models;

namespace ProtechDemo.ViewModels;

public partial class BestSellersViewModel: ViewModelBase
{
    public BestSellersViewModel()
    {
        CreateGoods();
    }
    public IEnumerable BrandsItems { get; set; } = new List<string> { "APPLE", "LG", "KitchenAid", "SMEG", "Samsung","Sony" };

    
    [ObservableProperty] private ObservableCollection<Goods> goodsList;
    
    private void CreateGoods()
    {
        GoodsList = new ObservableCollection<Goods>();
        GoodsList.Add(new Goods() {
            Brand = "SMEG",
            Score = "5.0",
            Price = "985.99",
            Discount = 0.15,
            DiscountPrice = (double.Parse("985.99") * (1 - 0.15)).ToString(),
            Name = "Coffee Machine",
            Favorite = false,
            ImageUrl = new Bitmap(AssetLoader.Open(new Uri("avares://ProtechDemo/Assets/Coffee.png")))
        });
        GoodsList.Add(new Goods() {
            Brand = "APPLE",
            Score = "4.8",
            Price = "1130.00",
            Discount = 0,
            DiscountPrice = (double.Parse("1130.00") * (1 + 0)).ToString(),
            Name = "iPhone 16 Pro 128GB",
            Favorite = true,
            ImageUrl = new Bitmap(AssetLoader.Open(new Uri("avares://ProtechDemo/Assets/iPhone.png")))
        });
        GoodsList.Add(new Goods() {
            Brand = "APPLE",
            Score = "4.9",
            Price = "799.00",
            Discount = 0,
            DiscountPrice = (double.Parse("799.00") * (1 + 0)).ToString(),
            Name = "Air Pods Max",
            Favorite = false,
            ImageUrl = new Bitmap(AssetLoader.Open(new Uri("avares://ProtechDemo/Assets/AirPods.png")))
        });
    }
}