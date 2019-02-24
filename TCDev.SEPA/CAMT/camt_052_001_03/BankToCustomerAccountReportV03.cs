// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.BankToCustomerAccountReportV03.cs
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
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using TCDev.SEPA.CAMT.Generic;
using TCDev.SEPA.CAMT.Generic.Card;
using TCDev.SEPA.CAMT.Generic.PointOfInteraction;
using TCDev.SEPA.CAMT.Transaction;
using TCDev.SEPA.Generic;
using TCDev.SEPA.Generic.Contact;
using TCDev.SEPA.Generic.GroupHeader;
using TCDev.SEPA.Generic.Identification;
using TCDev.SEPA.Generic.Structured;
using TCDev.SEPA.Generic.Tax;

namespace TCDev.SEPA.CAMT
{
  // SEPA.Net SEPA Parser for C# 
  // https://sepa.codeplex.com
  // File: TCDev.SEPA.BankToCustomerAccountReportV03.cs
  // Author: Tim Cadenbach, TCDev    
  // Created: 07.09.2013                                          
  // Purpose:                                                
  //                                                         
  // Licensed under Microsoft Public License (Ms-PL)         
  // https://sepa.codeplex.com/license                       
  // Latest Changes                                          
  // ==========================================================

  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.03")]
  [XmlRoot(ElementName = "document", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.03", IsNullable = false)]
// ReSharper disable once InconsistentNaming
  public class camt_052_001_03
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private BankToCustomerAccountReportV03 _bkToCstmrAcctRptField;

    public camt_052_001_03()
    {
      _bkToCstmrAcctRptField = new BankToCustomerAccountReportV03();
    }

    [XmlElement("BkToCstmrAcctRpt")]
    public BankToCustomerAccountReportV03 BankToCustomerAccountReport
    {
      get { return _bkToCstmrAcctRptField; }
      set { _bkToCstmrAcctRptField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.03")]
  public class BankToCustomerAccountReportV03
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private GroupHeader58 _grpHdrField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<AccountReport12> _rptField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<SupplementaryData1> _splmtryDataField;

    public BankToCustomerAccountReportV03()
    {
      _splmtryDataField = new List<SupplementaryData1>();
      _rptField = new List<AccountReport12>();
      _grpHdrField = new GroupHeader58();
    }

    [XmlElement("GrpHdr")]
    public GroupHeader58 GroupHeader
    {
      get { return _grpHdrField; }
      set { _grpHdrField = value; }
    }

    [XmlElement("Rpt")]
    public List<AccountReport12> Report
    {
      get { return _rptField; }
      set { _rptField = value; }
    }

    [XmlElement("SplmtryData")]
    public List<SupplementaryData1> SuplementaryData
    {
      get { return _splmtryDataField; }
      set { _splmtryDataField = value; }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class DisplayCapabilities1
  {

    private UserInterface2Code dispTpField;

    private string nbOfLinesField;

    private string lineWidthField;

    public UserInterface2Code DispTp
    {
      get
      {
        return this.dispTpField;
      }
      set
      {
        this.dispTpField = value;
      }
    }

    public string NbOfLines
    {
      get
      {
        return this.nbOfLinesField;
      }
      set
      {
        this.nbOfLinesField = value;
      }
    }

    public string LineWidth
    {
      get
      {
        return this.lineWidthField;
      }
      set
      {
        this.lineWidthField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class CashDeposit1
  {

    private ActiveCurrencyAndAmount noteDnmtnField;

    private string nbOfNotesField;

    private ActiveCurrencyAndAmount amtField;

    public CashDeposit1()
    {
      this.amtField = new ActiveCurrencyAndAmount();
      this.noteDnmtnField = new ActiveCurrencyAndAmount();
    }

    public ActiveCurrencyAndAmount NoteDnmtn
    {
      get
      {
        return this.noteDnmtnField;
      }
      set
      {
        this.noteDnmtnField = value;
      }
    }

    public string NbOfNotes
    {
      get
      {
        return this.nbOfNotesField;
      }
      set
      {
        this.nbOfNotesField = value;
      }
    }

    public ActiveCurrencyAndAmount Amt
    {
      get
      {
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

  public partial class SecuritiesAccount13
  {

    private string idField;

    private GenericIdentification20 tpField;

    private string nmField;

    public SecuritiesAccount13()
    {
      this.tpField = new GenericIdentification20();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public GenericIdentification20 Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public string Nm
    {
      get
      {
        return this.nmField;
      }
      set
      {
        this.nmField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CorporateAction9
  {

    private string evtTpField;

    private string evtIdField;

    public string EvtTp
    {
      get
      {
        return this.evtTpField;
      }
      set
      {
        this.evtTpField = value;
      }
    }

    public string EvtId
    {
      get
      {
        return this.evtIdField;
      }
      set
      {
        this.evtIdField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ReturnReason5Choice
  {

    private string itemField;

    private ItemChoiceType16 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType16 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }

  
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class PaymentReturnReason2
  {

    private BankTransactionCodeStructure4 orgnlBkTxCdField;

    private PartyIdentification43 orgtrField;

    private ReturnReason5Choice rsnField;

    private List<string> addtlInfField;

    public PaymentReturnReason2()
    {
      this.addtlInfField = new List<string>();
      this.rsnField = new ReturnReason5Choice();
      this.orgtrField = new PartyIdentification43();
      this.orgnlBkTxCdField = new BankTransactionCodeStructure4();
    }

    public BankTransactionCodeStructure4 OrgnlBkTxCd
    {
      get
      {
        return this.orgnlBkTxCdField;
      }
      set
      {
        this.orgnlBkTxCdField = value;
      }
    }

    public PartyIdentification43 Orgtr
    {
      get
      {
        return this.orgtrField;
      }
      set
      {
        this.orgtrField = value;
      }
    }

    public ReturnReason5Choice Rsn
    {
      get
      {
        return this.rsnField;
      }
      set
      {
        this.rsnField = value;
      }
    }

    [XmlElementAttribute("AddtlInf")]
    public List<string> AddtlInf
    {
      get
      {
        return this.addtlInfField;
      }
      set
      {
        this.addtlInfField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BankTransactionCodeStructure4
  {

    private BankTransactionCodeStructure5 domnField;

    private ProprietaryBankTransactionCodeStructure1 prtryField;

    public BankTransactionCodeStructure4()
    {
      this.prtryField = new ProprietaryBankTransactionCodeStructure1();
      this.domnField = new BankTransactionCodeStructure5();
    }

    public BankTransactionCodeStructure5 Domn
    {
      get
      {
        return this.domnField;
      }
      set
      {
        this.domnField = value;
      }
    }

    public ProprietaryBankTransactionCodeStructure1 Prtry
    {
      get
      {
        return this.prtryField;
      }
      set
      {
        this.prtryField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BankTransactionCodeStructure5
  {

    private string cdField;

    private BankTransactionCodeStructure6 fmlyField;

    public BankTransactionCodeStructure5()
    {
      this.fmlyField = new BankTransactionCodeStructure6();
    }

    public string Cd
    {
      get
      {
        return this.cdField;
      }
      set
      {
        this.cdField = value;
      }
    }

    public BankTransactionCodeStructure6 Fmly
    {
      get
      {
        return this.fmlyField;
      }
      set
      {
        this.fmlyField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BankTransactionCodeStructure6
  {

    private string cdField;

    private string subFmlyCdField;

    public string Cd
    {
      get
      {
        return this.cdField;
      }
      set
      {
        this.cdField = value;
      }
    }

    public string SubFmlyCd
    {
      get
      {
        return this.subFmlyCdField;
      }
      set
      {
        this.subFmlyCdField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ProprietaryBankTransactionCodeStructure1
  {

    private string cdField;

    private string issrField;

    public string Cd
    {
      get
      {
        return this.cdField;
      }
      set
      {
        this.cdField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }
  

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class ProprietaryQuantity1
  {

    private string tpField;

    private string qtyField;

    public string Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public string Qty
    {
      get
      {
        return this.qtyField;
      }
      set
      {
        this.qtyField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class OriginalAndCurrentQuantities1
  {

    private decimal faceAmtField;

    private decimal amtsdValField;

    public decimal FaceAmt
    {
      get
      {
        return this.faceAmtField;
      }
      set
      {
        this.faceAmtField = value;
      }
    }

    public decimal AmtsdVal
    {
      get
      {
        return this.amtsdValField;
      }
      set
      {
        this.amtsdValField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class FinancialInstrumentQuantityChoice
  {

    private decimal itemField;

    private ItemChoiceType14 itemElementNameField;

    [XmlElementAttribute("AmtsdVal", typeof(decimal))]
    [XmlElementAttribute("FaceAmt", typeof(decimal))]
    [XmlElementAttribute("Unit", typeof(decimal))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public decimal Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType14 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class TransactionQuantities2Choice
  {

    private object itemField;

    [XmlElementAttribute("OrgnlAndCurFaceAmt", typeof(OriginalAndCurrentQuantities1))]
    [XmlElementAttribute("Prtry", typeof(ProprietaryQuantity1))]
    [XmlElementAttribute("Qty", typeof(FinancialInstrumentQuantityChoice))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class PriceRateOrAmountChoice
  {

    private object itemField;

    [XmlElementAttribute("Amt", typeof(ActiveOrHistoricCurrencyAnd13DecimalAmount))]
    [XmlElementAttribute("Rate", typeof(decimal))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class YieldedOrValueType1Choice
  {

    private object itemField;

    [XmlElementAttribute("ValTp", typeof(PriceValueType1Code))]
    [XmlElementAttribute("Yldd", typeof(bool))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }

  [SerializableAttribute()]
  public enum PriceValueType1Code
  {

    /// <remarks/>
    DISC,

    /// <remarks/>
    PREM,

    /// <remarks/>
    PARV,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class ProprietaryDate2
  {

    private string tpField;

    private DateAndDateTimeChoice dtField;

    public ProprietaryDate2()
    {
      this.dtField = new DateAndDateTimeChoice();
    }

    public string Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public DateAndDateTimeChoice Dt
    {
      get
      {
        return this.dtField;
      }
      set
      {
        this.dtField = value;
      }
    }
  }
  

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CreditorReferenceType1Choice
  {

    private object itemField;

    [XmlElementAttribute("Cd", typeof(DocumentType3Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum DocumentType3Code
  {

    /// <remarks/>
    RADM,

    /// <remarks/>
    RPIN,

    /// <remarks/>
    FXDR,

    /// <remarks/>
    DISP,

    /// <remarks/>
    PUOR,

    /// <remarks/>
    SCOR,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CreditorReferenceType2
  {

    private CreditorReferenceType1Choice cdOrPrtryField;

    private string issrField;

    public CreditorReferenceType2()
    {
      this.cdOrPrtryField = new CreditorReferenceType1Choice();
    }

    public CreditorReferenceType1Choice CdOrPrtry
    {
      get
      {
        return this.cdOrPrtryField;
      }
      set
      {
        this.cdOrPrtryField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CreditorReferenceInformation2
  {

    private CreditorReferenceType2 tpField;

    private string refField;

    public CreditorReferenceInformation2()
    {
      this.tpField = new CreditorReferenceType2();
    }

    public CreditorReferenceType2 Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public string Ref
    {
      get
      {
        return this.refField;
      }
      set
      {
        this.refField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class DocumentAdjustment1
  {

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private System.Nullable<CreditDebitCode> cdtDbtIndField;

    private string rsnField;

    private string addtlInfField;

    public DocumentAdjustment1()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

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

    public string Rsn
    {
      get
      {
        return this.rsnField;
      }
      set
      {
        this.rsnField = value;
      }
    }

    public string AddtlInf
    {
      get
      {
        return this.addtlInfField;
      }
      set
      {
        this.addtlInfField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class DiscountAmountType1Choice
  {

    private string itemField;

    private ItemChoiceType12 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType12 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class DiscountAmountAndType1
  {

    private DiscountAmountType1Choice tpField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    public DiscountAmountAndType1()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
      this.tpField = new DiscountAmountType1Choice();
    }

    public DiscountAmountType1Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
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

  public partial class RemittanceAmount2
  {

    private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

    private List<DiscountAmountAndType1> dscntApldAmtField;

    private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

    private List<TaxAmountAndType1> taxAmtField;

    private List<DocumentAdjustment1> adjstmntAmtAndRsnField;

    private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

    public RemittanceAmount2()
    {
      this.rmtdAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.adjstmntAmtAndRsnField = new List<DocumentAdjustment1>();
      this.taxAmtField = new List<TaxAmountAndType1>();
      this.cdtNoteAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.dscntApldAmtField = new List<DiscountAmountAndType1>();
      this.duePyblAmtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount DuePyblAmt
    {
      get
      {
        return this.duePyblAmtField;
      }
      set
      {
        this.duePyblAmtField = value;
      }
    }

    [XmlElementAttribute("DscntApldAmt")]
    public List<DiscountAmountAndType1> DscntApldAmt
    {
      get
      {
        return this.dscntApldAmtField;
      }
      set
      {
        this.dscntApldAmtField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt
    {
      get
      {
        return this.cdtNoteAmtField;
      }
      set
      {
        this.cdtNoteAmtField = value;
      }
    }

    [XmlElementAttribute("TaxAmt")]
    public List<TaxAmountAndType1> TaxAmt
    {
      get
      {
        return this.taxAmtField;
      }
      set
      {
        this.taxAmtField = value;
      }
    }

    [XmlElementAttribute("AdjstmntAmtAndRsn")]
    public List<DocumentAdjustment1> AdjstmntAmtAndRsn
    {
      get
      {
        return this.adjstmntAmtAndRsnField;
      }
      set
      {
        this.adjstmntAmtAndRsnField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount RmtdAmt
    {
      get
      {
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

  public partial class ReferredDocumentType1Choice
  {

    private object itemField;

    [XmlElementAttribute("Cd", typeof(DocumentType5Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum DocumentType5Code
  {

    /// <remarks/>
    MSIN,

    /// <remarks/>
    CNFA,

    /// <remarks/>
    DNFA,

    /// <remarks/>
    CINV,

    /// <remarks/>
    CREN,

    /// <remarks/>
    DEBN,

    /// <remarks/>
    HIRI,

    /// <remarks/>
    SBIN,

    /// <remarks/>
    CMCN,

    /// <remarks/>
    SOAC,

    /// <remarks/>
    DISP,

    /// <remarks/>
    BOLD,

    /// <remarks/>
    VCHR,

    /// <remarks/>
    AROI,

    /// <remarks/>
    TSUT,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ReferredDocumentType2
  {

    private ReferredDocumentType1Choice cdOrPrtryField;

    private string issrField;

    public ReferredDocumentType2()
    {
      this.cdOrPrtryField = new ReferredDocumentType1Choice();
    }

    public ReferredDocumentType1Choice CdOrPrtry
    {
      get
      {
        return this.cdOrPrtryField;
      }
      set
      {
        this.cdOrPrtryField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ReferredDocumentInformation3
  {

    private ReferredDocumentType2 tpField;

    private string nbField;

    private System.Nullable<System.DateTime> rltdDtField;

    public ReferredDocumentInformation3()
    {
      this.tpField = new ReferredDocumentType2();
    }

    public ReferredDocumentType2 Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public string Nb
    {
      get
      {
        return this.nbField;
      }
      set
      {
        this.nbField = value;
      }
    }

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime RltdDt
    {
      get
      {
        if (this.rltdDtField.HasValue)
        {
          return this.rltdDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.rltdDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool RltdDtSpecified
    {
      get
      {
        return this.rltdDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rltdDtField = null;
        }
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class RemittanceInformation7
  {

    private List<string> ustrdField;

    private List<StructuredRemittanceInformation9> strdField;

    public RemittanceInformation7()
    {
      this.strdField = new List<StructuredRemittanceInformation9>();
      this.ustrdField = new List<string>();
    }

    [XmlElementAttribute("Ustrd")]
    public List<string> Ustrd
    {
      get
      {
        return this.ustrdField;
      }
      set
      {
        this.ustrdField = value;
      }
    }

    [XmlElementAttribute("Strd")]
    public List<StructuredRemittanceInformation9> Strd
    {
      get
      {
        return this.strdField;
      }
      set
      {
        this.strdField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class RemittanceLocation2
  {

    private string rmtIdField;

    private System.Nullable<RemittanceLocationMethod2Code> rmtLctnMtdField;

    private string rmtLctnElctrncAdrField;

    private NameAndAddress10 rmtLctnPstlAdrField;

    public RemittanceLocation2()
    {
      this.rmtLctnPstlAdrField = new NameAndAddress10();
    }

    public string RmtId
    {
      get
      {
        return this.rmtIdField;
      }
      set
      {
        this.rmtIdField = value;
      }
    }

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

    public string RmtLctnElctrncAdr
    {
      get
      {
        return this.rmtLctnElctrncAdrField;
      }
      set
      {
        this.rmtLctnElctrncAdrField = value;
      }
    }

    public NameAndAddress10 RmtLctnPstlAdr
    {
      get
      {
        return this.rmtLctnPstlAdrField;
      }
      set
      {
        this.rmtLctnPstlAdrField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum RemittanceLocationMethod2Code
  {

    /// <remarks/>
    FAXI,

    /// <remarks/>
    EDIC,

    /// <remarks/>
    URID,

    /// <remarks/>
    EMAL,

    /// <remarks/>
    POST,

    /// <remarks/>
    SMSM,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class Purpose2Choice
  {

    private string itemField;

    private ItemChoiceType11 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType11 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ProprietaryAgent3
  {

    private string tpField;

    private BranchAndFinancialInstitutionIdentification5 agtField;

    public ProprietaryAgent3()
    {
      this.agtField = new BranchAndFinancialInstitutionIdentification5();
    }

    public string Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 Agt
    {
      get
      {
        return this.agtField;
      }
      set
      {
        this.agtField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class FinancialInstitutionIdentification8
  {

    private string bICFIField;

    private ClearingSystemMemberIdentification2 clrSysMmbIdField;

    private string nmField;

    private PostalAddress6 pstlAdrField;

    private GenericFinancialIdentification1 othrField;

    public FinancialInstitutionIdentification8()
    {
      this.othrField = new GenericFinancialIdentification1();
      this.pstlAdrField = new PostalAddress6();
      this.clrSysMmbIdField = new ClearingSystemMemberIdentification2();
    }

    public string BICFI
    {
      get
      {
        return this.bICFIField;
      }
      set
      {
        this.bICFIField = value;
      }
    }

    public ClearingSystemMemberIdentification2 ClrSysMmbId
    {
      get
      {
        return this.clrSysMmbIdField;
      }
      set
      {
        this.clrSysMmbIdField = value;
      }
    }

    public string Nm
    {
      get
      {
        return this.nmField;
      }
      set
      {
        this.nmField = value;
      }
    }

    public PostalAddress6 PstlAdr
    {
      get
      {
        return this.pstlAdrField;
      }
      set
      {
        this.pstlAdrField = value;
      }
    }

    public GenericFinancialIdentification1 Othr
    {
      get
      {
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

  public partial class ClearingSystemMemberIdentification2
  {

    private ClearingSystemIdentification2Choice clrSysIdField;

    private string mmbIdField;

    public ClearingSystemMemberIdentification2()
    {
      this.clrSysIdField = new ClearingSystemIdentification2Choice();
    }

    public ClearingSystemIdentification2Choice ClrSysId
    {
      get
      {
        return this.clrSysIdField;
      }
      set
      {
        this.clrSysIdField = value;
      }
    }

    public string MmbId
    {
      get
      {
        return this.mmbIdField;
      }
      set
      {
        this.mmbIdField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ClearingSystemIdentification2Choice
  {

    private string itemField;

    private ItemChoiceType5 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType5 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class GenericFinancialIdentification1
  {

    private string idField;

    private FinancialIdentificationSchemeName1Choice schmeNmField;

    private string issrField;

    public GenericFinancialIdentification1()
    {
      this.schmeNmField = new FinancialIdentificationSchemeName1Choice();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public FinancialIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class FinancialIdentificationSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType6 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType6 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BranchData2
  {

    private string idField;

    private string nmField;

    private PostalAddress6 pstlAdrField;

    public BranchData2()
    {
      this.pstlAdrField = new PostalAddress6();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public string Nm
    {
      get
      {
        return this.nmField;
      }
      set
      {
        this.nmField = value;
      }
    }

    public PostalAddress6 PstlAdr
    {
      get
      {
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

  public partial class ProprietaryParty3
  {

    private string tpField;

    private PartyIdentification43 ptyField;

    public ProprietaryParty3()
    {
      this.ptyField = new PartyIdentification43();
    }

    public string Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public PartyIdentification43 Pty
    {
      get
      {
        return this.ptyField;
      }
      set
      {
        this.ptyField = value;
      }
    }
  }

  
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AccountIdentification4Choice
  {

    private object itemField;

    [XmlElementAttribute("IBAN", typeof(string))]
    [XmlElementAttribute("Othr", typeof(GenericAccountIdentification1))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class GenericAccountIdentification1
  {

    private string idField;

    private AccountSchemeName1Choice schmeNmField;

    private string issrField;

    public GenericAccountIdentification1()
    {
      this.schmeNmField = new AccountSchemeName1Choice();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public AccountSchemeName1Choice SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AccountSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType3 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType3 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }




  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CashAccountType2Choice
  {

    private string itemField;

    private ItemChoiceType4 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType4 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ProprietaryReference1
  {

    private string tpField;

    private string refField;

    public string Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public string Ref
    {
      get
      {
        return this.refField;
      }
      set
      {
        this.refField = value;
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AmountAndCurrencyExchange3
  {

    private AmountAndCurrencyExchangeDetails3 instdAmtField;

    private AmountAndCurrencyExchangeDetails3 txAmtField;

    private AmountAndCurrencyExchangeDetails3 cntrValAmtField;

    private AmountAndCurrencyExchangeDetails3 anncdPstngAmtField;

    private List<AmountAndCurrencyExchangeDetails4> prtryAmtField;

    public AmountAndCurrencyExchange3()
    {
      this.prtryAmtField = new List<AmountAndCurrencyExchangeDetails4>();
      this.anncdPstngAmtField = new AmountAndCurrencyExchangeDetails3();
      this.cntrValAmtField = new AmountAndCurrencyExchangeDetails3();
      this.txAmtField = new AmountAndCurrencyExchangeDetails3();
      this.instdAmtField = new AmountAndCurrencyExchangeDetails3();
    }

    public AmountAndCurrencyExchangeDetails3 InstdAmt
    {
      get
      {
        return this.instdAmtField;
      }
      set
      {
        this.instdAmtField = value;
      }
    }

    public AmountAndCurrencyExchangeDetails3 TxAmt
    {
      get
      {
        return this.txAmtField;
      }
      set
      {
        this.txAmtField = value;
      }
    }

    public AmountAndCurrencyExchangeDetails3 CntrValAmt
    {
      get
      {
        return this.cntrValAmtField;
      }
      set
      {
        this.cntrValAmtField = value;
      }
    }

    public AmountAndCurrencyExchangeDetails3 AnncdPstngAmt
    {
      get
      {
        return this.anncdPstngAmtField;
      }
      set
      {
        this.anncdPstngAmtField = value;
      }
    }

    [XmlElementAttribute("PrtryAmt")]
    public List<AmountAndCurrencyExchangeDetails4> PrtryAmt
    {
      get
      {
        return this.prtryAmtField;
      }
      set
      {
        this.prtryAmtField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AmountAndCurrencyExchangeDetails3
  {

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private CurrencyExchange5 ccyXchgField;

    public AmountAndCurrencyExchangeDetails3()
    {
      this.ccyXchgField = new CurrencyExchange5();
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    public CurrencyExchange5 CcyXchg
    {
      get
      {
        return this.ccyXchgField;
      }
      set
      {
        this.ccyXchgField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CurrencyExchange5
  {

    private string srcCcyField;

    private string trgtCcyField;

    private string unitCcyField;

    private decimal xchgRateField;

    private string ctrctIdField;

    private System.Nullable<System.DateTime> qtnDtField;

    public string SrcCcy
    {
      get
      {
        return this.srcCcyField;
      }
      set
      {
        this.srcCcyField = value;
      }
    }

    public string TrgtCcy
    {
      get
      {
        return this.trgtCcyField;
      }
      set
      {
        this.trgtCcyField = value;
      }
    }

    public string UnitCcy
    {
      get
      {
        return this.unitCcyField;
      }
      set
      {
        this.unitCcyField = value;
      }
    }

    public decimal XchgRate
    {
      get
      {
        return this.xchgRateField;
      }
      set
      {
        this.xchgRateField = value;
      }
    }

    public string CtrctId
    {
      get
      {
        return this.ctrctIdField;
      }
      set
      {
        this.ctrctIdField = value;
      }
    }

    public System.DateTime QtnDt
    {
      get
      {
        if (this.qtnDtField.HasValue)
        {
          return this.qtnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.qtnDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool QtnDtSpecified
    {
      get
      {
        return this.qtnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.qtnDtField = null;
        }
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AmountAndCurrencyExchangeDetails4
  {

    private string tpField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private CurrencyExchange5 ccyXchgField;

    public AmountAndCurrencyExchangeDetails4()
    {
      this.ccyXchgField = new CurrencyExchange5();
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public string Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    public CurrencyExchange5 CcyXchg
    {
      get
      {
        return this.ccyXchgField;
      }
      set
      {
        this.ccyXchgField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CashBalanceAvailability2
  {

    private CashBalanceAvailabilityDate1 dtField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private CreditDebitCode cdtDbtIndField;

    public CashBalanceAvailability2()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
      this.dtField = new CashBalanceAvailabilityDate1();
    }

    public CashBalanceAvailabilityDate1 Dt
    {
      get
      {
        return this.dtField;
      }
      set
      {
        this.dtField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    public CreditDebitCode CdtDbtInd
    {
      get
      {
        return this.cdtDbtIndField;
      }
      set
      {
        this.cdtDbtIndField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CashBalanceAvailabilityDate1
  {

    private object itemField;

    [XmlElementAttribute("ActlDt", typeof(System.DateTime), DataType = "date")]
    [XmlElementAttribute("NbOfDays", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class Charges3
  {
 
    private ActiveOrHistoricCurrencyAndAmount ttlChrgsAndTaxAmtField;

    private List<ChargesRecord1> rcrdField;

    public Charges3()
    {
      this.rcrdField = new List<ChargesRecord1>();
      this.ttlChrgsAndTaxAmtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount TtlChrgsAndTaxAmt
    {
      get
      {
        return this.ttlChrgsAndTaxAmtField;
      }
      set
      {
        this.ttlChrgsAndTaxAmtField = value;
      }
    }

    [XmlElementAttribute("Rcrd")]
    public List<ChargesRecord1> Rcrd
    {
      get
      {
        return this.rcrdField;
      }
      set
      {
        this.rcrdField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ChargesRecord1
  {

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private System.Nullable<CreditDebitCode> cdtDbtIndField;

    private ChargeType3Choice tpField;

    private System.Nullable<decimal> rateField;

    private System.Nullable<ChargeBearerType1Code> brField;

    private BranchAndFinancialInstitutionIdentification5 agtField;

    private TaxCharges2 taxField;

    public ChargesRecord1()
    {
      this.taxField = new TaxCharges2();
      this.agtField = new BranchAndFinancialInstitutionIdentification5();
      this.tpField = new ChargeType3Choice();
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

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

    public ChargeType3Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public decimal Rate
    {
      get
      {
        if (this.rateField.HasValue)
        {
          return this.rateField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.rateField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool RateSpecified
    {
      get
      {
        return this.rateField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rateField = null;
        }
      }
    }

    public ChargeBearerType1Code Br
    {
      get
      {
        if (this.brField.HasValue)
        {
          return this.brField.Value;
        }
        else
        {
          return default(ChargeBearerType1Code);
        }
      }
      set
      {
        this.brField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool BrSpecified
    {
      get
      {
        return this.brField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.brField = null;
        }
      }
    }

    public BranchAndFinancialInstitutionIdentification5 Agt
    {
      get
      {
        return this.agtField;
      }
      set
      {
        this.agtField = value;
      }
    }

    public TaxCharges2 Tax
    {
      get
      {
        return this.taxField;
      }
      set
      {
        this.taxField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ChargeType3Choice
  {

    private object itemField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(GenericIdentification3))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum ChargeBearerType1Code
  {

    /// <remarks/>
    DEBT,

    /// <remarks/>
    CRED,

    /// <remarks/>
    SHAR,

    /// <remarks/>
    SLEV,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class TaxCharges2
  {

    private string idField;

    private System.Nullable<decimal> rateField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    public TaxCharges2()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public decimal Rate
    {
      get
      {
        if (this.rateField.HasValue)
        {
          return this.rateField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.rateField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool RateSpecified
    {
      get
      {
        return this.rateField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rateField = null;
        }
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
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

  public partial class InterestRecord1
  {

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private CreditDebitCode cdtDbtIndField;

    private InterestType1Choice tpField;

    private Rate3 rateField;

    private DateTimePeriodDetails frToDtField;

    private string rsnField;

    private TaxCharges2 taxField;

    public InterestRecord1()
    {
      this.taxField = new TaxCharges2();
      this.frToDtField = new DateTimePeriodDetails();
      this.rateField = new Rate3();
      this.tpField = new InterestType1Choice();
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    public CreditDebitCode CdtDbtInd
    {
      get
      {
        return this.cdtDbtIndField;
      }
      set
      {
        this.cdtDbtIndField = value;
      }
    }

    public InterestType1Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public Rate3 Rate
    {
      get
      {
        return this.rateField;
      }
      set
      {
        this.rateField = value;
      }
    }

    public DateTimePeriodDetails FrToDt
    {
      get
      {
        return this.frToDtField;
      }
      set
      {
        this.frToDtField = value;
      }
    }

    public string Rsn
    {
      get
      {
        return this.rsnField;
      }
      set
      {
        this.rsnField = value;
      }
    }

    public TaxCharges2 Tax
    {
      get
      {
        return this.taxField;
      }
      set
      {
        this.taxField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class InterestType1Choice
  {

    private object itemField;

    [XmlElementAttribute("Cd", typeof(InterestType1Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum InterestType1Code
  {

    /// <remarks/>
    INDY,

    /// <remarks/>
    OVRN,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class Rate3
  {

    private RateType4Choice tpField;

    private CurrencyAndAmountRange2 vldtyRgField;

    public Rate3()
    {
      this.vldtyRgField = new CurrencyAndAmountRange2();
      this.tpField = new RateType4Choice();
    }

    public RateType4Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public CurrencyAndAmountRange2 VldtyRg
    {
      get
      {
        return this.vldtyRgField;
      }
      set
      {
        this.vldtyRgField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class RateType4Choice
  {

    private object itemField;

    [XmlElementAttribute("Othr", typeof(string))]
    [XmlElementAttribute("Pctg", typeof(decimal))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CurrencyAndAmountRange2
  {

    private ImpliedCurrencyAmountRangeChoice amtField;

    private System.Nullable<CreditDebitCode> cdtDbtIndField;

    private string ccyField;

    public CurrencyAndAmountRange2()
    {
      this.amtField = new ImpliedCurrencyAmountRangeChoice();
    }

    public ImpliedCurrencyAmountRangeChoice Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

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

    public string Ccy
    {
      get
      {
        return this.ccyField;
      }
      set
      {
        this.ccyField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ImpliedCurrencyAmountRangeChoice
  {

    private object itemField;

    private ItemChoiceType7 itemElementNameField;

    [XmlElementAttribute("EQAmt", typeof(decimal))]
    [XmlElementAttribute("FrAmt", typeof(AmountRangeBoundary1))]
    [XmlElementAttribute("FrToAmt", typeof(FromToAmountRange))]
    [XmlElementAttribute("NEQAmt", typeof(decimal))]
    [XmlElementAttribute("ToAmt", typeof(AmountRangeBoundary1))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType7 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AmountRangeBoundary1
  {

    private decimal bdryAmtField;

    private bool inclField;

    public decimal BdryAmt
    {
      get
      {
        return this.bdryAmtField;
      }
      set
      {
        this.bdryAmtField = value;
      }
    }

    public bool Incl
    {
      get
      {
        return this.inclField;
      }
      set
      {
        this.inclField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class FromToAmountRange
  {

    private AmountRangeBoundary1 frAmtField;

    private AmountRangeBoundary1 toAmtField;

    public FromToAmountRange()
    {
      this.toAmtField = new AmountRangeBoundary1();
      this.frAmtField = new AmountRangeBoundary1();
    }

    public AmountRangeBoundary1 FrAmt
    {
      get
      {
        return this.frAmtField;
      }
      set
      {
        this.frAmtField = value;
      }
    }

    public AmountRangeBoundary1 ToAmt
    {
      get
      {
        return this.toAmtField;
      }
      set
      {
        this.toAmtField = value;
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BatchInformation2
  {

    private string msgIdField;

    private string pmtInfIdField;

    private string nbOfTxsField;

    private ActiveOrHistoricCurrencyAndAmount ttlAmtField;

    private System.Nullable<CreditDebitCode> cdtDbtIndField;

    public BatchInformation2()
    {
      this.ttlAmtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public string MsgId
    {
      get
      {
        return this.msgIdField;
      }
      set
      {
        this.msgIdField = value;
      }
    }

    public string PmtInfId
    {
      get
      {
        return this.pmtInfIdField;
      }
      set
      {
        this.pmtInfIdField = value;
      }
    }

    public string NbOfTxs
    {
      get
      {
        return this.nbOfTxsField;
      }
      set
      {
        this.nbOfTxsField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount TtlAmt
    {
      get
      {
        return this.ttlAmtField;
      }
      set
      {
        this.ttlAmtField = value;
      }
    }

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

  public partial class EntryDetails2
  {

    private BatchInformation2 btchField;

    private List<EntryTransaction3> txDtlsField;

    public EntryDetails2()
    {
      this.txDtlsField = new List<EntryTransaction3>();
      this.btchField = new BatchInformation2();
    }

    public BatchInformation2 Btch
    {
      get
      {
        return this.btchField;
      }
      set
      {
        this.btchField = value;
      }
    }

    [XmlElementAttribute("TxDtls")]
    public List<EntryTransaction3> TxDtls
    {
      get
      {
        return this.txDtlsField;
      }
      set
      {
        this.txDtlsField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CardEntry1
  {

    private PaymentCard4 cardField;

    private PointOfInteraction1 pOIField;

    private CardAggregated1 aggtdNtryField;

    public CardEntry1()
    {
      this.aggtdNtryField = new CardAggregated1();
      this.pOIField = new PointOfInteraction1();
      this.cardField = new PaymentCard4();
    }

    public PaymentCard4 Card
    {
      get
      {
        return this.cardField;
      }
      set
      {
        this.cardField = value;
      }
    }

    public PointOfInteraction1 POI
    {
      get
      {
        return this.pOIField;
      }
      set
      {
        this.pOIField = value;
      }
    }

    public CardAggregated1 AggtdNtry
    {
      get
      {
        return this.aggtdNtryField;
      }
      set
      {
        this.aggtdNtryField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class TechnicalInputChannel1Choice
  {

    private string itemField;

    private ItemChoiceType10 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType10 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class MessageIdentification2
  {

    private string msgNmIdField;

    private string msgIdField;

    public string MsgNmId
    {
      get
      {
        return this.msgNmIdField;
      }
      set
      {
        this.msgNmIdField = value;
      }
    }

    public string MsgId
    {
      get
      {
        return this.msgIdField;
      }
      set
      {
        this.msgIdField = value;
      }
    }
  }



  [SerializableAttribute()]

  public enum EntryStatus2Code
  {

    /// <remarks/>
    BOOK,

    /// <remarks/>
    PDNG,

    /// <remarks/>
    INFO,
  }

  
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CreditLine2
  {

    private bool inclField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    public CreditLine2()
    {
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public bool Incl
    {
      get
      {
        return this.inclField;
      }
      set
      {
        this.inclField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
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

  public partial class BalanceSubType1Choice
  {

    private string itemField;

    private ItemChoiceType8 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType8 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }



  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BalanceType5Choice
  {

    private object itemField;

    [XmlElementAttribute("Cd", typeof(BalanceType12Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum BalanceType12Code
  {

    /// <remarks/>
    XPCD,

    /// <remarks/>
    OPAV,

    /// <remarks/>
    ITAV,

    /// <remarks/>
    CLAV,

    /// <remarks/>
    FWAV,

    /// <remarks/>
    CLBD,

    /// <remarks/>
    ITBD,

    /// <remarks/>
    OPBD,

    /// <remarks/>
    PRCD,

    /// <remarks/>
    INFO,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class BalanceType12
  {

    private BalanceType5Choice cdOrPrtryField;

    private BalanceSubType1Choice subTpField;

    public BalanceType12()
    {
      this.subTpField = new BalanceSubType1Choice();
      this.cdOrPrtryField = new BalanceType5Choice();
    }

    public BalanceType5Choice CdOrPrtry
    {
      get
      {
        return this.cdOrPrtryField;
      }
      set
      {
        this.cdOrPrtryField = value;
      }
    }

    public BalanceSubType1Choice SubTp
    {
      get
      {
        return this.subTpField;
      }
      set
      {
        this.subTpField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class CashBalance3
  {

    private BalanceType12 tpField;

    private CreditLine2 cdtLineField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private CreditDebitCode cdtDbtIndField;

    private DateAndDateTimeChoice dtField;

    private List<CashBalanceAvailability2> avlbtyField;

    public CashBalance3()
    {
      this.avlbtyField = new List<CashBalanceAvailability2>();
      this.dtField = new DateAndDateTimeChoice();
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
      this.cdtLineField = new CreditLine2();
      this.tpField = new BalanceType12();
    }

    public BalanceType12 Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public CreditLine2 CdtLine
    {
      get
      {
        return this.cdtLineField;
      }
      set
      {
        this.cdtLineField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    public CreditDebitCode CdtDbtInd
    {
      get
      {
        return this.cdtDbtIndField;
      }
      set
      {
        this.cdtDbtIndField = value;
      }
    }

    public DateAndDateTimeChoice Dt
    {
      get
      {
        return this.dtField;
      }
      set
      {
        this.dtField = value;
      }
    }

    [XmlElementAttribute("Avlbty")]
    public List<CashBalanceAvailability2> Avlbty
    {
      get
      {
        return this.avlbtyField;
      }
      set
      {
        this.avlbtyField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class AccountInterest3
  {

    private InterestType1Choice tpField;

    private List<Rate3> rateField;

    private DateTimePeriodDetails frToDtField;

    private string rsnField;

    private TaxCharges2 taxField;

    public AccountInterest3()
    {
      this.taxField = new TaxCharges2();
      this.frToDtField = new DateTimePeriodDetails();
      this.rateField = new List<Rate3>();
      this.tpField = new InterestType1Choice();
    }

    public InterestType1Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    [XmlElementAttribute("Rate")]
    public List<Rate3> Rate
    {
      get
      {
        return this.rateField;
      }
      set
      {
        this.rateField = value;
      }
    }

    public DateTimePeriodDetails FrToDt
    {
      get
      {
        return this.frToDtField;
      }
      set
      {
        this.frToDtField = value;
      }
    }

    public string Rsn
    {
      get
      {
        return this.rsnField;
      }
      set
      {
        this.rsnField = value;
      }
    }

    public TaxCharges2 Tax
    {
      get
      {
        return this.taxField;
      }
      set
      {
        this.taxField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class ReportingSource1Choice
  {

    private string itemField;

    private ItemChoiceType2 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class Pagination
  {

    private string pgNbField;

    private bool lastPgIndField;

    public string PgNb
    {
      get
      {
        return this.pgNbField;
      }
      set
      {
        this.pgNbField = value;
      }
    }

    public bool LastPgInd
    {
      get
      {
        return this.lastPgIndField;
      }
      set
      {
        this.lastPgIndField = value;
      }
    }
  }


  [SerializableAttribute()]

  public enum CopyDuplicate1Code
  {

    /// <remarks/>
    CODU,

    /// <remarks/>
    COPY,

    /// <remarks/>
    DUPL,
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class OriginalBusinessQuery1
  {

    private string msgIdField;

    private string msgNmIdField;

    private System.Nullable<System.DateTime> creDtTmField;

    public string MsgId
    {
      get
      {
        return this.msgIdField;
      }
      set
      {
        this.msgIdField = value;
      }
    }

    public string MsgNmId
    {
      get
      {
        return this.msgNmIdField;
      }
      set
      {
        this.msgNmIdField = value;
      }
    }

    public System.DateTime CreDtTm
    {
      get
      {
        if (this.creDtTmField.HasValue)
        {
          return this.creDtTmField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.creDtTmField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool CreDtTmSpecified
    {
      get
      {
        return this.creDtTmField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.creDtTmField = null;
        }
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class PersonIdentificationSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType1 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }





  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class GenericPersonIdentification1
  {

    private string idField;

    private PersonIdentificationSchemeName1Choice schmeNmField;

    private string issrField;

    public GenericPersonIdentification1()
    {
      this.schmeNmField = new PersonIdentificationSchemeName1Choice();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public PersonIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class DateAndPlaceOfBirth
  {

    private System.DateTime birthDtField;

    private string prvcOfBirthField;

    private string cityOfBirthField;

    private string ctryOfBirthField;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime BirthDt
    {
      get
      {
        return this.birthDtField;
      }
      set
      {
        this.birthDtField = value;
      }
    }

    public string PrvcOfBirth
    {
      get
      {
        return this.prvcOfBirthField;
      }
      set
      {
        this.prvcOfBirthField = value;
      }
    }

    public string CityOfBirth
    {
      get
      {
        return this.cityOfBirthField;
      }
      set
      {
        this.cityOfBirthField = value;
      }
    }

    public string CtryOfBirth
    {
      get
      {
        return this.ctryOfBirthField;
      }
      set
      {
        this.ctryOfBirthField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class PersonIdentification5
  {

    private DateAndPlaceOfBirth dtAndPlcOfBirthField;

    private List<GenericPersonIdentification1> othrField;

    public PersonIdentification5()
    {
      this.othrField = new List<GenericPersonIdentification1>();
      this.dtAndPlcOfBirthField = new DateAndPlaceOfBirth();
    }

    public DateAndPlaceOfBirth DtAndPlcOfBirth
    {
      get
      {
        return this.dtAndPlcOfBirthField;
      }
      set
      {
        this.dtAndPlcOfBirthField = value;
      }
    }

    [XmlElementAttribute("Othr")]
    public List<GenericPersonIdentification1> Othr
    {
      get
      {
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

  public partial class OrganisationIdentificationSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class GenericOrganisationIdentification1
  {

    private string idField;

    private OrganisationIdentificationSchemeName1Choice schmeNmField;

    private string issrField;

    public GenericOrganisationIdentification1()
    {
      this.schmeNmField = new OrganisationIdentificationSchemeName1Choice();
    }

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public OrganisationIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class OrganisationIdentification8
  {

    private string anyBICField;

    private List<GenericOrganisationIdentification1> othrField;

    public OrganisationIdentification8()
    {
      this.othrField = new List<GenericOrganisationIdentification1>();
    }

    public string AnyBIC
    {
      get
      {
        return this.anyBICField;
      }
      set
      {
        this.anyBICField = value;
      }
    }

    [XmlElementAttribute("Othr")]
    public List<GenericOrganisationIdentification1> Othr
    {
      get
      {
        return this.othrField;
      }
      set
      {
        this.othrField = value;
      }
    }
  }


}
