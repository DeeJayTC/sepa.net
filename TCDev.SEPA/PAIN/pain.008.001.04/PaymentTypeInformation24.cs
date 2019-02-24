namespace TCDev.SEPA.PAIN
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class PaymentTypeInformation24
  {

    private System.Nullable<Priority2Code> instrPrtyField;

    private System.Nullable<SequenceType3Code> seqTpField;

    public ServiceLevel8Choice SvcLvl { get; set; }
    public LocalInstrument2Choice LclInstrm { get; set; }
    public CategoryPurpose1Choice CtgyPurp { get; set; }

    public PaymentTypeInformation24()
    {
      this.CtgyPurp = new CategoryPurpose1Choice();
      this.LclInstrm = new LocalInstrument2Choice();
      this.SvcLvl = new ServiceLevel8Choice();
    }

    public Priority2Code InstrPrty
    {
      get
      {
        if (this.instrPrtyField.HasValue)
        {
          return this.instrPrtyField.Value;
        }
        else
        {
          return default(Priority2Code);
        }
      }
      set
      {
        this.instrPrtyField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InstrPrtySpecified
    {
      get
      {
        return this.instrPrtyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.instrPrtyField = null;
        }
      }
    }

    public SequenceType3Code SeqTp
    {
      get
      {
        if (this.seqTpField.HasValue)
        {
          return this.seqTpField.Value;
        }
        else
        {
          return default(SequenceType3Code);
        }
      }
      set
      {
        this.seqTpField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SeqTpSpecified
    {
      get
      {
        return this.seqTpField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.seqTpField = null;
        }
      }
    }
  }
}