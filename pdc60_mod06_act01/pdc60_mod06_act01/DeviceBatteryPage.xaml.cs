using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Battery = Xamarin.Essentials.Battery;

namespace pdc60_mod06_act01
{	
	public partial class DeviceBatteryPage : ContentPage
	{
        public DeviceBatteryPage()
        {
            InitializeComponent();

            SetBackground(Battery.ChargeLevel, Battery.State == BatteryState.Charging);

        }


        void SetBackground(double level, bool charging)
        {
            Color? color = null;
            var status = charging ? "Charging" : "Not charging";
            if (level > 0.5f)
            {
                color = Color.Green.MultiplyAlpha(level);
            }
            else if (level > .1f)
            {
                color = Color.Orange.MultiplyAlpha(level);
            }
            else
            {
                color = Color.Red.MultiplyAlpha(level);
            }

            BackgroundColor = color.Value;
            LabelBatteryLevel.Text = status;
        }

        void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            SetBackground(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
        }
    }
}

