// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.OrganisationIdentificationSchemeName1Choice.cs
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

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class OrganisationIdentificationSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType itemElementNameField;

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
    public ItemChoiceType ItemElementName
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