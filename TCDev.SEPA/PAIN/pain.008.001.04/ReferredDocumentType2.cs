namespace TCDev.SEPA.PAIN
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class ReferredDocumentType2
  {

    public ReferredDocumentType1Choice CdOrPrtry { get; set; }
    public string Issr { get; set; }

    public ReferredDocumentType2()
    {
      this.CdOrPrtry = new ReferredDocumentType1Choice();
    }
  }
}