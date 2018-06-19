using LeaveApproval.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LeaveApproval.View
{
  public class AprovacaoPage : ContentPage
  {
    StackLayout mainStack;
    StackLayout insideStack;

    public AprovacaoPage()
    {

      Content = GetMainStack();
      this.BackgroundColor = Constants.DEFAULT_MAIN_BACKGROUND_COLOR;

      try
      {
        throw new Exception("AppCenter exception!");
      }
      catch (Exception exception)
      {
        var properties = new Dictionary<string, string> { { "Category", "Music" }, { "Wifi", "On" } };

        Microsoft.AppCenter.Crashes.Crashes.TrackError(exception, properties);
      }

    }

    private StackLayout GetMainStack()
    {
      Label lblData = new Label()
      {
        Text = $"Data da solicitação: {DateTime.Now.ToString()}",
        HorizontalOptions = LayoutOptions.Center,
        HeightRequest = 100,
        TextColor = Constants.DEFAULT_TEXT_COLOR,
        FontAttributes = FontAttributes.Bold
      };

      lblData.FontSize = Device.GetNamedSize(NamedSize.Large, lblData);

      Label lblPergunta = new Label()
      {
        Text = "Liberar o aluno \"JOÃO DAS QUANTAS\" para o Sr(a). \"JOSÉ DAS TANTAS\"?",
        HorizontalOptions = LayoutOptions.Center,
        TextColor = Constants.DEFAULT_TEXT_COLOR,
        Margin = new Thickness(20, 20, 20, 20),
      };

      lblPergunta.FontSize = Device.GetNamedSize(NamedSize.Large, lblPergunta);

      mainStack = new StackLayout()
      {

        VerticalOptions = LayoutOptions.CenterAndExpand,
        Margin = new Thickness(20, 20, 20, 20),
        HeightRequest = 100,

      };

      Image profileImage = new Image()
      {
        HorizontalOptions = LayoutOptions.CenterAndExpand,
        Aspect = Aspect.AspectFill,
        Source = "https://t3.ftcdn.net/jpg/01/18/06/32/240_F_118063283_FD6CvzN1v1LFEMupsqEfuOkPbfjuO0CU.jpg",
        HeightRequest = 250,
        WidthRequest = 250

      };

      Image btnApprove = new Image()
      {
        HorizontalOptions = LayoutOptions.CenterAndExpand,
        Source = "https://www.shareicon.net/data/128x128/2017/02/09/878601_check_512x512.png",
        HeightRequest = 100,
        WidthRequest = 100,
      };

      Image btnDisApprove = new Image()
      {
        HorizontalOptions = LayoutOptions.CenterAndExpand,
        Source = "https://www.shareicon.net/data/128x128/2016/07/10/119646_close_512x512.png",
        HeightRequest = 100,
        WidthRequest = 100,
      };

      insideStack = new StackLayout()
      {
        Orientation = StackOrientation.Horizontal,
        Margin = new Thickness(0, 20, 0, 20),
        HeightRequest = 100,
        BackgroundColor = Constants.DEFAULT_SECONDARY_BACKGROUND_COLOR,

        Children =
        {
          btnApprove, btnDisApprove
        }
      };

      mainStack = new StackLayout()
      {
        VerticalOptions = LayoutOptions.FillAndExpand,
        HorizontalOptions = LayoutOptions.FillAndExpand,

        Children =
        {
          lblData, lblPergunta, profileImage, insideStack
        }
      };

      return mainStack;
    }
  }
}
