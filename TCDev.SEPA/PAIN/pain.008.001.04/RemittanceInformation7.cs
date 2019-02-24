using System.Collections.Generic;

namespace TCDev.SEPA.PAIN
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class RemittanceInformation7
  {

    [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
    public List<string> Ustrd { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Strd")]
    public List<StructuredRemittanceInformation9> Strd { get; set; }

    public RemittanceInformation7()
    {
      this.Strd = new List<StructuredRemittanceInformation9>();
    }
  }
}