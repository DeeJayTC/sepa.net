using System;
using System.ComponentModel;
using TCDev.SEPA.Generic.Contact;

namespace TCDev.SEPA.CAMT
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class NameAndAddress10
  {

    private string _nmField;

    private PostalAddress6 _adrField;

    public NameAndAddress10()
    {
      this._adrField = new PostalAddress6();
    }

    public string Nm
    {
      get
      {
        return this._nmField;
      }
      set
      {
        this._nmField = value;
      }
    }

    public PostalAddress6 Adr
    {
      get
      {
        return this._adrField;
      }
      set
      {
        this._adrField = value;
      }
    }
  }
}