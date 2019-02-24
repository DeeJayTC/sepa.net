// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.TaxInformation3.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(TypeName = "TaxInformation3")]
  [XmlRoot("TaxInformation3")]
  public class TaxInformation3
  {
    private TaxParty1 _cdtrField;

    private TaxParty2 _dbtrField;

    private List<TaxRecord1> _rcrdField;
    private ActiveOrHistoricCurrencyAndAmount _ttlTaxAmtField;
    private ActiveOrHistoricCurrencyAndAmount _ttlTaxblBaseAmtField;

    [XmlElement(Order = 2, ElementName = "AdmstnZn")]
    public string AdmstnZn { get; set; }

    [XmlElement(Order = 3, ElementName = "RefNb")]
    public string RefNb { get; set; }

    [XmlElement(Order = 4, ElementName = "Mtd")]
    public string Mtd { get; set; }

    [XmlElement(DataType = "date", Order = 7, ElementName = "Dt")]
    public DateTime Dt { get; set; }

    [XmlIgnore]
    [XmlElement("DtSpecified")]
    public bool DtSpecified { get; set; }

    [XmlElement(Order = 8, ElementName = "SeqNb")]
    public decimal SeqNb { get; set; }

    [XmlIgnore]
    [XmlElement("SeqNbSpecified")]
    public bool SeqNbSpecified { get; set; }

    [XmlElement(Order = 0, ElementName = "Cdtr")]
    public TaxParty1 Creditor
    {
      get
      {
        if ((_cdtrField == null))
        {
          _cdtrField = new TaxParty1();
        }
        return _cdtrField;
      }
      set { _cdtrField = value; }
    }

    [XmlElement(Order = 1, ElementName = "Dbtr")]
    public TaxParty2 Debitor
    {
      get
      {
        if ((_dbtrField == null))
        {
          _dbtrField = new TaxParty2();
        }
        return _dbtrField;
      }
      set { _dbtrField = value; }
    }

    [XmlElement(Order = 5, ElementName = "TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount TaxBaseAmount
    {
      get
      {
        if ((_ttlTaxblBaseAmtField == null))
        {
          _ttlTaxblBaseAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return _ttlTaxblBaseAmtField;
      }
      set { _ttlTaxblBaseAmtField = value; }
    }

    [XmlElement(Order = 6, ElementName = "TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount TaxTransferAmount
    {
      get
      {
        if ((_ttlTaxAmtField == null))
        {
          _ttlTaxAmtField = new ActiveOrHistoricCurrencyAndAmount();
        }
        return _ttlTaxAmtField;
      }
      set { _ttlTaxAmtField = value; }
    }

    [XmlElement("Rcrd", Order = 9, ElementName = "Rcrd")]
    public List<TaxRecord1> TaxRecord
    {
      get
      {
        if ((_rcrdField == null))
        {
          _rcrdField = new List<TaxRecord1>();
        }
        return _rcrdField;
      }
      set { _rcrdField = value; }
    }
  }
}