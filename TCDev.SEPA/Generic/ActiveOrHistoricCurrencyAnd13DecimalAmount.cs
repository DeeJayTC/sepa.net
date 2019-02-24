// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.ActiveOrHistoricCurrencyAnd13DecimalAmount.cs
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
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class ActiveOrHistoricCurrencyAnd13DecimalAmount
  {

    private string ccyField;

    private decimal valueField;

    [XmlAttribute()]
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

    [XmlText()]
    public decimal Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }
}