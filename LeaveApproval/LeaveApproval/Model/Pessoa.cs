using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApproval.Model
{
  public class Pessoa : ModelBase
  {
    public string Serie { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public DateTime DataNacimento { get; set; }

    public string Foto { get; set; }
  }
}
