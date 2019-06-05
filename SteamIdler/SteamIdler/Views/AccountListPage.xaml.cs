﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SteamIdler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountListPage : ContentPage
    {
        public AccountListPage()
        {
            InitializeComponent();
        }

        #region Private Methods
        private async Task NavigateToLoginPage()
        {
            await Navigation.PushAsync(new LoginPage());
        }
        #endregion

        #region Event Handlers
        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await NavigateToLoginPage();
        }
        #endregion
    }
}