using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.CAMT
{
  [Serializable]
  [DesignerCategory("code")]
  public class CashAccount24
  {
    private string ccyField;
    private AccountIdentification4Choice idField;

    private string nmField;
    private CashAccountType2Choice tpField;

    public CashAccount24()
    {
      tpField = new CashAccountType2Choice();
      idField = new AccountIdentification4Choice();
    }

    public AccountIdentification4Choice Id
    {
      get { return idField; }
      set { idField = value; }
    }

    public CashAccountType2Choice Tp
    {
      get { return tpField; }
      set { tpField = value; }
    }

    public string Ccy
    {
      get { return ccyField; }
      set { ccyField = value; }
    }

    public string Nm
    {
      get { return nmField; }
      set { nmField = value; }
    }
  }
}