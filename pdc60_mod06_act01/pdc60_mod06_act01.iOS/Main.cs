using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace pdc60_mod06_act01.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}

