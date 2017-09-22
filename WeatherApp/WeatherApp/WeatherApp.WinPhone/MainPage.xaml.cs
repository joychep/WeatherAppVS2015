using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WeatherApp.WinPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                locationText.Text = weather.Title;
                tempText.Text = weather.Temperature;
                windText.Text = weather.Wind;
                visibilityText.Text = weather.Visibility;
                humidityText.Text = weather.Humidity;
                sunriseText.Text = weather.Sunrise;
                sunsetText.Text = weather.Sunset;

                weatherBtn.Content = "Search Again";
            }
        }
    }
}
