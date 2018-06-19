using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApproval.Model
{
  public class Message : ModelBase
  {
    public string Subject { get; set; }
    public string Body { get; set; }
    public string ImageUrl { get; set; }
    public string IsReaded { get; set; }
    public string User { get; set; }
    public bool Aproved { get; set; }
  }
}

