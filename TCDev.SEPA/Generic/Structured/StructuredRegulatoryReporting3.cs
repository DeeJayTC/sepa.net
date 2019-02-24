using System;
using System.Collections.Generic;

namespace TCDev.SEPA.Generic.Structured
{
  [Serializable()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  public partial class StructuredRegulatoryReporting3
  {

    public string Tp { get; set; }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime Dt { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DtSpecified { get; set; }
    public string Ctry { get; set; }
    public string Cd { get; set; }
    public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Inf")]
    public List<string> Inf { get; set; }

    public StructuredRegulatoryReporting3()
    {
      this.Amt = new ActiveOrHistoricCurrencyAndAmount();
    }
  }
}