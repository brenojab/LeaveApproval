using LeaveApproval.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LeaveApproval.ViewModel
{
  public class ListViewViewModel : ModelBase
  {

    private ObservableCollection<Message> _messageList;

    public ObservableCollection<Message> MessageList
    {

      get { return _messageList; }


      set
      {
        _messageList = value;
        RaisePropertyChanged(nameof(Message));
      }
    }

    private Message _message;
    public Message Message
    {
      get { return _message; }


      set
      {
        _message = value;
        RaisePropertyChanged(nameof(Message));
      }
    }


    public ObservableCollection<Message> ReturnList()
    {
      MessageList.Add(new Message() { Body = "Body", Subject = "Subject" });

      RaisePropertyChanged(nameof(Message));

      return MessageList;
    }

    public ListViewViewModel()
    {

    }

    ICommand _loadMoreCommand;
    public virtual ICommand LoadMoreCommand
    {
      get
      {
        return _loadMoreCommand ?? (_loadMoreCommand = new Command(async () => await LoadMore()));
      }
    }

    private async Task LoadMore()
    {
      Device.BeginInvokeOnMainThread(async () =>
      {

        ReturnList();
      });
    }
  }
}
