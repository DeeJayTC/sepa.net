// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CustomerDirectDebitInitiationV03.cs
// Author: Tim Cadenbach, TCDev    
// Created: 13.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================

using System;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic.GroupHeader;
using TCDev.SEPA.Generic.Identification;
using TCDev.SEPA.PAIN.Generic;

namespace TCDev.SEPA.PAIN
{
  using System.Collections.Generic;

  [Serializable()]
  [DesignerCategory("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IsNullable = false)]
// ReSharper disable once InconsistentNaming
  public class pain_008_001_04
  {

    public CustomerDirectDebitInitiationV04 CstmrDrctDbtInitn { get; set; }

    public pain_008_001_04()
    {
      this.CstmrDrctDbtInitn = new CustomerDirectDebitInitiationV04();
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class CustomerDirectDebitInitiationV04
  {

    public GroupHeader55 GrpHdr { get; set; }
    [XmlElementAttribute("PmtInf")]
    public List<PaymentInstruction10> PaymentInstruction { get; set; }
    [XmlElementAttribute("SplmtryData")]
    public List<SupplementaryData1> SuplementaryData { get; set; }

    public CustomerDirectDebitInitiationV04()
    {
      SuplementaryData = new List<SupplementaryData1>();
      PaymentInstruction = new List<PaymentInstruction10>();
      GrpHdr = new GroupHeader55();
    }
  }



  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public enum Authorisation1Code
  {

    /// <remarks/>
    AUTH,

    /// <remarks/>
    FDET,

    /// <remarks/>
    FSUM,

    /// <remarks/>
    ILEV,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class SupplementaryData1
  {

    private System.Xml.XmlElement envlpField;

    public string PlcAndNm { get; set; }
    public System.Xml.XmlElement Envlp { get; set; }
  }


 

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class ActiveOrHistoricCurrencyAndAmount
  {

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ccy { get; set; }
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public enum CreditDebitCode
  {

    /// <remarks/>
    CRDT,

    /// <remarks/>
    DBIT,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class TaxAmountType1Choice
  {

    private ItemChoiceType11 itemElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType11 ItemElementName { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
  public enum ItemChoiceType11
  {

    /// <remarks/>
    Cd,

    /// <remarks/>
    Prtry,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class TaxAmountAndType1
  {

    public TaxAmountType1Choice Tp { get; set; }
    public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    public TaxAmountAndType1()
    {
      this.Amt = new ActiveOrHistoricCurrencyAndAmount();
      this.Tp = new TaxAmountType1Choice();
    }
  }


  
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class GenericAccountIdentification1
  {

    public string Id { get; set; }
    public AccountSchemeName1Choice SchmeNm { get; set; }
    public string Issr { get; set; }

    public GenericAccountIdentification1()
    {
      this.SchmeNm = new AccountSchemeName1Choice();
    }
  }

 

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
  public enum ItemChoiceType8
  {

    /// <remarks/>
    Cd,

    /// <remarks/>
    Prtry,
  }



  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class DirectDebitTransactionInformation13
  {

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    public PaymentIdentification1 PmtId { get; set; }
    public PaymentTypeInformation24 PmtTpInf { get; set; }
    public ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }
    public DirectDebitTransaction7 DrctDbtTx { get; set; }
    public PartyIdentification43 UltmtCdtr { get; set; }
    public BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }
    public CashAccount24 DbtrAgtAcct { get; set; }
    public PartyIdentification43 Dbtr { get; set; }
    public CashAccount24 DbtrAcct { get; set; }
    public PartyIdentification43 UltmtDbtr { get; set; }
    public string InstrForCdtrAgt { get; set; }
    public Purpose2Choice Purp { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
    public List<RegulatoryReporting3> RgltryRptg { get; set; }
    public TaxInformation3 Tax { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
    public List<RemittanceLocation2> RltdRmtInf { get; set; }
    public RemittanceInformation7 RmtInf { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
    public List<SupplementaryData1> SplmtryData { get; set; }

    public DirectDebitTransactionInformation13()
    {
      this.SplmtryData = new List<SupplementaryData1>();
      this.RmtInf = new RemittanceInformation7();
      this.RltdRmtInf = new List<RemittanceLocation2>();
      this.Tax = new TaxInformation3();
      this.RgltryRptg = new List<RegulatoryReporting3>();
      this.Purp = new Purpose2Choice();
      this.UltmtDbtr = new PartyIdentification43();
      this.DbtrAcct = new CashAccount24();
      this.Dbtr = new PartyIdentification43();
      this.DbtrAgtAcct = new CashAccount24();
      this.DbtrAgt = new BranchAndFinancialInstitutionIdentification5();
      this.UltmtCdtr = new PartyIdentification43();
      this.DrctDbtTx = new DirectDebitTransaction7();
      this.InstdAmt = new ActiveOrHistoricCurrencyAndAmount();
      this.PmtTpInf = new PaymentTypeInformation24();
      this.PmtId = new PaymentIdentification1();
    }

    public ChargeBearerType1Code ChrgBr
    {
      get
      {
        if (this.chrgBrField.HasValue)
        {
          return this.chrgBrField.Value;
        }
        else
        {
          return default(ChargeBearerType1Code);
        }
      }
      set
      {
        this.chrgBrField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChrgBrSpecified
    {
      get
      {
        return this.chrgBrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.chrgBrField = null;
        }
      }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class LocalInstrument2Choice
  {

    private ItemChoiceType5 itemElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType5 ItemElementName { get; set; }
  }



  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class CategoryPurpose1Choice
  {

    private ItemChoiceType6 itemElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType6 ItemElementName { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
  public enum ItemChoiceType6
  {

    /// <remarks/>
    Cd,

    /// <remarks/>
    Prtry,
  }



  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
  public partial class PaymentInstruction10
  {

    private PaymentMethod2Code pmtMtdField;

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    public string PmtInfId { get; set; }
    public PaymentMethod2Code PmtMtd { get; set; }
    public bool BtchBookg { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BtchBookgSpecified { get; set; }
    public string NbOfTxs { get; set; }
    public decimal CtrlSum { get; set; }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CtrlSumSpecified { get; set; }
    public PaymentTypeInformation24 PmtTpInf { get; set; }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ReqdColltnDt { get; set; }
    public PartyIdentification43 Cdtr { get; set; }
    public CashAccount24 CdtrAcct { get; set; }
    public BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }
    public CashAccount24 CdtrAgtAcct { get; set; }
    public PartyIdentification43 UltmtCdtr { get; set; }
    public CashAccount24 ChrgsAcct { get; set; }
    public BranchAndFinancialInstitutionIdentification5 ChrgsAcctAgt { get; set; }
    public PartyIdentification43 CdtrSchmeId { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
    public List<DirectDebitTransactionInformation13> DrctDbtTxInf { get; set; }

    public PaymentInstruction10()
    {
      this.DrctDbtTxInf = new List<DirectDebitTransactionInformation13>();
      this.CdtrSchmeId = new PartyIdentification43();
      this.ChrgsAcctAgt = new BranchAndFinancialInstitutionIdentification5();
      this.ChrgsAcct = new CashAccount24();
      this.UltmtCdtr = new PartyIdentification43();
      this.CdtrAgtAcct = new CashAccount24();
      this.CdtrAgt = new BranchAndFinancialInstitutionIdentification5();
      this.CdtrAcct = new CashAccount24();
      this.Cdtr = new PartyIdentification43();
      this.PmtTpInf = new PaymentTypeInformation24();
    }

    public ChargeBearerType1Code ChrgBr
    {
      get
      {
        if (this.chrgBrField.HasValue)
        {
          return this.chrgBrField.Value;
        }
        else
        {
          return default(ChargeBearerType1Code);
        }
      }
      set
      {
        this.chrgBrField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChrgBrSpecified
    {
      get
      {
        return this.chrgBrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.chrgBrField = null;
        }
      }
    }
  }
}
