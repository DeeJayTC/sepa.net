using System;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  public class TaxPeriod1
  {
    private DatePeriodDetails frToDtField;
    private TaxRecordPeriod1Code? tpField;
    private DateTime? yrField;

    public TaxPeriod1()
    {
      frToDtField = new DatePeriodDetails();
    }

    [XmlElement(DataType = "date")]
    public DateTime Yr
    {
      get
      {
        if (yrField.HasValue)
        {
          return yrField.Value;
        }
        return default(DateTime);
      }
      set { yrField = value; }
    }

    [XmlIgnore]
    public bool YrSpecified
    {
      get { return yrField.HasValue; }
      set
      {
        if (value == false)
        {
          yrField = null;
        }
      }
    }

    public TaxRecordPeriod1Code Tp
    {
      get
      {
        if (tpField.HasValue)
        {
          return tpField.Value;
        }
        return default(TaxRecordPeriod1Code);
      }
      set { tpField = value; }
    }

    [XmlIgnore]
    public bool TpSpecified
    {
      get { return tpField.HasValue; }
      set
      {
        if (value == false)
        {
          tpField = null;
        }
      }
    }

    public DatePeriodDetails FrToDt
    {
      get { return frToDtField; }
      set { frToDtField = value; }
    }
  }
}