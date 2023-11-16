using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Connectivity = Xamarin.Essentials.Connectivity;

namespace pdc60_mod06_act01
{	
	public partial class ConnectivityPage : ContentPage
	{	
		public ConnectivityPage ()
		{
			InitializeComponent ();
		}

        private void Connectivity_Clicked(object sender, EventArgs e)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DisplayAlert("No Internet", "Please connect to the internet", "Ok");
                return;
            }
        }
    }
}

