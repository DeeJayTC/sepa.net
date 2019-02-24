// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnderlyingTransaction2Choice.cs
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

namespace TCDev.SEPA.Generic.Underlying
{
  [Serializable]
  [DesignerCategory("code")]
  public class UnderlyingTransaction2Choice
  {
    private object _itemField;

    [XmlElement("Initn", typeof (UnderlyingPaymentInstruction2))]
    [XmlElement("IntrBk", typeof (UnderlyingPaymentTransaction2))]
    [XmlElement("StmtNtry", typeof (UnderlyingStatementEntry1))]
    public object Item
    {
      get { return _itemField; }
      set { _itemField = value; }
    }
  }
}