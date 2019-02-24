using System;
using System.ComponentModel;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class GenericIdentification3
  {

    private string idField;

    private string issrField;

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }
}