// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CardAggregated1.cs
// Author: Tim Cadenbach, TCDev    
// Created: 08.09.2013 -  TCA
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
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic.Card
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class CardAggregated1
  {

    private System.Nullable<CardPaymentServiceType2Code> addtlSvcField;

    private string txCtgyField;

    private string saleRcncltnIdField;

    private CardSequenceNumberRange1 seqNbRgField;

    private DateOrDateTimePeriodChoice txDtRgField;

    public CardAggregated1()
    {
      this.txDtRgField = new DateOrDateTimePeriodChoice();
      this.seqNbRgField = new CardSequenceNumberRange1();
    }

    public CardPaymentServiceType2Code AddtlSvc
    {
      get
      {
        if (this.addtlSvcField.HasValue)
        {
          return this.addtlSvcField.Value;
        }
        else
        {
          return default(CardPaymentServiceType2Code);
        }
      }
      set
      {
        this.addtlSvcField = value;
      }
    }

    [XmlIgnore()]
    public bool AddtlSvcSpecified
    {
      get
      {
        return this.addtlSvcField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.addtlSvcField = null;
        }
      }
    }

    public string TxCtgy
    {
      get
      {
        return this.txCtgyField;
      }
      set
      {
        this.txCtgyField = value;
      }
    }

    public string SaleRcncltnId
    {
      get
      {
        return this.saleRcncltnIdField;
      }
      set
      {
        this.saleRcncltnIdField = value;
      }
    }

    public CardSequenceNumberRange1 SeqNbRg
    {
      get
      {
        return this.seqNbRgField;
      }
      set
      {
        this.seqNbRgField = value;
      }
    }

    public DateOrDateTimePeriodChoice TxDtRg
    {
      get
      {
        return this.txDtRgField;
      }
      set
      {
        this.txDtRgField = value;
      }
    }
  }
}