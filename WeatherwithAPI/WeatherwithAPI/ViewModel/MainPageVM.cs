using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherwithAPI.Model;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeatherwithAPI.ViewModel
{
    internal class MainPageVM : INotifyPropertyChanged
    {
        private WeatherModel data;

        public WeatherModel Data
        {
            get => data;
            set { data = value; 
                OnPropertyChanged();    
            }
        }

        public Command buscarData { get; set; }


        public MainPageVM()
        {
            //Use callback functions
            data = new WeatherModel();
            buscarData = new Command(async (coordenadas)=> {
                var entry = coordenadas as string;
                var data = entry.Split(',');
                string uri = $"https://api.weatherbit.io/v2.0/current?lat={data[0]}&lon={data[1]}&key=97a9a3fe9a9644a98538cf102a260d5c";
                await GetData(uri);
            });       
        }

        //Call to API
        private async Task GetData(string url) 
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WeatherModel>(json);

            Data = result;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
