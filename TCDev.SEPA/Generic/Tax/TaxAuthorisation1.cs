using System;
using System.ComponentModel;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  public class TaxAuthorisation1
  {
    private string nmField;
    private string titlField;

    public string Titl
    {
      get { return titlField; }
      set { titlField = value; }
    }

    public string Nm
    {
      get { return nmField; }
      set { nmField = value; }
    }
  }
}