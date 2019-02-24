using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;


namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable]
  [DesignerCategory("code")]
  public class CashAccountType2Choice
  {
    private ItemChoiceType5 itemElementNameField;
    private string itemField;

    [XmlElement("Cd", typeof(string))]
    [XmlElement("Prtry", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlIgnore]
    public ItemChoiceType5 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }


  [SerializableAttribute()]
  [DesignerCategory("code")]
  public partial class TransactionPrice3Choice
  {

    private List<object> itemsField;

    public TransactionPrice3Choice()
    {
      this.itemsField = new List<object>();
    }

    [XmlElement("DealPric", typeof(Price2))]
    [XmlElement("Prtry", typeof(ProprietaryPrice2))]
    public List<object> Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }
  }
}
