using System.Collections.Generic;

namespace TCDev.SEPA.PAIN
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class RegulatoryReporting3
  {

    private System.Nullable<RegulatoryReportingType1Code> dbtCdtRptgIndField;

    public RegulatoryAuthority2 Authrty { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Dtls")]
    public List<StructuredRegulatoryReporting3> Dtls { get; set; }

    public RegulatoryReporting3()
    {
      this.Dtls = new List<StructuredRegulatoryReporting3>();
      this.Authrty = new RegulatoryAuthority2();
    }

    public RegulatoryReportingType1Code DbtCdtRptgInd
    {
      get
      {
        if (this.dbtCdtRptgIndField.HasValue)
        {
          return this.dbtCdtRptgIndField.Value;
        }
        else
        {
          return default(RegulatoryReportingType1Code);
        }
      }
      set
      {
        this.dbtCdtRptgIndField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DbtCdtRptgIndSpecified
    {
      get
      {
        return this.dbtCdtRptgIndField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.dbtCdtRptgIndField = null;
        }
      }
    }
  }
}