
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;
using TCDev.SEPA.Generic.Identification;

namespace TCDev.SEPA.CAMT.Transaction
{

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class TotalsPerBankTransactionCode2
  {

    private string _nbOfNtriesField;

    private decimal? _sumField;

    private decimal? _ttlNetNtryAmtField;

    private CreditDebitCode? _cdtDbtIndField;

    private bool? _fcstIndField;

    private BankTransactionCodeStructure4 bkTxCdField;

    private List<CashBalanceAvailability2> avlbtyField;

    public TotalsPerBankTransactionCode2()
    {
      this.avlbtyField = new List<CashBalanceAvailability2>();
      this.bkTxCdField = new BankTransactionCodeStructure4();
    }

    public string NbOfNtries
    {
      get
      {
        return this._nbOfNtriesField;
      }
      set
      {
        this._nbOfNtriesField = value;
      }
    }

    public decimal Sum
    {
      get
      {
        if (this._sumField.HasValue)
        {
          return this._sumField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this._sumField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool SumSpecified
    {
      get
      {
        return this._sumField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._sumField = null;
        }
      }
    }

    public decimal TtlNetNtryAmt
    {
      get
      {
        if (this._ttlNetNtryAmtField.HasValue)
        {
          return this._ttlNetNtryAmtField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this._ttlNetNtryAmtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool TtlNetNtryAmtSpecified
    {
      get
      {
        return this._ttlNetNtryAmtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._ttlNetNtryAmtField = null;
        }
      }
    }

    public CreditDebitCode CdtDbtInd
    {
      get
      {
        if (this._cdtDbtIndField.HasValue)
        {
          return this._cdtDbtIndField.Value;
        }
        else
        {
          return default(CreditDebitCode);
        }
      }
      set
      {
        this._cdtDbtIndField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool CdtDbtIndSpecified
    {
      get
      {
        return this._cdtDbtIndField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._cdtDbtIndField = null;
        }
      }
    }

    public bool FcstInd
    {
      get
      {
        if (this._fcstIndField.HasValue)
        {
          return this._fcstIndField.Value;
        }
        else
        {
          return default(bool);
        }
      }
      set
      {
        this._fcstIndField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool FcstIndSpecified
    {
      get
      {
        return this._fcstIndField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._fcstIndField = null;
        }
      }
    }

    public BankTransactionCodeStructure4 BkTxCd
    {
      get
      {
        return this.bkTxCdField;
      }
      set
      {
        this.bkTxCdField = value;
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

  public partial class NumberAndSumOfTransactions1
  {

    private string nbOfNtriesField;

    private System.Nullable<decimal> sumField;

    public string NbOfNtries
    {
      get
      {
        return this.nbOfNtriesField;
      }
      set
      {
        this.nbOfNtriesField = value;
      }
    }

    public decimal Sum
    {
      get
      {
        if (this.sumField.HasValue)
        {
          return this.sumField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.sumField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool SumSpecified
    {
      get
      {
        return this.sumField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.sumField = null;
        }
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class NumberAndSumOfTransactions3
  {

    private string nbOfNtriesField;

    private System.Nullable<decimal> sumField;

    private System.Nullable<decimal> ttlNetNtryAmtField;

    private System.Nullable<CreditDebitCode> cdtDbtIndField;

    public string NbOfNtries
    {
      get
      {
        return this.nbOfNtriesField;
      }
      set
      {
        this.nbOfNtriesField = value;
      }
    }

    public decimal Sum
    {
      get
      {
        if (this.sumField.HasValue)
        {
          return this.sumField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.sumField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool SumSpecified
    {
      get
      {
        return this.sumField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.sumField = null;
        }
      }
    }

    public decimal TtlNetNtryAmt
    {
      get
      {
        if (this.ttlNetNtryAmtField.HasValue)
        {
          return this.ttlNetNtryAmtField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.ttlNetNtryAmtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool TtlNetNtryAmtSpecified
    {
      get
      {
        return this.ttlNetNtryAmtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.ttlNetNtryAmtField = null;
        }
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

  public partial class TotalTransactions3
  {

    private NumberAndSumOfTransactions3 ttlNtriesField;

    private NumberAndSumOfTransactions1 ttlCdtNtriesField;

    private NumberAndSumOfTransactions1 ttlDbtNtriesField;

    private List<TotalsPerBankTransactionCode2> ttlNtriesPerBkTxCdField;

    public TotalTransactions3()
    {
      this.ttlNtriesPerBkTxCdField = new List<TotalsPerBankTransactionCode2>();
      this.ttlDbtNtriesField = new NumberAndSumOfTransactions1();
      this.ttlCdtNtriesField = new NumberAndSumOfTransactions1();
      this.ttlNtriesField = new NumberAndSumOfTransactions3();
    }

    public NumberAndSumOfTransactions3 TtlNtries
    {
      get
      {
        return this.ttlNtriesField;
      }
      set
      {
        this.ttlNtriesField = value;
      }
    }

    public NumberAndSumOfTransactions1 TtlCdtNtries
    {
      get
      {
        return this.ttlCdtNtriesField;
      }
      set
      {
        this.ttlCdtNtriesField = value;
      }
    }

    public NumberAndSumOfTransactions1 TtlDbtNtries
    {
      get
      {
        return this.ttlDbtNtriesField;
      }
      set
      {
        this.ttlDbtNtriesField = value;
      }
    }

    [XmlElementAttribute("TtlNtriesPerBkTxCd")]
    public List<TotalsPerBankTransactionCode2> TtlNtriesPerBkTxCd
    {
      get
      {
        return this.ttlNtriesPerBkTxCdField;
      }
      set
      {
        this.ttlNtriesPerBkTxCdField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]

  public partial class TransactionDates2
  {

    private DateTime? accptncDtTmField;

    private DateTime? tradActvtyCtrctlSttlmDtField;

    private DateTime? tradDtField;

    private DateTime? intrBkSttlmDtField;

    private DateTime? startDtField;

    private DateTime? endDtField;

    private DateTime? txDtTmField;

    private List<ProprietaryDate2> prtryField;

    public TransactionDates2()
    {
      this.prtryField = new List<ProprietaryDate2>();
    }

    public System.DateTime AccptncDtTm
    {
      get
      {
        if (this.accptncDtTmField.HasValue)
        {
          return this.accptncDtTmField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.accptncDtTmField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool AccptncDtTmSpecified
    {
      get
      {
        return this.accptncDtTmField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.accptncDtTmField = null;
        }
      }
    }

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime TradActvtyCtrctlSttlmDt
    {
      get
      {
        if (this.tradActvtyCtrctlSttlmDtField.HasValue)
        {
          return this.tradActvtyCtrctlSttlmDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.tradActvtyCtrctlSttlmDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool TradActvtyCtrctlSttlmDtSpecified
    {
      get
      {
        return this.tradActvtyCtrctlSttlmDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.tradActvtyCtrctlSttlmDtField = null;
        }
      }
    }

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime TradDt
    {
      get
      {
        if (this.tradDtField.HasValue)
        {
          return this.tradDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.tradDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool TradDtSpecified
    {
      get
      {
        return this.tradDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.tradDtField = null;
        }
      }
    }

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime IntrBkSttlmDt
    {
      get
      {
        if (this.intrBkSttlmDtField.HasValue)
        {
          return this.intrBkSttlmDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.intrBkSttlmDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool IntrBkSttlmDtSpecified
    {
      get
      {
        return this.intrBkSttlmDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.intrBkSttlmDtField = null;
        }
      }
    }

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime StartDt
    {
      get
      {
        if (this.startDtField.HasValue)
        {
          return this.startDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.startDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool StartDtSpecified
    {
      get
      {
        return this.startDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.startDtField = null;
        }
      }
    }

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime EndDt
    {
      get
      {
        if (this.endDtField.HasValue)
        {
          return this.endDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.endDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool EndDtSpecified
    {
      get
      {
        return this.endDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.endDtField = null;
        }
      }
    }

    public System.DateTime TxDtTm
    {
      get
      {
        if (this.txDtTmField.HasValue)
        {
          return this.txDtTmField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.txDtTmField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool TxDtTmSpecified
    {
      get
      {
        return this.txDtTmField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.txDtTmField = null;
        }
      }
    }

    [XmlElementAttribute("Prtry")]
    public List<ProprietaryDate2> Prtry
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

  public partial class TransactionAgents3
  {

    private BranchAndFinancialInstitutionIdentification5 dbtrAgtField;

    private BranchAndFinancialInstitutionIdentification5 cdtrAgtField;

    private BranchAndFinancialInstitutionIdentification5 intrmyAgt1Field;

    private BranchAndFinancialInstitutionIdentification5 intrmyAgt2Field;

    private BranchAndFinancialInstitutionIdentification5 intrmyAgt3Field;

    private BranchAndFinancialInstitutionIdentification5 rcvgAgtField;

    private BranchAndFinancialInstitutionIdentification5 dlvrgAgtField;

    private BranchAndFinancialInstitutionIdentification5 issgAgtField;

    private BranchAndFinancialInstitutionIdentification5 sttlmPlcField;

    private List<ProprietaryAgent3> prtryField;

    public TransactionAgents3()
    {
      this.prtryField = new List<ProprietaryAgent3>();
      this.sttlmPlcField = new BranchAndFinancialInstitutionIdentification5();
      this.issgAgtField = new BranchAndFinancialInstitutionIdentification5();
      this.dlvrgAgtField = new BranchAndFinancialInstitutionIdentification5();
      this.rcvgAgtField = new BranchAndFinancialInstitutionIdentification5();
      this.intrmyAgt3Field = new BranchAndFinancialInstitutionIdentification5();
      this.intrmyAgt2Field = new BranchAndFinancialInstitutionIdentification5();
      this.intrmyAgt1Field = new BranchAndFinancialInstitutionIdentification5();
      this.cdtrAgtField = new BranchAndFinancialInstitutionIdentification5();
      this.dbtrAgtField = new BranchAndFinancialInstitutionIdentification5();
    }

    public BranchAndFinancialInstitutionIdentification5 DbtrAgt
    {
      get
      {
        return this.dbtrAgtField;
      }
      set
      {
        this.dbtrAgtField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 CdtrAgt
    {
      get
      {
        return this.cdtrAgtField;
      }
      set
      {
        this.cdtrAgtField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 IntrmyAgt1
    {
      get
      {
        return this.intrmyAgt1Field;
      }
      set
      {
        this.intrmyAgt1Field = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 IntrmyAgt2
    {
      get
      {
        return this.intrmyAgt2Field;
      }
      set
      {
        this.intrmyAgt2Field = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 IntrmyAgt3
    {
      get
      {
        return this.intrmyAgt3Field;
      }
      set
      {
        this.intrmyAgt3Field = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 RcvgAgt
    {
      get
      {
        return this.rcvgAgtField;
      }
      set
      {
        this.rcvgAgtField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 DlvrgAgt
    {
      get
      {
        return this.dlvrgAgtField;
      }
      set
      {
        this.dlvrgAgtField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 IssgAgt
    {
      get
      {
        return this.issgAgtField;
      }
      set
      {
        this.issgAgtField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 SttlmPlc
    {
      get
      {
        return this.sttlmPlcField;
      }
      set
      {
        this.sttlmPlcField = value;
      }
    }

    [XmlElementAttribute("Prtry")]
    public List<ProprietaryAgent3> Prtry
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

  [Serializable()]
  [DesignerCategory("code")]

  public partial class TransactionParties3
  {

    private PartyIdentification43 initgPtyField;

    private PartyIdentification43 dbtrField;

    private CashAccount24 dbtrAcctField;

    private PartyIdentification43 ultmtDbtrField;

    private PartyIdentification43 cdtrField;

    private CashAccount24 cdtrAcctField;

    private PartyIdentification43 ultmtCdtrField;

    private PartyIdentification43 tradgPtyField;

    private List<ProprietaryParty3> prtryField;

    public TransactionParties3()
    {
      this.prtryField = new List<ProprietaryParty3>();
      this.tradgPtyField = new PartyIdentification43();
      this.ultmtCdtrField = new PartyIdentification43();
      this.cdtrAcctField = new CashAccount24();
      this.cdtrField = new PartyIdentification43();
      this.ultmtDbtrField = new PartyIdentification43();
      this.dbtrAcctField = new CashAccount24();
      this.dbtrField = new PartyIdentification43();
      this.initgPtyField = new PartyIdentification43();
    }

    public PartyIdentification43 InitgPty
    {
      get
      {
        return this.initgPtyField;
      }
      set
      {
        this.initgPtyField = value;
      }
    }

    public PartyIdentification43 Dbtr
    {
      get
      {
        return this.dbtrField;
      }
      set
      {
        this.dbtrField = value;
      }
    }

    public CashAccount24 DbtrAcct
    {
      get
      {
        return this.dbtrAcctField;
      }
      set
      {
        this.dbtrAcctField = value;
      }
    }

    public PartyIdentification43 UltmtDbtr
    {
      get
      {
        return this.ultmtDbtrField;
      }
      set
      {
        this.ultmtDbtrField = value;
      }
    }

    public PartyIdentification43 Cdtr
    {
      get
      {
        return this.cdtrField;
      }
      set
      {
        this.cdtrField = value;
      }
    }

    public CashAccount24 CdtrAcct
    {
      get
      {
        return this.cdtrAcctField;
      }
      set
      {
        this.cdtrAcctField = value;
      }
    }

    public PartyIdentification43 UltmtCdtr
    {
      get
      {
        return this.ultmtCdtrField;
      }
      set
      {
        this.ultmtCdtrField = value;
      }
    }

    public PartyIdentification43 TradgPty
    {
      get
      {
        return this.tradgPtyField;
      }
      set
      {
        this.tradgPtyField = value;
      }
    }

    [XmlElement("Prtry")]
    public List<ProprietaryParty3> Prtry
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

  public partial class TransactionReferences3
  {

    private string msgIdField;

    private string acctSvcrRefField;

    private string pmtInfIdField;

    private string instrIdField;

    private string endToEndIdField;

    private string txIdField;

    private string mndtIdField;

    private string chqNbField;

    private string clrSysRefField;

    private string acctOwnrTxIdField;

    private string acctSvcrTxIdField;

    private string mktInfrstrctrTxIdField;

    private string prcgIdField;

    private List<ProprietaryReference1> prtryField;

    public TransactionReferences3()
    {
      this.prtryField = new List<ProprietaryReference1>();
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

    public string AcctSvcrRef
    {
      get
      {
        return this.acctSvcrRefField;
      }
      set
      {
        this.acctSvcrRefField = value;
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

    public string InstrId
    {
      get
      {
        return this.instrIdField;
      }
      set
      {
        this.instrIdField = value;
      }
    }

    public string EndToEndId
    {
      get
      {
        return this.endToEndIdField;
      }
      set
      {
        this.endToEndIdField = value;
      }
    }

    public string TxId
    {
      get
      {
        return this.txIdField;
      }
      set
      {
        this.txIdField = value;
      }
    }

    public string MndtId
    {
      get
      {
        return this.mndtIdField;
      }
      set
      {
        this.mndtIdField = value;
      }
    }

    public string ChqNb
    {
      get
      {
        return this.chqNbField;
      }
      set
      {
        this.chqNbField = value;
      }
    }

    public string ClrSysRef
    {
      get
      {
        return this.clrSysRefField;
      }
      set
      {
        this.clrSysRefField = value;
      }
    }

    public string AcctOwnrTxId
    {
      get
      {
        return this.acctOwnrTxIdField;
      }
      set
      {
        this.acctOwnrTxIdField = value;
      }
    }

    public string AcctSvcrTxId
    {
      get
      {
        return this.acctSvcrTxIdField;
      }
      set
      {
        this.acctSvcrTxIdField = value;
      }
    }

    public string MktInfrstrctrTxId
    {
      get
      {
        return this.mktInfrstrctrTxIdField;
      }
      set
      {
        this.mktInfrstrctrTxIdField = value;
      }
    }

    public string PrcgId
    {
      get
      {
        return this.prcgIdField;
      }
      set
      {
        this.prcgIdField = value;
      }
    }

    [XmlElementAttribute("Prtry")]
    public List<ProprietaryReference1> Prtry
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

  public partial class TransactionInterest3
  {

    private ActiveOrHistoricCurrencyAndAmount ttlIntrstAndTaxAmtField;

    private List<InterestRecord1> rcrdField;

    public TransactionInterest3()
    {
      this.rcrdField = new List<InterestRecord1>();
      this.ttlIntrstAndTaxAmtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount TtlIntrstAndTaxAmt
    {
      get
      {
        return this.ttlIntrstAndTaxAmtField;
      }
      set
      {
        this.ttlIntrstAndTaxAmtField = value;
      }
    }

    [XmlElementAttribute("Rcrd")]
    public List<InterestRecord1> Rcrd
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


}
