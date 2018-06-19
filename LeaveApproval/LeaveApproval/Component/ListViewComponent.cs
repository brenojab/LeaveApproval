using LeaveApproval.DataTemplates;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LeaveApproval.Component
{
  public class ListViewComponent : ListView
  {
    public void Init()
    {
      this.SeparatorVisibility = SeparatorVisibility.None;
      this.HasUnevenRows = true;
      this.IsPullToRefreshEnabled = true;

      ItemTemplate = new Xamarin.Forms.DataTemplate(typeof(RequestListDataTemplate));
    }

    public ListViewComponent(ListViewCachingStrategy strategy) : base(strategy)
    {
      Init();
    }
  }

  
}
