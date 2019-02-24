// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Choices.cs
// Author: Tim Cadenbach, TCDev    
// Created: 07.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using TCDev.SEPA.Generic.Identification;
using TCDev.SEPA.Generic.Underlying;

namespace TCDev.SEPA.Generic
{
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class Party12Choice
  {

    private object _itemField;

    [XmlElementAttribute("Agt", typeof(Identification.BranchAndFinancialInstitutionIdentification5))]
    [XmlElementAttribute("Pty", typeof(PartyIdentification43))]
    public object Item
    {
      get
      {
        return this._itemField;
      }
      set
      {
        this._itemField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategory("code")]
  public partial class Party11Choice
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    private object _itemField;

    [XmlElementAttribute("OrgId", typeof(OrganisationIdentification8))]
    [XmlElementAttribute("PrvtId", typeof(PersonIdentification5))]
    public object Item
    {
      get
      {
        return this._itemField;
      }
      set
      {
        this._itemField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class FinancialIdentificationSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType3 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType3 ItemElementName
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

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class PersonIdentificationSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType1 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName
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

  [Serializable()]
  [DesignerCategory("code")]
  public partial class UnderlyingTransaction2Choice
  {
    [EditorBrowsable(EditorBrowsableState.Never)] 
    private object _itemField;

    [XmlElement("Initn", typeof(UnderlyingPaymentInstruction2))]
    [XmlElement("IntrBk", typeof(UnderlyingPaymentTransaction2))]
    [XmlElement("StmtNtry", typeof(UnderlyingStatementEntry1))]
    public object Item
    {
      get
      {
        return this._itemField;
      }
      set
      {
        this._itemField = value;
      }
    }
  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  public partial class IdentificationSource3Choice
  {

    private string itemField;

    private ItemChoiceType15 itemElementNameField;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType15 ItemElementName
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