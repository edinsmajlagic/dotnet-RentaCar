﻿using CarHireRC.Mobile.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarHireRC.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
              
                new HomeMenuItem {Id = MenuItemType.KorisnickiProfil, Title="Korisnički profil",IconSource="user.png" },
                new HomeMenuItem {Id = MenuItemType.Poruke, Title="Poruke",IconSource="envelope.png" },
                new HomeMenuItem {Id = MenuItemType.MojeRezervacije, Title="Moje rezervacije",IconSource="car.png" },
                new HomeMenuItem {Id = MenuItemType.Vozila, Title="Vozila",IconSource="transports.png" },
                new HomeMenuItem {Id = MenuItemType.OdjaviSe, Title="Odjavi se" },
            };
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;
                
                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                if (id == 6)
                    Application.Current.MainPage = new LoginPage();
                else
                    await RootPage.NavigateFromMenu(id);
            };
        }
    }
}