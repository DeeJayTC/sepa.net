// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.AccountReport12.cs
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
  public class AccountReport12
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private CashAccount25 _acctField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _addtlRptInfField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<CashBalance3> _balField;
    [EditorBrowsable(EditorBrowsableState.Never)] private CopyDuplicate1Code? _cpyDplctIndField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime _creDtTmField;
    [EditorBrowsable(EditorBrowsableState.Never)] private decimal? _elctrncSeqNbField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTimePeriodDetails _frToDtField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _idField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<AccountInterest3> _intrstField;
    [EditorBrowsable(EditorBrowsableState.Never)] private decimal? _lglSeqNbField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<ReportEntry3> _ntryField;
    [EditorBrowsable(EditorBrowsableState.Never)] private CashAccount24 _rltdAcctField;
    [EditorBrowsable(EditorBrowsableState.Never)] private Pagination _rptPgntnField;
    [EditorBrowsable(EditorBrowsableState.Never)] private ReportingSource1Choice _rptgSrcField;
    [EditorBrowsable(EditorBrowsableState.Never)] private TotalTransactions3 _txsSummryField;

    public AccountReport12()
    {
      _ntryField = new List<ReportEntry3>();
      _txsSummryField = new TotalTransactions3();
      _balField = new List<CashBalance3>();
      _intrstField = new List<AccountInterest3>();
      _rltdAcctField = new CashAccount24();
      _acctField = new CashAccount25();
      _rptgSrcField = new ReportingSource1Choice();
      _frToDtField = new DateTimePeriodDetails();
      _rptPgntnField = new Pagination();
    }

    public string Id
    {
      get { return _idField; }
      set { _idField = value; }
    }

    public Pagination RptPgntn
    {
      get { return _rptPgntnField; }
      set { _rptPgntnField = value; }
    }

    public decimal ElctrncSeqNb
    {
      get
      {
        if (_elctrncSeqNbField.HasValue)
        {
          return _elctrncSeqNbField.Value;
        }
        return default(decimal);
      }
      set { _elctrncSeqNbField = value; }
    }

    [XmlIgnore]
    public bool ElctrncSeqNbSpecified
    {
      get { return _elctrncSeqNbField.HasValue; }
      set
      {
        if (value == false)
        {
          _elctrncSeqNbField = null;
        }
      }
    }

    public decimal LglSeqNb
    {
      get
      {
        if (_lglSeqNbField.HasValue)
        {
          return _lglSeqNbField.Value;
        }
        return default(decimal);
      }
      set { _lglSeqNbField = value; }
    }

    [XmlIgnore]
    public bool LglSeqNbSpecified
    {
      get { return _lglSeqNbField.HasValue; }
      set
      {
        if (value == false)
        {
          _lglSeqNbField = null;
        }
      }
    }

    [XmlElement("CreDtTm")]
    public DateTime CreditedDateTime
    {
      get { return _creDtTmField; }
      set { _creDtTmField = value; }
    }

    public DateTimePeriodDetails FrToDt
    {
      get { return _frToDtField; }
      set { _frToDtField = value; }
    }

    public CopyDuplicate1Code CpyDplctInd
    {
      get
      {
        if (_cpyDplctIndField.HasValue)
        {
          return _cpyDplctIndField.Value;
        }
        return default(CopyDuplicate1Code);
      }
      set { _cpyDplctIndField = value; }
    }

    [XmlIgnore]
    public bool CpyDplctIndSpecified
    {
      get { return _cpyDplctIndField.HasValue; }
      set
      {
        if (value == false)
        {
          _cpyDplctIndField = null;
        }
      }
    }

    public ReportingSource1Choice RptgSrc
    {
      get { return _rptgSrcField; }
      set { _rptgSrcField = value; }
    }

    [XmlElement("Acct")]
    public CashAccount25 Account
    {
      get { return _acctField; }
      set { _acctField = value; }
    }

    public CashAccount24 RltdAcct
    {
      get { return _rltdAcctField; }
      set { _rltdAcctField = value; }
    }

    [XmlElement("Intrst")]
    public List<AccountInterest3> Interests
    {
      get { return _intrstField; }
      set { _intrstField = value; }
    }

    [XmlElement("Bal")]
    public List<CashBalance3> Balance
    {
      get { return _balField; }
      set { _balField = value; }
    }

    [XmlElement("TxsSummry")]
    public TotalTransactions3 TotalTransactionSummery
    {
      get { return _txsSummryField; }
      set { _txsSummryField = value; }
    }

    [XmlElement("Ntry")]
    public List<ReportEntry3> Entries
    {
      get { return _ntryField; }
      set { _ntryField = value; }
    }

    public string AddtlRptInf
    {
      get { return _addtlRptInfField; }
      set { _addtlRptInfField = value; }
    }
  }
}