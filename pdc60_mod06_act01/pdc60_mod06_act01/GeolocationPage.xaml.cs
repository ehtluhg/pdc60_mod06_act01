using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace pdc60_mod06_act01
{	
	public partial class GeolocationPage : ContentPage
	{
        bool isGettingLocation;
        public GeolocationPage ()
		{
			InitializeComponent ();
		}

        async void Start_Locate(System.Object sender, System.EventArgs e)
        {
            isGettingLocation = true;
            while (isGettingLocation)
            {
                var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));

                resultLocation.Text += $"lat: {result.Latitude}, lng: {result.Longitude}{Environment.NewLine}";
                await Task.Delay(1000);
            }
        }

        private void Stop_Locate(System.Object sender, System.EventArgs e)
        {
            isGettingLocation = false;
        }
    }
}

