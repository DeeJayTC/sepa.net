using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  public class TaxAmount1
  {
    private List<TaxRecordDetails1> dtlsField;
    private decimal? rateField;

    private ActiveOrHistoricCurrencyAndAmount taxblBaseAmtField;

    private ActiveOrHistoricCurrencyAndAmount ttlAmtField;

    public TaxAmount1()
    {
      dtlsField = new List<TaxRecordDetails1>();
      ttlAmtField = new ActiveOrHistoricCurrencyAndAmount();
      taxblBaseAmtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public decimal Rate
    {
      get
      {
        if (rateField.HasValue)
        {
          return rateField.Value;
        }
        return default(decimal);
      }
      set { rateField = value; }
    }

    [XmlIgnore]
    public bool RateSpecified
    {
      get { return rateField.HasValue; }
      set
      {
        if (value == false)
        {
          rateField = null;
        }
      }
    }

    public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt
    {
      get { return taxblBaseAmtField; }
      set { taxblBaseAmtField = value; }
    }

    public ActiveOrHistoricCurrencyAndAmount TtlAmt
    {
      get { return ttlAmtField; }
      set { ttlAmtField = value; }
    }

    [XmlElement("Dtls")]
    public List<TaxRecordDetails1> Dtls
    {
      get { return dtlsField; }
      set { dtlsField = value; }
    }
  }
}