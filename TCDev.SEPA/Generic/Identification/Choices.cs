using System;
using System.ComponentModel;
using System.Text;
// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Choices.cs
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
using System.Xml.Serialization;
using TCDev.SEPA.CAMT;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable]
  [DesignerCategory("code")]
  public class AccountIdentification4Choice
  {
    private object itemField;

    [XmlElement("IBAN", typeof(string))]
    [XmlElement("Othr", typeof(GenericAccountIdentification1))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
  [Serializable]
  [DesignerCategory("code")]
  public class AccountSchemeName1Choice
  {
    private ItemChoiceType4 itemElementNameField;
    private string itemField;

    [XmlElement("Cd", typeof(string))]
    [XmlElement("Prtry", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlIgnore]
    public ItemChoiceType4 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
  [Serializable]
  [DesignerCategory("code")]
  public class FinancialIdentificationSchemeName1Choice
  {
    private ItemChoiceType3 itemElementNameField;
    private string itemField;

    [XmlElement("Cd", typeof(string))]
    [XmlElement("Prtry", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlIgnore]
    public ItemChoiceType3 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }

  [Serializable()]
  [DesignerCategory("code")]
  public partial class ClearingSystemIdentification2Choice
  {

    private string itemField;

    private ItemChoiceType2 itemElementNameField;

    [XmlElement("Cd", typeof(string))]
    [XmlElement("Prtry", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item
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
    public ItemChoiceType2 ItemElementName
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