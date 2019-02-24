// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PaymentCard4.cs
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
using TCDev.SEPA.CAMT.Generic.Card;
using TCDev.SEPA.Generic.Identification;

namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class PaymentCard4
  {

    private PlainCardData1 plainCardDataField;

    private string cardCtryCdField;

    private GenericIdentification1 cardBrndField;

    private string addtlCardDataField;

    public PaymentCard4()
    {
      this.cardBrndField = new GenericIdentification1();
      this.plainCardDataField = new PlainCardData1();
    }

    public PlainCardData1 PlainCardData
    {
      get
      {
        return this.plainCardDataField;
      }
      set
      {
        this.plainCardDataField = value;
      }
    }

    public string CardCtryCd
    {
      get
      {
        return this.cardCtryCdField;
      }
      set
      {
        this.cardCtryCdField = value;
      }
    }

    public GenericIdentification1 CardBrnd
    {
      get
      {
        return this.cardBrndField;
      }
      set
      {
        this.cardBrndField = value;
      }
    }

    public string AddtlCardData
    {
      get
      {
        return this.addtlCardDataField;
      }
      set
      {
        this.addtlCardDataField = value;
      }
    }
  }
}