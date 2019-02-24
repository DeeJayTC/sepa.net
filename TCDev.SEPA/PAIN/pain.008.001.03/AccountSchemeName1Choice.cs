using System;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.PAIN
{
  [Serializable()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "AccountSchemeName1Choice")]
  [XmlRoot("AccountSchemeName1Choice")]
  public partial class AccountSchemeName1Choice
  {
    [XmlElement("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElement("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item { get; set; }
    [XmlElement(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnore()]
    public ItemChoiceType7 ItemElementName { get; set; }
  }
}