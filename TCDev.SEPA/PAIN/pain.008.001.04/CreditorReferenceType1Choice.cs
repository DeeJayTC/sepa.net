using TCDev.SEPA.Generic;

namespace TCDev.SEPA.PAIN
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class CreditorReferenceType1Choice
  {

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType3Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    public object Item { get; set; }
  }
}