using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XBLibrary.Model
{
  public class BaseModel : INotifyPropertyChanged
  {
    public string Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public bool Deleted { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    protected void RaisePropertyChanged(Func<string> propertyname)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyname()));
      }
    }
  }
}
