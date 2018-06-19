using LeaveApproval.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LeaveApproval.View
{
  public class BasePage : ContentPage
  {
    public virtual StackLayout ContentHeader { get; set; }
    public virtual StackLayout ContentMaster { get; set; }
    public virtual StackLayout ContentBottom { get; set; }

    public BasePage() : base()
    {
      this.BackgroundColor = Constants.DEFAULT_MAIN_BACKGROUND_COLOR;
      this.Init();
    }

    public virtual void Init()
    {
      this.ContentHeader = new StackLayout();
      this.ContentMaster = new StackLayout();
      this.ContentBottom = new StackLayout();

      this.ContentHeader.Spacing = 10;

      this.ContentMaster.VerticalOptions = LayoutOptions.FillAndExpand;

      this.ContentBottom.VerticalOptions = LayoutOptions.End;
      this.ContentBottom.Padding = new Thickness(0, 5);
      this.ContentBottom.HeightRequest = 40;
      this.ContentBottom.Spacing = 0;

      this.Content =
          new StackLayout
          {
            Spacing = 0,
            Children =
            {

             new StackLayout
             {
               VerticalOptions = LayoutOptions.FillAndExpand,
               Children  =
               {
                 ContentHeader,
                 new ScrollView
                    {
                     HorizontalOptions = LayoutOptions.FillAndExpand,
                      VerticalOptions = LayoutOptions.FillAndExpand,
                      Content = this.ContentMaster
                    }

               }
             },

          this.ContentBottom

            },

            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand
          };

    }
  }
}