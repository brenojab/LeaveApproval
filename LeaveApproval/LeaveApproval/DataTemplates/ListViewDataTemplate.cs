using LeaveApproval.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LeaveApproval.DataTemplates
{
  public class ListViewDataTemplate : ViewCell
  {
    public ListViewDataTemplate()
    {
      this.View = MainStack();
    }

    public StackLayout MainStack()
    {
      var stackMain = new StackLayout
      {
        Spacing = 0,
        Padding = new Thickness(10, 10, 10, 0),
        Orientation = StackOrientation.Vertical,
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.Start,
        Children = { StackText() }
      };
     
      ////um tap para selecionar a mensagem
      //var tap1 = new TapGestureRecognizer();
      //tap1.NumberOfTapsRequired = 1;
      //tap1.Command = new Command(() =>
      //{
      //  RMSDependencyResolver.Container.GetService<ITimelineViewModel>().SelectedMensagemIndividual = this.BindingContext as IMensagemIndividualViewModel;
      //});

      return stackMain;
    }

    private StackLayout StackText()
    {
      var stackText = new StackLayout();

      stackText.Orientation = StackOrientation.Horizontal;
      stackText.Spacing = 0;
      stackText.HorizontalOptions = LayoutOptions.FillAndExpand;
      stackText.VerticalOptions = LayoutOptions.StartAndExpand;

      //stackColumns.Children.Add(StackColumnRectangle());
      //stackColumns.Children.Add(StackColumCategoria());
      stackText.Children.Add(StackMessage());

      return stackText;
    }

    private StackLayout StackMessage()
    {
      var lblData = new Label
      {
        FontSize = 9,
        HorizontalOptions = LayoutOptions.End,
        HorizontalTextAlignment = TextAlignment.End
      };


      var lblHeader = new Label
      {
        FontSize = 11,
        LineBreakMode = LineBreakMode.TailTruncation
        
      };

      lblHeader.SetBinding(Label.TextProperty, nameof(Message.Subject));

      var lblBody = new Label
      {
        FontSize = 10,
        LineBreakMode = LineBreakMode.TailTruncation,
        HorizontalOptions = LayoutOptions.FillAndExpand,
        HorizontalTextAlignment = TextAlignment.Start
      };

      lblBody.SetBinding(Label.TextProperty, nameof(Message.Body));

      var stackMessage = new StackLayout
      {
        Spacing = 0.4,
        Padding = new Thickness(5, 5, 0, 0),
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.FillAndExpand
      };

      stackMessage.Children.Add(new StackLayout
      {
        Children = { lblData },
        HorizontalOptions = LayoutOptions.End
      });

      stackMessage.Children.Add(lblHeader);
      stackMessage.Children.Add(lblBody);

      return stackMessage;
    }
  }
}
