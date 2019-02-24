namespace TCDev.SEPA.PAIN
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class ReferredDocumentInformation3
  {

    public ReferredDocumentType2 Tp { get; set; }
    public string Nb { get; set; }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime RltdDt { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RltdDtSpecified { get; set; }

    public ReferredDocumentInformation3()
    {
      this.Tp = new ReferredDocumentType2();
    }
  }
}