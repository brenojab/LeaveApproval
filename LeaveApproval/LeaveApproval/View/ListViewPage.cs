using LeaveApproval.Component;
using LeaveApproval.Model;
using LeaveApproval.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LeaveApproval.View
{
  public class ListViewPage : BasePage
  {
    public ListViewComponent ListComponent;

    List<Pessoa> pessoaList = new List<Pessoa>()
    {
      new Pessoa { Nome = "Mateus José Santos Batista", Idade = 7, Serie = "2ª Série A" },
      new Pessoa { Nome = "João Pedro de Souza", Idade = 6, Serie = "2ª Série B" },
      new Pessoa { Nome = "Joaquina Pereira de Freitas", Idade = 7, Serie = "3ª Série A" },
      new Pessoa { Nome = "Gabriela Quintas Borba", Idade = 15, Serie = "1ª Ano A" },
      new Pessoa { Nome = "Frederico Francisco Laranjeira", Idade = 11, Serie = "6ª Série B" },
    };

    public ListViewPage()
    {

    }

    public override void Init()
    {
      base.Init();

      this.ContentMaster.VerticalOptions = LayoutOptions.FillAndExpand;


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
                 this.ContentHeader,
                 this.ContentMaster
               }
              },

          this.ContentBottom

          },

          HorizontalOptions = LayoutOptions.FillAndExpand,
          VerticalOptions = LayoutOptions.FillAndExpand
        };

      InitPage();
    }

    private void InitPage()
    {
      this.ContentMaster.Children.Add(this.AddListView());
    }

    private StackLayout AddListView()
    {
      var personDataTemplate = new Xamarin.Forms.DataTemplate(() =>
      {
        var stackMain = new StackLayout
        {
          Spacing = 0,
          Padding = new Thickness(10, 10, 10, 0),
          Orientation = StackOrientation.Vertical,
          HorizontalOptions = LayoutOptions.FillAndExpand,
          VerticalOptions = LayoutOptions.Start,
          Children = { StackColumContentMessage() }
        };

        //Image image = new Image() { Aspect = Aspect.AspectFit, Source = "https://picsum.photos/150/150/?random" };

        var nomeLabel = new Label { FontAttributes = FontAttributes.Bold, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
        var idadeLabel = new Label() { };
        var serieLabel = new Label { HorizontalTextAlignment = TextAlignment.End,

          FontAttributes = FontAttributes.Bold,
          FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
        };

        nomeLabel.SetBinding(Label.TextProperty, "Nome");
        idadeLabel.SetBinding(Label.TextProperty, "Idade");
        serieLabel.SetBinding(Label.TextProperty, "Serie");


        return new ViewCell { View = stackMain };
      });


      var lblDataNotificacao = new Label
      {
        FontSize = 9,
        HorizontalOptions = LayoutOptions.End,
        HorizontalTextAlignment = TextAlignment.End
      };

      var lblAssunto = new Label
      {
        FontSize = 11,
        LineBreakMode = LineBreakMode.TailTruncation
      };

      lblAssunto.SetBinding(Label.TextProperty, "Nome");

      var lblContent = new Label
      {
        LineBreakMode = LineBreakMode.TailTruncation,
        HorizontalOptions = LayoutOptions.FillAndExpand,
        HorizontalTextAlignment = TextAlignment.Start
      };

      lblContent.FontSize = Device.GetNamedSize(NamedSize.Medium, lblContent);

      lblContent.SetBinding(Label.TextProperty, "Serie");

      var contentMensage = new StackLayout
      {
        Spacing = 0.4,
        Padding = new Thickness(5, 5, 0, 0),
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.FillAndExpand
      };

      contentMensage.Children.Add(new StackLayout
      {
        Children = { lblDataNotificacao },
        HorizontalOptions = LayoutOptions.End
      });

      contentMensage.Children.Add(lblAssunto);
      contentMensage.Children.Add(lblContent);

      return contentMensage;

    }

    private StackLayout StackColumContentMessage()
    {
      var lblDataNotificacao = new Label
      {
        FontSize = 9,
        HorizontalOptions = LayoutOptions.End,
        HorizontalTextAlignment = TextAlignment.End
      };

      var lblAssunto = new Label
      {
        FontSize = 11,
        LineBreakMode = LineBreakMode.TailTruncation
      };

      lblAssunto.SetBinding(Label.TextProperty, "Nome");

      var lblContent = new Label
      {
        LineBreakMode = LineBreakMode.TailTruncation,
        HorizontalOptions = LayoutOptions.FillAndExpand,
        HorizontalTextAlignment = TextAlignment.Start
      };

      lblContent.FontSize = Device.GetNamedSize(NamedSize.Medium, lblContent);

      lblContent.SetBinding(Label.TextProperty, "Serie");

      var contentMensage = new StackLayout
      {
        Spacing = 0.4,
        Padding = new Thickness(5, 5, 0, 0),
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.FillAndExpand
      };

      contentMensage.Children.Add(new StackLayout
      {
        Children = { lblDataNotificacao },
        HorizontalOptions = LayoutOptions.End
      });

      contentMensage.Children.Add(lblAssunto);
      contentMensage.Children.Add(lblContent);

      return contentMensage;
    }
  }
}