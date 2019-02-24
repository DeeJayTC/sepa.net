using System;
using System.ComponentModel;

namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class Price2
  {

    private YieldedOrValueType1Choice tpField;

    private PriceRateOrAmountChoice valField;

    public Price2()
    {
      this.valField = new PriceRateOrAmountChoice();
      this.tpField = new YieldedOrValueType1Choice();
    }

    public YieldedOrValueType1Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public PriceRateOrAmountChoice Val
    {
      get
      {
        return this.valField;
      }
      set
      {
        this.valField = value;
      }
    }
  }
}