

namespace AppTeachSolu.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using AppTeachSolu.Services;
    using Common.Models;
    using Xamarin.Forms;

    public class ProyectsViewModel : BaseViewModel
    {
        private ApiService apiService;

        private ObservableCollection<Services> proyects;

        public ObservableCollection<Services> Proyects
        {
            get { return this.proyects; }
            set { this.SetValue(ref this.proyects, value); }
        }

        public ProyectsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProyects();
        }

        private async void LoadProyects()
        {
            var response = await this.apiService.GetList<Services>("http://appteachsoluapi.azurewebsites.net", "/api", "/Services");
            if (!response.IsSuccess) {
                await Application.Current.MainPage.DisplayAlert("Error", response.message, "Accept");
                return;
            }
            var list = (List<Services>)response.Result;
            this.Proyects = new ObservableCollection<Services>(list);
        }

    }
}
