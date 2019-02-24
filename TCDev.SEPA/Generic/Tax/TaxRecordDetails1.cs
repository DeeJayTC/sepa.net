using System;
using System.ComponentModel;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  public class TaxRecordDetails1
  {
    private ActiveOrHistoricCurrencyAndAmount amtField;
    private TaxPeriod1 prdField;

    public TaxRecordDetails1()
    {
      amtField = new ActiveOrHistoricCurrencyAndAmount();
      prdField = new TaxPeriod1();
    }

    public TaxPeriod1 Prd
    {
      get { return prdField; }
      set { prdField = value; }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get { return amtField; }
      set { amtField = value; }
    }
  }
}