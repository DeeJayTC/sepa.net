// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.ReportEntry3.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.CAMT.Transaction;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic
{

  [Serializable]
  [DesignerCategory("code")]
  public class ReportEntry3
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private string _acctSvcrRefField;
    [EditorBrowsable(EditorBrowsableState.Never)] private MessageIdentification2 _addtlInfIndField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _addtlNtryInfField;

    [EditorBrowsable(EditorBrowsableState.Never)] private AmountAndCurrencyExchange3 _amtDtlsField;
    [EditorBrowsable(EditorBrowsableState.Never)] private ActiveOrHistoricCurrencyAndAmount _amtField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<CashBalanceAvailability2> _avlbtyField;

    [EditorBrowsable(EditorBrowsableState.Never)] private BankTransactionCodeStructure4 _bkTxCdField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateAndDateTimeChoice _bookgDtField;
    [EditorBrowsable(EditorBrowsableState.Never)] private CardEntry1 _cardTxField;
    [EditorBrowsable(EditorBrowsableState.Never)] private CreditDebitCode _cdtDbtIndField;

    [EditorBrowsable(EditorBrowsableState.Never)] private List<Charges3> _chrgsField;
    [EditorBrowsable(EditorBrowsableState.Never)] private bool? _comssnWvrIndField;

    [EditorBrowsable(EditorBrowsableState.Never)] private List<TransactionInterest3> _intrstField;

    [EditorBrowsable(EditorBrowsableState.Never)] private List<EntryDetails2> _ntryDtlsField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _ntryRefField;
    [EditorBrowsable(EditorBrowsableState.Never)] private bool? _rvslIndField;

    [EditorBrowsable(EditorBrowsableState.Never)] private EntryStatus2Code _stsField;

    [EditorBrowsable(EditorBrowsableState.Never)] private TechnicalInputChannel1Choice _techInptChanlField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateAndDateTimeChoice _valDtField;

    public ReportEntry3()
    {
      _ntryDtlsField = new List<EntryDetails2>();
      _cardTxField = new CardEntry1();
      _intrstField = new List<TransactionInterest3>();
      _techInptChanlField = new TechnicalInputChannel1Choice();
      _chrgsField = new List<Charges3>();
      _amtDtlsField = new AmountAndCurrencyExchange3();
      _addtlInfIndField = new MessageIdentification2();
      _bkTxCdField = new BankTransactionCodeStructure4();
      _avlbtyField = new List<CashBalanceAvailability2>();
      _valDtField = new DateAndDateTimeChoice();
      _bookgDtField = new DateAndDateTimeChoice();
      _amtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    [XmlElement("NtryRef")]
    public string Entryreference
    {
      get { return _ntryRefField; }
      set { _ntryRefField = value; }
    }

        [XmlElement("NtryRef")]
    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get { return _amtField; }
      set { _amtField = value; }
    }

        [XmlElement("NtryRef")]
    public CreditDebitCode CdtDbtInd
    {
      get { return _cdtDbtIndField; }
      set { _cdtDbtIndField = value; }
    }

    public bool RvslInd
    {
      get
      {
        if (_rvslIndField.HasValue)
        {
          return _rvslIndField.Value;
        }
        return default(bool);
      }
      set { _rvslIndField = value; }
    }

    [XmlIgnore]
    public bool RvslIndSpecified
    {
      get { return _rvslIndField.HasValue; }
      set
      {
        if (value == false)
        {
          _rvslIndField = null;
        }
      }
    }
        [XmlElement("Sts")]
    public EntryStatus2Code Status
    {
      get { return _stsField; }
      set { _stsField = value; }
    }
        [XmlElement("BookgDt")]
    public DateAndDateTimeChoice BookedDate
    {
      get { return _bookgDtField; }
      set { _bookgDtField = value; }
    }
        [XmlElement("NtryRef")]
    public DateAndDateTimeChoice ValueDate
    {
      get { return _valDtField; }
      set { _valDtField = value; }
    }

    public string AcctSvcrRef
    {
      get { return _acctSvcrRefField; }
      set { _acctSvcrRefField = value; }
    }

    [XmlElement("Avlbty")]
    public List<CashBalanceAvailability2> Availability
    {
      get { return _avlbtyField; }
      set { _avlbtyField = value; }
    }
        [XmlElement("BkTxCd")]
    public BankTransactionCodeStructure4 BankTransactionCode
    {
      get { return _bkTxCdField; }
      set { _bkTxCdField = value; }
    }

    public bool ComssnWvrInd
    {
      get
      {
        if (_comssnWvrIndField.HasValue)
        {
          return _comssnWvrIndField.Value;
        }
        return default(bool);
      }
      set { _comssnWvrIndField = value; }
    }

    [XmlIgnore]
    public bool ComssnWvrIndSpecified
    {
      get { return _comssnWvrIndField.HasValue; }
      set
      {
        if (value == false)
        {
          _comssnWvrIndField = null;
        }
      }
    }

    public MessageIdentification2 AddtlInfInd
    {
      get { return _addtlInfIndField; }
      set { _addtlInfIndField = value; }
    }

    public AmountAndCurrencyExchange3 AmtDtls
    {
      get { return _amtDtlsField; }
      set { _amtDtlsField = value; }
    }

    [XmlElement("Chrgs")]
    public List<Charges3> Charges
    {
      get { return _chrgsField; }
      set { _chrgsField = value; }
    }

    public TechnicalInputChannel1Choice TechInptChanl
    {
      get { return _techInptChanlField; }
      set { _techInptChanlField = value; }
    }

    [XmlElement("Intrst")]
    public List<TransactionInterest3> Intrst
    {
      get { return _intrstField; }
      set { _intrstField = value; }
    }

    public CardEntry1 CardTx
    {
      get { return _cardTxField; }
      set { _cardTxField = value; }
    }

    [XmlElement("NtryDtls")]
    public List<EntryDetails2> EntryDetails
    {
      get { return _ntryDtlsField; }
      set { _ntryDtlsField = value; }
    }

    public string AddtlNtryInf
    {
      get { return _addtlNtryInfField; }
      set { _addtlNtryInfField = value; }
    }
  }
}