// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CardIndividualTransaction1.cs
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
using TCDev.SEPA.CAMT.Transaction;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic.Card
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class CardIndividualTransaction1
  {

    private CardPaymentServiceType2Code? addtlSvcField;

    private string txCtgyField;

    private string saleRcncltnIdField;

    private string saleRefNbField;

    private string seqNbField;

    private TransactionIdentifier1 txIdField;

    private Product2 pdctField;

    private System.Nullable<System.DateTime> vldtnDtField;

    private string vldtnSeqNbField;

    public CardIndividualTransaction1()
    {
      this.pdctField = new Product2();
      this.txIdField = new TransactionIdentifier1();
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

    public string SaleRefNb
    {
      get
      {
        return this.saleRefNbField;
      }
      set
      {
        this.saleRefNbField = value;
      }
    }

    public string SeqNb
    {
      get
      {
        return this.seqNbField;
      }
      set
      {
        this.seqNbField = value;
      }
    }

    public TransactionIdentifier1 TxId
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

    public Product2 Pdct
    {
      get
      {
        return this.pdctField;
      }
      set
      {
        this.pdctField = value;
      }
    }

    [XmlElement(DataType = "date")]
    public System.DateTime VldtnDt
    {
      get
      {
        if (this.vldtnDtField.HasValue)
        {
          return this.vldtnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.vldtnDtField = value;
      }
    }

    [XmlIgnore()]
    public bool VldtnDtSpecified
    {
      get
      {
        return this.vldtnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.vldtnDtField = null;
        }
      }
    }

    public string VldtnSeqNb
    {
      get
      {
        return this.vldtnSeqNbField;
      }
      set
      {
        this.vldtnSeqNbField = value;
      }
    }
  }
}