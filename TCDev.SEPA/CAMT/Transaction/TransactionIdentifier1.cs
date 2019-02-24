// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.TransactionIdentifier1.cs
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

namespace TCDev.SEPA.CAMT.Transaction
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class TransactionIdentifier1
  {

    private DateTime _txDtTmField;

    private string _txRefField;

    [XmlElement("TxDtTm")]
    public DateTime TxDatetime
    {
      get
      {
        return this._txDtTmField;
      }
      set
      {
        this._txDtTmField = value;
      }
    }

    [XmlElement("TxRef")]
    public string TXReference
    {
      get
      {
        return this._txRefField;
      }
      set
      {
        this._txRefField = value;
      }
    }
  }
}