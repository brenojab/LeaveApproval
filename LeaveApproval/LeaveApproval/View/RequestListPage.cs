using LeaveApproval.Component;
using LeaveApproval.DataTemplates;
using LeaveApproval.Model;
using LeaveApproval.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LeaveApproval.View
{
  public class RequestListPage : BasePage
  {

    List<Pessoa> pessoaList = new List<Pessoa>()
    {
      new Pessoa { Nome = "Mateus José Santos Batista", Idade = 7, Serie = "2ª Série A" },
      new Pessoa { Nome = "João Pedro de Souza", Idade = 6, Serie = "2ª Série B" },
      new Pessoa { Nome = "Joaquina Pereira de Freitas", Idade = 7, Serie = "3ª Série A" },
      new Pessoa { Nome = "Gabriela Quintas Borba", Idade = 15, Serie = "1ª Ano A" },
      new Pessoa { Nome = "Frederico Francisco Laranjeira", Idade = 11, Serie = "6ª Série B" },
    };

    ListViewComponent ListComponent;

    public override void Init()
    {
      base.Init();

      InitPage();
    }

    private void InitPage()
    {
      this.ContentMaster.Children.Add(this.AddListView());
    }

    private ListViewComponent AddListView()
    {
      ListComponent = new ListViewComponent(ListViewCachingStrategy.RecycleElementAndDataTemplate)
      {
        BackgroundColor = Constants.DEFAULT_MAIN_BACKGROUND_COLOR,
        SeparatorColor = Constants.DEFAULT_TEXT_COLOR,
      };

      // Impede que, ao selecionar o item, ele fique selecionado.
      ListComponent.ItemSelected += (o, e) => { ListComponent.SelectedItem = null; };
      ListComponent.ItemTemplate = new DataTemplate(typeof(RequestListDataTemplate));
      ListComponent.ItemsSource = pessoaList;

      var nomeLabel = new Label { FontAttributes = FontAttributes.Bold, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
      var idadeLabel = new Label();
      var serieLabel = new Label { HorizontalTextAlignment = TextAlignment.End };

      nomeLabel.SetBinding(Label.TextProperty, "Nome");
      idadeLabel.SetBinding(Label.TextProperty, "Idade");
      serieLabel.SetBinding(Label.TextProperty, "Serie");

      return ListComponent;

    }
  }
}
