// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CardSequenceNumberRange1.cs
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

namespace TCDev.SEPA.CAMT.Generic.Card
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class CardSequenceNumberRange1
  {

    private string frstTxField;

    private string lastTxField;

    public string FrstTx
    {
      get
      {
        return this.frstTxField;
      }
      set
      {
        this.frstTxField = value;
      }
    }

    public string LastTx
    {
      get
      {
        return this.lastTxField;
      }
      set
      {
        this.lastTxField = value;
      }
    }
  }
}