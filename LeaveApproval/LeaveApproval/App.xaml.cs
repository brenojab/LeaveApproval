using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace LeaveApproval
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      //MainPage = new LeaveApproval.MainPage();
      MainPage = new View.AprovacaoPage();
      //MainPage = new View.RequestListPage();

    }

    protected override void OnStart()
    {
      // Handle when your app starts

      Microsoft.AppCenter.AppCenter.Start("android=fa8684f2-0e25-4749-9702-ec6d7b1d54ce;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
