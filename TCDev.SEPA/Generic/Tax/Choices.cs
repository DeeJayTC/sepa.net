using System;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;
using TCDev.SEPA.Generic.Tax;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class TaxAmountType1Choice
  {

    private string itemField;

    private ItemChoiceType13 itemElementNameField;

    [XmlElement("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType13 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class TaxAmountAndType1
  {

    private TaxAmountType1Choice tpField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    public TaxAmountAndType1()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
      this.tpField = new TaxAmountType1Choice();
    }

    public TaxAmountType1Choice Tp
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
