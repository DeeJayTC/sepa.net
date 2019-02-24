// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnableToApplyJustification2Choice.cs
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
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT
{
  [Serializable()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.04")]
  public partial class UnableToApplyJustification2Choice
  {

    private object itemField;

    private ItemChoiceType4 itemElementNameField;

    [XmlElement("AnyInf", typeof(bool))]
    [XmlElement("MssngOrIncrrctInf", typeof(MissingOrIncorrectInformation2))]
    [XmlElement("PssblDplctInstr", typeof(bool))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlIgnore()]
    public ItemChoiceType4 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }
  }
}