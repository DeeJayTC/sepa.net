// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CustomerDirectDebitInitiationV03.cs
// Author: Tim Cadenbach, TCDev    
// Created: 07.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================

using TCDev.SEPA.CAMT.Generic;
using TCDev.SEPA.Generic;
using TCDev.SEPA.Generic.Contact;
using TCDev.SEPA.Generic.GroupHeader;
using TCDev.SEPA.Generic.Identification;
using TCDev.SEPA.Generic.Tax;
using TCDev.SEPA.PAIN.Generic;

namespace TCDev.SEPA.PAIN
{
  using System;
  using System.Xml.Serialization;
  using System.ComponentModel;
  using System.Collections.Generic;

  /// <summary>
  /// Pain 008.001.03 --> Customer Direct Debit Initiation
  /// </summary>
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "Document")]
  [XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", IsNullable = false, ElementName = "Document")]
// ReSharper disable once InconsistentNaming
  public partial class pain_008_001_03
  {

    private CustomerDirectDebitInitiationV03 _cstmrDrctDbtInitnField;

    [XmlElementAttribute(Order = 0, ElementName = "CstmrDrctDbtInitn")]
    public CustomerDirectDebitInitiationV03 CustomerDirectDebitInitiation
    {
      get
      {
        if ((this._cstmrDrctDbtInitnField == null))
        {
          this._cstmrDrctDbtInitnField = new CustomerDirectDebitInitiationV03();
        }
        return this._cstmrDrctDbtInitnField;
      }
      set
      {
        this._cstmrDrctDbtInitnField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "CustomerDirectDebitInitiationV03")]
  [XmlRootAttribute("CustomerDirectDebitInitiationV03")]
  public partial class CustomerDirectDebitInitiationV03
  {

    private GroupHeader55 _grpHdrField;

    private List<PaymentInstruction7> _pmtInfField;

    private List<SupplementaryData1> _splmtryDataField;

    [XmlElementAttribute(Order = 0, ElementName = "GrpHdr")]
    public GroupHeader55 GroupHeader
    {
      get
      {
        if ((this._grpHdrField == null))
        {
          this._grpHdrField = new GroupHeader55();
        }
        return this._grpHdrField;
      }
      set
      {
        this._grpHdrField = value;
      }
    }

    [XmlElementAttribute("PmtInf", Order = 1, ElementName = "PmtInf")]
    public List<PaymentInstruction7> PaymentInstruction
    {
      get
      {
        if ((this._pmtInfField == null))
        {
          this._pmtInfField = new List<PaymentInstruction7>();
        }
        return this._pmtInfField;
      }
      set
      {
        this._pmtInfField = value;
      }
    }

    [XmlElementAttribute("SplmtryData", Order = 2, ElementName = "SplmtryData")]
    public List<SupplementaryData1> SuplementaryData
    {
      get
      {
        if ((this._splmtryDataField == null))
        {
          this._splmtryDataField = new List<SupplementaryData1>();
        }
        return this._splmtryDataField;
      }
      set
      {
        this._splmtryDataField = value;
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "CreditorReferenceType2")]
  [XmlRootAttribute("CreditorReferenceType2")]
  public partial class CreditorReferenceType2
  {

    private CreditorReferenceType1Choice cdOrPrtryField;

    [XmlElementAttribute(Order = 1, ElementName = "Issr")]
    public string Issr { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "CdOrPrtry")]
    public CreditorReferenceType1Choice CdOrPrtry
    {
      get
      {
        if ((this.cdOrPrtryField == null))
        {
          this.cdOrPrtryField = new CreditorReferenceType1Choice();
        }
        return this.cdOrPrtryField;
      }
      set
      {
        this.cdOrPrtryField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "CreditorReferenceInformation2")]
  [XmlRootAttribute("CreditorReferenceInformation2")]
  public partial class CreditorReferenceInformation2
  {

    private CreditorReferenceType2 tpField;

    [XmlElementAttribute(Order = 1, ElementName = "Ref")]
    public string Ref { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "Tp")]
    public CreditorReferenceType2 Tp
    {
      get
      {
        if ((this.tpField == null))
        {
          this.tpField = new CreditorReferenceType2();
        }
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DocumentAdjustment1")]
  [XmlRootAttribute("DocumentAdjustment1")]
  public partial class DocumentAdjustment1
  {

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private System.Nullable<CreditDebitCode> cdtDbtIndField;

    [XmlElementAttribute(Order = 2, ElementName = "Rsn")]
    public string Rsn { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "AddtlInf")]
    public string AddtlInf { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "Amt")]
    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        if ((this.amtField == null))
        {
          this.amtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "CdtDbtInd")]
    public CreditDebitCode CdtDbtInd
    {
      get
      {
        if (this.cdtDbtIndField.HasValue)
        {
          return this.cdtDbtIndField.Value;
        }
        else
        {
          return default(CreditDebitCode);
        }
      }
      set
      {
        this.cdtDbtIndField = value;
      }
    }

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("CdtDbtIndSpecified")]
    public bool CdtDbtIndSpecified
    {
      get
      {
        return this.cdtDbtIndField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.cdtDbtIndField = null;
        }
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DiscountAmountType1Choice")]
  [XmlRootAttribute("DiscountAmountType1Choice")]
  public partial class DiscountAmountType1Choice
  {
    [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType10 ItemElementName { get; set; }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DiscountAmountAndType1")]
  [XmlRootAttribute("DiscountAmountAndType1")]
  public partial class DiscountAmountAndType1
  {

    private DiscountAmountType1Choice tpField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    [XmlElementAttribute(Order = 0, ElementName = "Tp")]
    public DiscountAmountType1Choice Tp
    {
      get
      {
        if ((this.tpField == null))
        {
          this.tpField = new DiscountAmountType1Choice();
        }
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "Amt")]
    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        if ((this.amtField == null))
        {
          this.amtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "RemittanceAmount2")]
  [XmlRootAttribute("RemittanceAmount2")]
  public partial class RemittanceAmount2
  {

    private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

    private List<DiscountAmountAndType1> dscntApldAmtField;

    private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

    private List<TaxAmountAndType1> taxAmtField;

    private List<DocumentAdjustment1> adjstmntAmtAndRsnField;

    private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

    [XmlElementAttribute(Order = 0, ElementName = "DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount DuePyblAmt
    {
      get
      {
        if ((this.duePyblAmtField == null))
        {
          this.duePyblAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.duePyblAmtField;
      }
      set
      {
        this.duePyblAmtField = value;
      }
    }

    [XmlElementAttribute("DscntApldAmt", Order = 1, ElementName = "DscntApldAmt")]
    public List<DiscountAmountAndType1> DscntApldAmt
    {
      get
      {
        if ((this.dscntApldAmtField == null))
        {
          this.dscntApldAmtField = new List<DiscountAmountAndType1>();
        }
        return this.dscntApldAmtField;
      }
      set
      {
        this.dscntApldAmtField = value;
      }
    }

    [XmlElementAttribute(Order = 2, ElementName = "CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount ActiveOrHistoryCurrencyAmount
    {
      get
      {
        if ((this.cdtNoteAmtField == null))
        {
          this.cdtNoteAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.cdtNoteAmtField;
      }
      set
      {
        this.cdtNoteAmtField = value;
      }
    }

    [XmlElementAttribute("TaxAmt", Order = 3, ElementName = "TaxAmt")]
    public List<TaxAmountAndType1> TaxAmount
    {
      get
      {
        if ((this.taxAmtField == null))
        {
          this.taxAmtField = new List<TaxAmountAndType1>();
        }
        return this.taxAmtField;
      }
      set
      {
        this.taxAmtField = value;
      }
    }

    [XmlElementAttribute("AdjstmntAmtAndRsn", Order = 4, ElementName = "AdjstmntAmtAndRsn")]
    public List<DocumentAdjustment1> DocumentAdjustment
    {
      get
      {
        if ((this.adjstmntAmtAndRsnField == null))
        {
          this.adjstmntAmtAndRsnField = new List<DocumentAdjustment1>();
        }
        return this.adjstmntAmtAndRsnField;
      }
      set
      {
        this.adjstmntAmtAndRsnField = value;
      }
    }

    [XmlElementAttribute(Order = 5, ElementName = "RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount RemoteAmount
    {
      get
      {
        if ((this.rmtdAmtField == null))
        {
          this.rmtdAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.rmtdAmtField;
      }
      set
      {
        this.rmtdAmtField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(TypeName = "ReferredDocumentType1Choice")]
  [XmlRootAttribute("ReferredDocumentType1Choice")]
  public partial class ReferredDocumentType1Choice
  {
    [XmlElementAttribute("Cd", typeof(DocumentType5Code), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    public object Item { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "StructuredRemittanceInformation9")]
  [XmlRootAttribute("StructuredRemittanceInformation9")]
  public partial class StructuredRemittanceInformation9
  {

    private List<ReferredDocumentInformation3> rfrdDocInfField;

    private RemittanceAmount2 rfrdDocAmtField;

    private CreditorReferenceInformation2 cdtrRefInfField;

    private PartyIdentification43 invcrField;

    private PartyIdentification43 invceeField;

    [XmlElementAttribute("AddtlRmtInf", Order = 5, ElementName = "AddtlRmtInf")]
    public List<string> AddtlRmtInf { get; set; }

    [XmlElementAttribute("RfrdDocInf", Order = 0, ElementName = "RfrdDocInf")]
    public List<ReferredDocumentInformation3> RfrdDocInf
    {
      get
      {
        if ((this.rfrdDocInfField == null))
        {
          this.rfrdDocInfField = new List<ReferredDocumentInformation3>();
        }
        return this.rfrdDocInfField;
      }
      set
      {
        this.rfrdDocInfField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "RfrdDocAmt")]
    public RemittanceAmount2 RfrdDocAmt
    {
      get
      {
        if ((this.rfrdDocAmtField == null))
        {
          this.rfrdDocAmtField = new RemittanceAmount2();
        }
        return this.rfrdDocAmtField;
      }
      set
      {
        this.rfrdDocAmtField = value;
      }
    }

    [XmlElementAttribute(Order = 2, ElementName = "CdtrRefInf")]
    public CreditorReferenceInformation2 CdtrRefInf
    {
      get
      {
        if ((this.cdtrRefInfField == null))
        {
          this.cdtrRefInfField = new CreditorReferenceInformation2();
        }
        return this.cdtrRefInfField;
      }
      set
      {
        this.cdtrRefInfField = value;
      }
    }

    [XmlElementAttribute(Order = 3, ElementName = "Invcr")]
    public PartyIdentification43 Invcr
    {
      get
      {
        if ((this.invcrField == null))
        {
          this.invcrField = new PartyIdentification43();
        }
        return this.invcrField;
      }
      set
      {
        this.invcrField = value;
      }
    }

    [XmlElementAttribute(Order = 4, ElementName = "Invcee")]
    public PartyIdentification43 Invcee
    {
      get
      {
        if ((this.invceeField == null))
        {
          this.invceeField = new PartyIdentification43();
        }
        return this.invceeField;
      }
      set
      {
        this.invceeField = value;
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "GenericOrganisationIdentification1")]
  [XmlRootAttribute("GenericOrganisationIdentification1")]
  public partial class GenericOrganisationIdentification1
  {

    private OrganisationIdentificationSchemeName1Choice schmeNmField;

    [XmlElementAttribute(Order = 0, ElementName = "Id")]
    public string Id { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "Issr")]
    public string Issr { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "SchmeNm")]
    public OrganisationIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        if ((this.schmeNmField == null))
        {
          this.schmeNmField = new OrganisationIdentificationSchemeName1Choice();
        }
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "OrganisationIdentificationSchemeName1Choice")]
  [XmlRootAttribute("OrganisationIdentificationSchemeName1Choice")]
  public partial class OrganisationIdentificationSchemeName1Choice
  {

    [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName { get; set; }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "PersonIdentification5")]
  [XmlRootAttribute("PersonIdentification5")]
  public partial class PersonIdentification5
  {

    private DateAndPlaceOfBirth dtAndPlcOfBirthField;

    private List<GenericPersonIdentification1> othrField;

    [XmlElementAttribute(Order = 0, ElementName = "DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth DtAndPlcOfBirth
    {
      get
      {
        if ((this.dtAndPlcOfBirthField == null))
        {
          this.dtAndPlcOfBirthField = new DateAndPlaceOfBirth();
        }
        return this.dtAndPlcOfBirthField;
      }
      set
      {
        this.dtAndPlcOfBirthField = value;
      }
    }

    [XmlElementAttribute("Othr", Order = 1, ElementName = "Othr")]
    public List<GenericPersonIdentification1> Othr
    {
      get
      {
        if ((this.othrField == null))
        {
          this.othrField = new List<GenericPersonIdentification1>();
        }
        return this.othrField;
      }
      set
      {
        this.othrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DateAndPlaceOfBirth")]
  [XmlRootAttribute("DateAndPlaceOfBirth")]
  public partial class DateAndPlaceOfBirth
  {

    [XmlElementAttribute(DataType = "date", Order = 0, ElementName = "BirthDt")]
    public System.DateTime BirthDt { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "PrvcOfBirth")]
    public string PrvcOfBirth { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "CityOfBirth")]
    public string CityOfBirth { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "CtryOfBirth")]
    public string CtryOfBirth { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "GenericPersonIdentification1")]
  [XmlRootAttribute("GenericPersonIdentification1")]
  public partial class GenericPersonIdentification1
  {

    private PersonIdentificationSchemeName1Choice schmeNmField;

    [XmlElementAttribute(Order = 0, ElementName = "Id")]
    public string Id { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "Issr")]
    public string Issr { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "SchmeNm")]
    public PersonIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        if ((this.schmeNmField == null))
        {
          this.schmeNmField = new PersonIdentificationSchemeName1Choice();
        }
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "PersonIdentificationSchemeName1Choice")]
  [XmlRootAttribute("PersonIdentificationSchemeName1Choice")]
  public partial class PersonIdentificationSchemeName1Choice
  {

  [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "ContactDetails2")]
  [XmlRootAttribute("ContactDetails2")]
  public partial class ContactDetails2
  {

    private System.Nullable<NamePrefix1Code> nmPrfxField;

    [XmlElementAttribute(Order = 1, ElementName = "Nm")]
    public string Nm { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "PhneNb")]
    public string PhneNb { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "MobNb")]
    public string MobNb { get; set; }
    [XmlElementAttribute(Order = 4, ElementName = "FaxNb")]
    public string FaxNb { get; set; }
    [XmlElementAttribute(Order = 5, ElementName = "EmailAdr")]
    public string EmailAdr { get; set; }
    [XmlElementAttribute(Order = 6, ElementName = "Othr")]
    public string Othr { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "NmPrfx")]
    public NamePrefix1Code NmPrfx
    {
      get
      {
        if (this.nmPrfxField.HasValue)
        {
          return this.nmPrfxField.Value;
        }
        else
        {
          return default(NamePrefix1Code);
        }
      }
      set
      {
        this.nmPrfxField = value;
      }
    }

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("NmPrfxSpecified")]
    public bool NmPrfxSpecified
    {
      get
      {
        return this.nmPrfxField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.nmPrfxField = null;
        }
      }
    }
  }


  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "NamePrefix1Code")]
  [XmlRootAttribute("NamePrefix1Code")]
  public enum NamePrefix1Code
  {

    DOCT,

    MIST,

    MISS,

    MADM,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "NameAndAddress10")]
  [XmlRootAttribute("NameAndAddress10")]
  public partial class NameAndAddress10
  {

    private PostalAddress6 adrField;

    [XmlElementAttribute(Order = 0, ElementName = "Nm")]
    public string Nm { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "Adr")]
    public PostalAddress6 Adr
    {
      get
      {
        if ((this.adrField == null))
        {
          this.adrField = new PostalAddress6();
        }
        return this.adrField;
      }
      set
      {
        this.adrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(TypeName = "RemittanceLocation2")]
  [XmlRootAttribute("RemittanceLocation2")]
  public partial class RemittanceLocation2
  {

    private System.Nullable<RemittanceLocationMethod2Code> rmtLctnMtdField;

    private NameAndAddress10 rmtLctnPstlAdrField;

    [XmlElementAttribute(Order = 0, ElementName = "RmtId")]
    public string RmtId { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "RmtLctnElctrncAdr")]
    public string RmtLctnElctrncAdr { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "RmtLctnMtd")]
    public RemittanceLocationMethod2Code RmtLctnMtd
    {
      get
      {
        if (this.rmtLctnMtdField.HasValue)
        {
          return this.rmtLctnMtdField.Value;
        }
        else
        {
          return default(RemittanceLocationMethod2Code);
        }
      }
      set
      {
        this.rmtLctnMtdField = value;
      }
    }

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("RmtLctnMtdSpecified")]
    public bool RmtLctnMtdSpecified
    {
      get
      {
        return this.rmtLctnMtdField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rmtLctnMtdField = null;
        }
      }
    }

    [XmlElementAttribute(Order = 3, ElementName = "RmtLctnPstlAdr")]
    public NameAndAddress10 RmtLctnPstlAdr
    {
      get
      {
        if ((this.rmtLctnPstlAdrField == null))
        {
          this.rmtLctnPstlAdrField = new NameAndAddress10();
        }
        return this.rmtLctnPstlAdrField;
      }
      set
      {
        this.rmtLctnPstlAdrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [XmlTypeAttribute(TypeName = "RemittanceLocationMethod2Code")]
  [XmlRootAttribute("RemittanceLocationMethod2Code")]
  public enum RemittanceLocationMethod2Code
  {

    FAXI,

    EDIC,

    URID,

    EMAL,

    POST,

    SMSM,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(TypeName = "TaxRecordDetails1")]
  [XmlRootAttribute("TaxRecordDetails1")]
  public partial class TaxRecordDetails1
  {

    private TaxPeriod1 prdField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    [XmlElementAttribute(Order = 0, ElementName = "Prd")]
    public TaxPeriod1 Prd
    {
      get
      {
        if ((this.prdField == null))
        {
          this.prdField = new TaxPeriod1();
        }
        return this.prdField;
      }
      set
      {
        this.prdField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "Amt")]
    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        if ((this.amtField == null))
        {
          this.amtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "TaxPeriod1")]
  [XmlRootAttribute("TaxPeriod1")]
  public partial class TaxPeriod1
  {

    private System.Nullable<TaxRecordPeriod1Code> tpField;

    private DatePeriodDetails frToDtField;

    [XmlElementAttribute(DataType = "date", Order = 0, ElementName = "Yr")]
    public System.DateTime Yr { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("YrSpecified")]
    public bool YrSpecified { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "Tp")]
    public TaxRecordPeriod1Code Tp
    {
      get
      {
        if (this.tpField.HasValue)
        {
          return this.tpField.Value;
        }
        else
        {
          return default(TaxRecordPeriod1Code);
        }
      }
      set
      {
        this.tpField = value;
      }
    }

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("TpSpecified")]
    public bool TpSpecified
    {
      get
      {
        return this.tpField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.tpField = null;
        }
      }
    }

    [XmlElementAttribute(Order = 2, ElementName = "FrToDt")]
    public DatePeriodDetails FrToDt
    {
      get
      {
        if ((this.frToDtField == null))
        {
          this.frToDtField = new DatePeriodDetails();
        }
        return this.frToDtField;
      }
      set
      {
        this.frToDtField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DatePeriodDetails")]
  [XmlRootAttribute("DatePeriodDetails")]
  public partial class DatePeriodDetails
  {

    [XmlElementAttribute(DataType = "date", Order = 0, ElementName = "FrDt")]
    public System.DateTime FrDt { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 1, ElementName = "ToDt")]
    public System.DateTime ToDt { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "TaxAmount1")]
  [XmlRootAttribute("TaxAmount1")]
  public partial class TaxAmount1
  {

    private ActiveOrHistoricCurrencyAndAmount taxblBaseAmtField;

    private ActiveOrHistoricCurrencyAndAmount ttlAmtField;

    private List<TaxRecordDetails1> dtlsField;

    [XmlElementAttribute(Order = 0, ElementName = "Rate")]
    public decimal Rate { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("RateSpecified")]
    public bool RateSpecified { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "TaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt
    {
      get
      {
        if ((this.taxblBaseAmtField == null))
        {
          this.taxblBaseAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.taxblBaseAmtField;
      }
      set
      {
        this.taxblBaseAmtField = value;
      }
    }

    [XmlElementAttribute(Order = 2, ElementName = "TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount TtlAmt
    {
      get
      {
        if ((this.ttlAmtField == null))
        {
          this.ttlAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.ttlAmtField;
      }
      set
      {
        this.ttlAmtField = value;
      }
    }

    [XmlElementAttribute("Dtls", Order = 3, ElementName = "Dtls")]
    public List<TaxRecordDetails1> Dtls
    {
      get
      {
        if ((this.dtlsField == null))
        {
          this.dtlsField = new List<TaxRecordDetails1>();
        }
        return this.dtlsField;
      }
      set
      {
        this.dtlsField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "TaxRecord1")]
  [XmlRootAttribute("TaxRecord1")]
  public partial class TaxRecord1
  {

    private TaxPeriod1 prdField;

    private TaxAmount1 taxAmtField;

    [XmlElementAttribute(Order = 0, ElementName = "Tp")]
    public string Tp { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "Ctgy")]
    public string Ctgy { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "CtgyDtls")]
    public string CtgyDtls { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "DbtrSts")]
    public string DbtrSts { get; set; }
    [XmlElementAttribute(Order = 4, ElementName = "CertId")]
    public string CertId { get; set; }
    [XmlElementAttribute(Order = 5, ElementName = "FrmsCd")]
    public string FrmsCd { get; set; }
    [XmlElementAttribute(Order = 8, ElementName = "AddtlInf")]
    public string AddtlInf { get; set; }

    [XmlElementAttribute(Order = 6, ElementName = "Prd")]
    public TaxPeriod1 Prd
    {
      get
      {
        if ((this.prdField == null))
        {
          this.prdField = new TaxPeriod1();
        }
        return this.prdField;
      }
      set
      {
        this.prdField = value;
      }
    }

    [XmlElementAttribute(Order = 7, ElementName = "TaxAmt")]
    public TaxAmount1 TaxAmt
    {
      get
      {
        if ((this.taxAmtField == null))
        {
          this.taxAmtField = new TaxAmount1();
        }
        return this.taxAmtField;
      }
      set
      {
        this.taxAmtField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "TaxAuthorisation1")]
  [XmlRootAttribute("TaxAuthorisation1")]
  public partial class TaxAuthorisation1
  {

    [XmlElementAttribute(Order = 0, ElementName = "Titl")]
    public string Titl { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "Nm")]
    public string Nm { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "TaxParty2")]
  [XmlRootAttribute("TaxParty2")]
  public partial class TaxParty2
  {

    private TaxAuthorisation1 authstnField;

    [XmlElementAttribute(Order = 0, ElementName = "TaxId")]
    public string TaxId { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "RegnId")]
    public string RegnId { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "TaxTp")]
    public string TaxTp { get; set; }

    [XmlElementAttribute(Order = 3, ElementName = "Authstn")]
    public TaxAuthorisation1 Authstn
    {
      get
      {
        if ((this.authstnField == null))
        {
          this.authstnField = new TaxAuthorisation1();
        }
        return this.authstnField;
      }
      set
      {
        this.authstnField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "TaxParty1")]
  [XmlRootAttribute("TaxParty1")]
  public partial class TaxParty1
  {

    [XmlElementAttribute(Order = 0, ElementName = "TaxId")]
    public string TaxId { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "RegnId")]
    public string RegnId { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "TaxTp")]
    public string TaxTp { get; set; }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "StructuredRegulatoryReporting3")]
  [XmlRootAttribute("StructuredRegulatoryReporting3")]
  public partial class StructuredRegulatoryReporting3
  {

    private ActiveOrHistoricCurrencyAndAmount amtField;

    [XmlElementAttribute(Order = 0, ElementName = "Tp")]
    public string Tp { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 1, ElementName = "Dt")]
    public System.DateTime Dt { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("DtSpecified")]
    public bool DtSpecified { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "Ctry")]
    public string Ctry { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "Cd")]
    public string Cd { get; set; }
    [XmlElementAttribute("Inf", Order = 5, ElementName = "Inf")]
    public List<string> Inf { get; set; }

    [XmlElementAttribute(Order = 4, ElementName = "Amt")]
    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        if ((this.amtField == null))
        {
          this.amtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }
  }



  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "RegulatoryReportingType1Code")]
  [XmlRootAttribute("RegulatoryReportingType1Code")]
  public enum RegulatoryReportingType1Code
  {

    CRED,

    DEBT,

    BOTH,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "Purpose2Choice")]
  [XmlRootAttribute("Purpose2Choice")]
  public partial class Purpose2Choice
  {
    
    [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType9 ItemElementName { get; set; }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "AmendmentInformationDetails8")]
  [XmlRootAttribute("AmendmentInformationDetails8")]
  public partial class AmendmentInformationDetails8
  {

    private PartyIdentification43 orgnlCdtrSchmeIdField;

    private BranchAndFinancialInstitutionIdentification5 orgnlCdtrAgtField;

    private CashAccount24 orgnlCdtrAgtAcctField;

    private PartyIdentification43 orgnlDbtrField;

    private CashAccount24 orgnlDbtrAcctField;

    private BranchAndFinancialInstitutionIdentification5 orgnlDbtrAgtField;

    private CashAccount24 orgnlDbtrAgtAcctField;

    private System.Nullable<Frequency6Code> orgnlFrqcyField;

    [XmlElementAttribute(Order = 0, ElementName = "OrgnlMndtId")]
    public string OrgnlMndtId { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 8, ElementName = "OrgnlFnlColltnDt")]
    public System.DateTime OrgnlFnlColltnDt { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("OrgnlFnlColltnDtSpecified")]
    public bool OrgnlFnlColltnDtSpecified { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "OrgnlCdtrSchmeId")]
    public PartyIdentification43 OrgnlCdtrSchmeId
    {
      get
      {
        if ((this.orgnlCdtrSchmeIdField == null))
        {
          this.orgnlCdtrSchmeIdField = new PartyIdentification43();
        }
        return this.orgnlCdtrSchmeIdField;
      }
      set
      {
        this.orgnlCdtrSchmeIdField = value;
      }
    }

    [XmlElementAttribute(Order = 2, ElementName = "OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt
    {
      get
      {
        if ((this.orgnlCdtrAgtField == null))
        {
          this.orgnlCdtrAgtField = new BranchAndFinancialInstitutionIdentification5();
        }
        return this.orgnlCdtrAgtField;
      }
      set
      {
        this.orgnlCdtrAgtField = value;
      }
    }

    [XmlElementAttribute(Order = 3, ElementName = "OrgnlCdtrAgtAcct")]
    public CashAccount24 OrgnlCdtrAgtAcct
    {
      get
      {
        if ((this.orgnlCdtrAgtAcctField == null))
        {
          this.orgnlCdtrAgtAcctField = new CashAccount24();
        }
        return this.orgnlCdtrAgtAcctField;
      }
      set
      {
        this.orgnlCdtrAgtAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 4, ElementName = "OrgnlDbtr")]
    public PartyIdentification43 OrgnlDbtr
    {
      get
      {
        if ((this.orgnlDbtrField == null))
        {
          this.orgnlDbtrField = new PartyIdentification43();
        }
        return this.orgnlDbtrField;
      }
      set
      {
        this.orgnlDbtrField = value;
      }
    }

    [XmlElementAttribute(Order = 5, ElementName = "OrgnlDbtrAcct")]
    public CashAccount24 OrgnlDbtrAcct
    {
      get
      {
        if ((this.orgnlDbtrAcctField == null))
        {
          this.orgnlDbtrAcctField = new CashAccount24();
        }
        return this.orgnlDbtrAcctField;
      }
      set
      {
        this.orgnlDbtrAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 6, ElementName = "OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt
    {
      get
      {
        if ((this.orgnlDbtrAgtField == null))
        {
          this.orgnlDbtrAgtField = new BranchAndFinancialInstitutionIdentification5();
        }
        return this.orgnlDbtrAgtField;
      }
      set
      {
        this.orgnlDbtrAgtField = value;
      }
    }

    [XmlElementAttribute(Order = 7, ElementName = "OrgnlDbtrAgtAcct")]
    public CashAccount24 OrgnlDbtrAgtAcct
    {
      get
      {
        if ((this.orgnlDbtrAgtAcctField == null))
        {
          this.orgnlDbtrAgtAcctField = new CashAccount24();
        }
        return this.orgnlDbtrAgtAcctField;
      }
      set
      {
        this.orgnlDbtrAgtAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 9, ElementName = "OrgnlFrqcy")]
    public Frequency6Code OrgnlFrqcy
    {
      get
      {
        if (this.orgnlFrqcyField.HasValue)
        {
          return this.orgnlFrqcyField.Value;
        }
        else
        {
          return default(Frequency6Code);
        }
      }
      set
      {
        this.orgnlFrqcyField = value;
      }
    }

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("OrgnlFrqcySpecified")]
    public bool OrgnlFrqcySpecified
    {
      get
      {
        return this.orgnlFrqcyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.orgnlFrqcyField = null;
        }
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "FinancialInstitutionIdentification8")]
  [XmlRootAttribute("FinancialInstitutionIdentification8")]
  public partial class FinancialInstitutionIdentification8
  {

    private ClearingSystemMemberIdentification2 _clrSysMmbIdField;

    private PostalAddress6 _pstlAdrField;

    private GenericFinancialIdentification1 _othrField;

    [XmlElementAttribute(Order = 0, ElementName = "BICFI")]
    public string BICFI { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "Nm")]
    public string Nm { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "ClrSysMmbId")]
    public ClearingSystemMemberIdentification2 ClrSysMmbId
    {
      get
      {
        if ((this._clrSysMmbIdField == null))
        {
          this._clrSysMmbIdField = new ClearingSystemMemberIdentification2();
        }
        return this._clrSysMmbIdField;
      }
      set
      {
        this._clrSysMmbIdField = value;
      }
    }

    [XmlElementAttribute(Order = 3, ElementName = "PstlAdr")]
    public PostalAddress6 PostalAddress
    {
      get
      {
        if ((this._pstlAdrField == null))
        {
          this._pstlAdrField = new PostalAddress6();
        }
        return this._pstlAdrField;
      }
      set
      {
        this._pstlAdrField = value;
      }
    }

    [XmlElementAttribute(Order = 4, ElementName = "Othr")]
    public GenericFinancialIdentification1 Other
    {
      get
      {
        if ((this._othrField == null))
        {
          this._othrField = new GenericFinancialIdentification1();
        }
        return this._othrField;
      }
      set
      {
        this._othrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "ClearingSystemMemberIdentification2")]
  [XmlRootAttribute("ClearingSystemMemberIdentification2")]
  public partial class ClearingSystemMemberIdentification2
  {

    private ClearingSystemIdentification2Choice clrSysIdField;

    [XmlElementAttribute(Order = 1, ElementName = "MmbId")]
    public string MmbId { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "ClrSysId")]
    public ClearingSystemIdentification2Choice ClrSysId
    {
      get
      {
        if ((this.clrSysIdField == null))
        {
          this.clrSysIdField = new ClearingSystemIdentification2Choice();
        }
        return this.clrSysIdField;
      }
      set
      {
        this.clrSysIdField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "ClearingSystemIdentification2Choice")]
  [XmlRootAttribute("ClearingSystemIdentification2Choice")]
  public partial class ClearingSystemIdentification2Choice
  {
    
    [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "GenericFinancialIdentification1")]
  [XmlRootAttribute("GenericFinancialIdentification1")]
  public partial class GenericFinancialIdentification1
  {

    private FinancialIdentificationSchemeName1Choice schmeNmField;

    [XmlElementAttribute(Order = 0, ElementName = "Id")]
    public string Id { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "Issr")]
    public string Issr { get; set; }

    [XmlElementAttribute(Order = 1, ElementName = "SchmeNm")]
    public FinancialIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        if ((this.schmeNmField == null))
        {
          this.schmeNmField = new FinancialIdentificationSchemeName1Choice();
        }
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "FinancialIdentificationSchemeName1Choice")]
  [XmlRootAttribute("FinancialIdentificationSchemeName1Choice")]
  public partial class FinancialIdentificationSchemeName1Choice
  {
    [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType3 ItemElementName { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "BranchData2")]
  [XmlRootAttribute("BranchData2")]
  public partial class BranchData2
  {

    private PostalAddress6 pstlAdrField;

    [XmlElementAttribute(Order = 0, ElementName = "Id")]
    public string Id { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "Nm")]
    public string Nm { get; set; }

    [XmlElementAttribute(Order = 2, ElementName = "PstlAdr")]
    public PostalAddress6 PstlAdr
    {
      get
      {
        if ((this.pstlAdrField == null))
        {
          this.pstlAdrField = new PostalAddress6();
        }
        return this.pstlAdrField;
      }
      set
      {
        this.pstlAdrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "CashAccount24")]
  [XmlRootAttribute("CashAccount24")]
  public partial class CashAccount24
  {

    private AccountIdentification4Choice idField;

    private CashAccountType2Choice tpField;

    [XmlElementAttribute(Order = 2, ElementName = "Ccy")]
    public string Ccy { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "Nm")]
    public string Nm { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "Id")]
    public AccountIdentification4Choice Id
    {
      get
      {
        if ((this.idField == null))
        {
          this.idField = new AccountIdentification4Choice();
        }
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "Tp")]
    public CashAccountType2Choice Tp
    {
      get
      {
        if ((this.tpField == null))
        {
          this.tpField = new CashAccountType2Choice();
        }
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "AccountIdentification4Choice")]
  [XmlRootAttribute("AccountIdentification4Choice")]
  public partial class AccountIdentification4Choice
  {
    [XmlElementAttribute("IBAN", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Othr", typeof(GenericAccountIdentification1), Order = 0)]
    public object Item { get; set; }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "CashAccountType2Choice")]
  [XmlRootAttribute("CashAccountType2Choice")]
  public partial class CashAccountType2Choice
  {
    [XmlElementAttribute("Cd", typeof(string), Order = 0, ElementName = "Item")]
    [XmlElementAttribute("Prtry", typeof(string), Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "ItemElementName")]
    [XmlIgnoreAttribute()]
    public ItemChoiceType8 ItemElementName { get; set; }
  }



  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "Frequency6Code")]
  [XmlRootAttribute("Frequency6Code")]
  public enum Frequency6Code
  {

    YEAR,

    MNTH,

    QURT,

    MIAN,

    WEEK,

    DAIL,

    ADHO,

    INDA,

    FRTN,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "MandateRelatedInformation8")]
  [XmlRootAttribute("MandateRelatedInformation8")]
  public partial class MandateRelatedInformation8
  {

    private AmendmentInformationDetails8 amdmntInfDtlsField;

    private System.Nullable<Frequency6Code> frqcyField;

    [XmlElementAttribute(Order = 0, ElementName = "MndtId")]
    public string MndtId { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 1, ElementName = "DtOfSgntr")]
    public System.DateTime DtOfSgntr { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("DtOfSgntrSpecified")]
    public bool DtOfSgntrSpecified { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "AmdmntInd")]
    public bool AmdmntInd { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("AmdmntIndSpecified")]
    public bool AmdmntIndSpecified { get; set; }
    [XmlElementAttribute(Order = 4, ElementName = "ElctrncSgntr")]
    public string ElctrncSgntr { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 5, ElementName = "FrstColltnDt")]
    public System.DateTime FrstColltnDt { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("FrstColltnDtSpecified")]
    public bool FrstColltnDtSpecified { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 6, ElementName = "FnlColltnDt")]
    public System.DateTime FnlColltnDt { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("FnlColltnDtSpecified")]
    public bool FnlColltnDtSpecified { get; set; }

    [XmlElementAttribute(Order = 3, ElementName = "AmdmntInfDtls")]
    public AmendmentInformationDetails8 AmdmntInfDtls
    {
      get
      {
        if ((this.amdmntInfDtlsField == null))
        {
          this.amdmntInfDtlsField = new AmendmentInformationDetails8();
        }
        return this.amdmntInfDtlsField;
      }
      set
      {
        this.amdmntInfDtlsField = value;
      }
    }

    [XmlElementAttribute(Order = 7, ElementName = "Frqcy")]
    public Frequency6Code Frqcy
    {
      get
      {
        if (this.frqcyField.HasValue)
        {
          return this.frqcyField.Value;
        }
        else
        {
          return default(Frequency6Code);
        }
      }
      set
      {
        this.frqcyField = value;
      }
    }

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("FrqcySpecified")]
    public bool FrqcySpecified
    {
      get
      {
        return this.frqcyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.frqcyField = null;
        }
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DirectDebitTransaction7")]
  [XmlRootAttribute("DirectDebitTransaction7")]
  public partial class DirectDebitTransaction7
  {

    private MandateRelatedInformation8 mndtRltdInfField;

    private PartyIdentification43 cdtrSchmeIdField;

    [XmlElementAttribute(Order = 2, ElementName = "PreNtfctnId")]
    public string PreNtfctnId { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 3, ElementName = "PreNtfctnDt")]
    public System.DateTime PreNtfctnDt { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("PreNtfctnDtSpecified")]
    public bool PreNtfctnDtSpecified { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "MndtRltdInf")]
    public MandateRelatedInformation8 MndtRltdInf
    {
      get
      {
        if ((this.mndtRltdInfField == null))
        {
          this.mndtRltdInfField = new MandateRelatedInformation8();
        }
        return this.mndtRltdInfField;
      }
      set
      {
        this.mndtRltdInfField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "CdtrSchmeId")]
    public PartyIdentification43 CdtrSchmeId
    {
      get
      {
        if ((this.cdtrSchmeIdField == null))
        {
          this.cdtrSchmeIdField = new PartyIdentification43();
        }
        return this.cdtrSchmeIdField;
      }
      set
      {
        this.cdtrSchmeIdField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "DirectDebitTransactionInformation11")]
  [XmlRootAttribute("DirectDebitTransactionInformation11")]
  public partial class DirectDebitTransactionInformation11
  {

    private PaymentIdentification1 pmtIdField;

    private PaymentTypeInformation24 pmtTpInfField;

    private ActiveOrHistoricCurrencyAndAmount instdAmtField;

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    private DirectDebitTransaction7 drctDbtTxField;

    private PartyIdentification43 ultmtCdtrField;

    private BranchAndFinancialInstitutionIdentification5 dbtrAgtField;

    private CashAccount24 dbtrAgtAcctField;

    private PartyIdentification43 dbtrField;

    private CashAccount24 dbtrAcctField;

    private PartyIdentification43 ultmtDbtrField;

    private Purpose2Choice purpField;

    private List<RegulatoryReporting3> rgltryRptgField;

    private TaxInformation3 taxField;

    private List<RemittanceLocation2> rltdRmtInfField;

    private RemittanceInformation7 rmtInfField;

    [XmlElementAttribute(Order = 11, ElementName = "InstrForCdtrAgt")]
    public string InstrForCdtrAgt { get; set; }

    [XmlElementAttribute(Order = 0, ElementName = "PmtId")]
    public PaymentIdentification1 PmtId
    {
      get
      {
        if ((this.pmtIdField == null))
        {
          this.pmtIdField = new PaymentIdentification1();
        }
        return this.pmtIdField;
      }
      set
      {
        this.pmtIdField = value;
      }
    }

    [XmlElementAttribute(Order = 1, ElementName = "PmtTpInf")]
    public PaymentTypeInformation24 PmtTpInf
    {
      get
      {
        if ((this.pmtTpInfField == null))
        {
          this.pmtTpInfField = new PaymentTypeInformation24();
        }
        return this.pmtTpInfField;
      }
      set
      {
        this.pmtTpInfField = value;
      }
    }

    [XmlElementAttribute(Order = 2, ElementName = "InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount InstdAmt
    {
      get
      {
        if ((this.instdAmtField == null))
        {
          this.instdAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return this.instdAmtField;
      }
      set
      {
        this.instdAmtField = value;
      }
    }

    [XmlElementAttribute(Order = 3, ElementName = "ChrgBr")]
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

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("ChrgBrSpecified")]
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

    [XmlElementAttribute(Order = 4, ElementName = "DrctDbtTx")]
    public DirectDebitTransaction7 DrctDbtTx
    {
      get
      {
        if ((this.drctDbtTxField == null))
        {
          this.drctDbtTxField = new DirectDebitTransaction7();
        }
        return this.drctDbtTxField;
      }
      set
      {
        this.drctDbtTxField = value;
      }
    }

    [XmlElementAttribute(Order = 5, ElementName = "UltmtCdtr")]
    public PartyIdentification43 UltmtCdtr
    {
      get
      {
        if ((this.ultmtCdtrField == null))
        {
          this.ultmtCdtrField = new PartyIdentification43();
        }
        return this.ultmtCdtrField;
      }
      set
      {
        this.ultmtCdtrField = value;
      }
    }

    [XmlElementAttribute(Order = 6, ElementName = "DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5 DbtrAgt
    {
      get
      {
        if ((this.dbtrAgtField == null))
        {
          this.dbtrAgtField = new BranchAndFinancialInstitutionIdentification5();
        }
        return this.dbtrAgtField;
      }
      set
      {
        this.dbtrAgtField = value;
      }
    }

    [XmlElementAttribute(Order = 7, ElementName = "DbtrAgtAcct")]
    public CashAccount24 DbtrAgtAcct
    {
      get
      {
        if ((this.dbtrAgtAcctField == null))
        {
          this.dbtrAgtAcctField = new CashAccount24();
        }
        return this.dbtrAgtAcctField;
      }
      set
      {
        this.dbtrAgtAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 8, ElementName = "Dbtr")]
    public PartyIdentification43 Dbtr
    {
      get
      {
        if ((this.dbtrField == null))
        {
          this.dbtrField = new PartyIdentification43();
        }
        return this.dbtrField;
      }
      set
      {
        this.dbtrField = value;
      }
    }

    [XmlElementAttribute(Order = 9, ElementName = "DbtrAcct")]
    public CashAccount24 DbtrAcct
    {
      get
      {
        if ((this.dbtrAcctField == null))
        {
          this.dbtrAcctField = new CashAccount24();
        }
        return this.dbtrAcctField;
      }
      set
      {
        this.dbtrAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 10, ElementName = "UltmtDbtr")]
    public PartyIdentification43 UltmtDbtr
    {
      get
      {
        if ((this.ultmtDbtrField == null))
        {
          this.ultmtDbtrField = new PartyIdentification43();
        }
        return this.ultmtDbtrField;
      }
      set
      {
        this.ultmtDbtrField = value;
      }
    }

    [XmlElementAttribute(Order = 12, ElementName = "Purp")]
    public Purpose2Choice Purp
    {
      get
      {
        if ((this.purpField == null))
        {
          this.purpField = new Purpose2Choice();
        }
        return this.purpField;
      }
      set
      {
        this.purpField = value;
      }
    }

    [XmlElementAttribute("RgltryRptg", Order = 13, ElementName = "RgltryRptg")]
    public List<RegulatoryReporting3> RgltryRptg
    {
      get
      {
        if ((this.rgltryRptgField == null))
        {
          this.rgltryRptgField = new List<RegulatoryReporting3>();
        }
        return this.rgltryRptgField;
      }
      set
      {
        this.rgltryRptgField = value;
      }
    }

    [XmlElementAttribute(Order = 14, ElementName = "Tax")]
    public TaxInformation3 Tax
    {
      get
      {
        if ((this.taxField == null))
        {
          this.taxField = new TaxInformation3();
        }
        return this.taxField;
      }
      set
      {
        this.taxField = value;
      }
    }

    [XmlElementAttribute("RltdRmtInf", Order = 15, ElementName = "RltdRmtInf")]
    public List<RemittanceLocation2> RltdRmtInf
    {
      get
      {
        if ((this.rltdRmtInfField == null))
        {
          this.rltdRmtInfField = new List<RemittanceLocation2>();
        }
        return this.rltdRmtInfField;
      }
      set
      {
        this.rltdRmtInfField = value;
      }
    }

    [XmlElementAttribute(Order = 16, ElementName = "RmtInf")]
    public RemittanceInformation7 RmtInf
    {
      get
      {
        if ((this.rmtInfField == null))
        {
          this.rmtInfField = new RemittanceInformation7();
        }
        return this.rmtInfField;
      }
      set
      {
        this.rmtInfField = value;
      }
    }
  }


  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "Priority2Code")]
  [XmlRootAttribute("Priority2Code")]
  public enum Priority2Code
  {

    HIGH,

    NORM,
  }

  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "SequenceType3Code")]
  [XmlRootAttribute("SequenceType3Code")]
  public enum SequenceType3Code
  {

    FRST,

    RCUR,

    FNAL,

    OOFF,

    RPRE,
  }


  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "ChargeBearerType1Code")]
  [XmlRootAttribute("ChargeBearerType1Code")]
  public enum ChargeBearerType1Code
  {

    DEBT,

    CRED,

    SHAR,

    SLEV,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "PaymentInstruction7")]
  [XmlRootAttribute("PaymentInstruction7")]
  public partial class PaymentInstruction7
  {

    private PaymentTypeInformation24 pmtTpInfField;

    private PartyIdentification43 cdtrField;

    private CashAccount24 cdtrAcctField;

    private BranchAndFinancialInstitutionIdentification5 cdtrAgtField;

    private CashAccount24 cdtrAgtAcctField;

    private PartyIdentification43 ultmtCdtrField;

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    private CashAccount24 chrgsAcctField;

    private BranchAndFinancialInstitutionIdentification5 chrgsAcctAgtField;

    private PartyIdentification43 cdtrSchmeIdField;

    private List<DirectDebitTransactionInformation11> drctDbtTxInfField;

    [XmlElementAttribute(Order = 0, ElementName = "PmtInfId")]
    public string PmtInfId { get; set; }
    [XmlElementAttribute(Order = 1, ElementName = "PmtMtd")]
    public PaymentMethod2Code PmtMtd { get; set; }
    [XmlElementAttribute(Order = 2, ElementName = "BtchBookg")]
    public bool BtchBookg { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("BtchBookgSpecified")]
    public bool BtchBookgSpecified { get; set; }
    [XmlElementAttribute(Order = 3, ElementName = "NbOfTxs")]
    public string NbOfTxs { get; set; }
    [XmlElementAttribute(Order = 4, ElementName = "CtrlSum")]
    public decimal CtrlSum { get; set; }
    [XmlIgnoreAttribute()]
    [XmlElementAttribute("CtrlSumSpecified")]
    public bool CtrlSumSpecified { get; set; }
    [XmlElementAttribute(DataType = "date", Order = 6, ElementName = "ReqdColltnDt")]
    public System.DateTime ReqdColltnDt { get; set; }

    [XmlElementAttribute(Order = 5, ElementName = "PmtTpInf")]
    public PaymentTypeInformation24 PmtTpInf
    {
      get
      {
        if ((this.pmtTpInfField == null))
        {
          this.pmtTpInfField = new PaymentTypeInformation24();
        }
        return this.pmtTpInfField;
      }
      set
      {
        this.pmtTpInfField = value;
      }
    }

    [XmlElementAttribute(Order = 7, ElementName = "Cdtr")]
    public PartyIdentification43 Cdtr
    {
      get
      {
        if ((this.cdtrField == null))
        {
          this.cdtrField = new PartyIdentification43();
        }
        return this.cdtrField;
      }
      set
      {
        this.cdtrField = value;
      }
    }

    [XmlElementAttribute(Order = 8, ElementName = "CdtrAcct")]
    public CashAccount24 CdtrAcct
    {
      get
      {
        if ((this.cdtrAcctField == null))
        {
          this.cdtrAcctField = new CashAccount24();
        }
        return this.cdtrAcctField;
      }
      set
      {
        this.cdtrAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 9, ElementName = "CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5 CdtrAgt
    {
      get
      {
        if ((this.cdtrAgtField == null))
        {
          this.cdtrAgtField = new BranchAndFinancialInstitutionIdentification5();
        }
        return this.cdtrAgtField;
      }
      set
      {
        this.cdtrAgtField = value;
      }
    }

    [XmlElementAttribute(Order = 10, ElementName = "CdtrAgtAcct")]
    public CashAccount24 CdtrAgtAcct
    {
      get
      {
        if ((this.cdtrAgtAcctField == null))
        {
          this.cdtrAgtAcctField = new CashAccount24();
        }
        return this.cdtrAgtAcctField;
      }
      set
      {
        this.cdtrAgtAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 11, ElementName = "UltmtCdtr")]
    public PartyIdentification43 UltmtCdtr
    {
      get
      {
        if ((this.ultmtCdtrField == null))
        {
          this.ultmtCdtrField = new PartyIdentification43();
        }
        return this.ultmtCdtrField;
      }
      set
      {
        this.ultmtCdtrField = value;
      }
    }

    [XmlElementAttribute(Order = 12, ElementName = "ChrgBr")]
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

    [XmlIgnoreAttribute()]
    [XmlElementAttribute("ChrgBrSpecified")]
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

    [XmlElementAttribute(Order = 13, ElementName = "ChrgsAcct")]
    public CashAccount24 ChrgsAcct
    {
      get
      {
        if ((this.chrgsAcctField == null))
        {
          this.chrgsAcctField = new CashAccount24();
        }
        return this.chrgsAcctField;
      }
      set
      {
        this.chrgsAcctField = value;
      }
    }

    [XmlElementAttribute(Order = 14, ElementName = "ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5 ChrgsAcctAgt
    {
      get
      {
        if ((this.chrgsAcctAgtField == null))
        {
          this.chrgsAcctAgtField = new BranchAndFinancialInstitutionIdentification5();
        }
        return this.chrgsAcctAgtField;
      }
      set
      {
        this.chrgsAcctAgtField = value;
      }
    }

    [XmlElementAttribute(Order = 15, ElementName = "CdtrSchmeId")]
    public PartyIdentification43 CdtrSchmeId
    {
      get
      {
        if ((this.cdtrSchmeIdField == null))
        {
          this.cdtrSchmeIdField = new PartyIdentification43();
        }
        return this.cdtrSchmeIdField;
      }
      set
      {
        this.cdtrSchmeIdField = value;
      }
    }

    [XmlElementAttribute("DrctDbtTxInf", Order = 16, ElementName = "DrctDbtTxInf")]
    public List<DirectDebitTransactionInformation11> DrctDbtTxInf
    {
      get
      {
        if ((this.drctDbtTxInfField == null))
        {
          this.drctDbtTxInfField = new List<DirectDebitTransactionInformation11>();
        }
        return this.drctDbtTxInfField;
      }
      set
      {
        this.drctDbtTxInfField = value;
      }
    }
  }


  [SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "PaymentMethod2Code")]
  [XmlRootAttribute("PaymentMethod2Code")]
  public enum PaymentMethod2Code
  {

    DD,
  }
}
