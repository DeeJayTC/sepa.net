using System;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class TaxCharges2
  {

    private string idField;

    private System.Nullable<decimal> rateField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    public TaxCharges2()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

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

    public decimal Rate
    {
      get
      {
        if (this.rateField.HasValue)
        {
          return this.rateField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.rateField = value;
      }
    }

    [XmlIgnore()]
    public bool RateSpecified
    {
      get
      {
        return this.rateField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rateField = null;
        }
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }
  }
}