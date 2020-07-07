using System;
using Xamarin.Forms;

namespace XFKidzeeZone.Tizen
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            MainWindow.IndicatorMode = ElmSharp.IndicatorMode.Hide;
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            Forms.Init(app, true);
            app.Run(args);
        }
    }
}
