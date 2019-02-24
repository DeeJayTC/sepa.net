using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class ActiveCurrencyAndAmount
  {

    private string _ccyField;

    private decimal _valueField;

    [XmlAttribute(AttributeName ="Ccy")]
    public string Currency
    {
      get
      {
        return this._ccyField;
      }
      set
      {
        this._ccyField = value;
      }
    }

    [XmlText()]
    public decimal Value
    {
      get
      {
        return this._valueField;
      }
      set
      {
        this._valueField = value;
      }
    }
  }
}