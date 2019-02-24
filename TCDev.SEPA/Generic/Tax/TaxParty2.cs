using System;
using System.ComponentModel;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  public class TaxParty2
  {
    private TaxAuthorisation1 authstnField;
    private string regnIdField;
    private string taxIdField;

    private string taxTpField;

    public TaxParty2()
    {
      authstnField = new TaxAuthorisation1();
    }

    public string TaxId
    {
      get { return taxIdField; }
      set { taxIdField = value; }
    }

    public string RegnId
    {
      get { return regnIdField; }
      set { regnIdField = value; }
    }

    public string TaxTp
    {
      get { return taxTpField; }
      set { taxTpField = value; }
    }

    public TaxAuthorisation1 Authstn
    {
      get { return authstnField; }
      set { authstnField = value; }
    }
  }
}