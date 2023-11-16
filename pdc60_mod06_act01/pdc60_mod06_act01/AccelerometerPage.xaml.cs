using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Accelerometer = Xamarin.Essentials.Accelerometer;

namespace pdc60_mod06_act01
{	
	public partial class AccelerometerPage : ContentPage
	{	
		public AccelerometerPage ()
		{
			InitializeComponent ();
		}

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            LabelX.Text = e.Reading.Acceleration.X.ToString();
            LabelY.Text = e.Reading.Acceleration.Y.ToString();
            LabelZ.Text = e.Reading.Acceleration.Z.ToString();
        }

        private void ButtonStart_Clicked(object sender, EventArgs e)
        {
            if (Accelerometer.IsMonitoring)

                return;

            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            Accelerometer.Start(SensorSpeed.Game);

        }

        private void ButtonStop_Clicked(object sender, EventArgs e)
        {
            if (!Accelerometer.IsMonitoring)

                return;

            Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
            Accelerometer.Stop();

        }
    }
}

