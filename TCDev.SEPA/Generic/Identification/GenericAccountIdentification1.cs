using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "GenericAccountIdentification1")]
  [XmlRoot("GenericAccountIdentification1")]
  public partial class GenericAccountIdentification1
  {

    private AccountSchemeName1Choice _schmeNmField;

    [XmlElement(Order = 0, ElementName = "Id")]
    public string Id { get; set; }
    [XmlElement(Order = 2, ElementName = "Issr")]
    public string Issr { get; set; }

    [XmlElement(Order = 1, ElementName = "SchmeNm")]
    public AccountSchemeName1Choice SchmeNm
    {
      get
      {
        if ((this._schmeNmField == null))
        {
          this._schmeNmField = new AccountSchemeName1Choice();
        }
        return this._schmeNmField;
      }
      set
      {
        this._schmeNmField = value;
      }
    }
  }
}