// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.ContactDetails2.cs
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
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Contact
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class ContactDetails2
  {
    private NamePrefix1Code? _nmPrfxField;
    private string _nmField;
    private string _phneNbField;
    private string _mobNbField;
    private string _faxNbField;
    private string _emailAdrField;
    private string _othrField;

    [XmlElement("NmPrfx")]
    public NamePrefix1Code NamePrefix
    {
      get
      {
        if (this._nmPrfxField.HasValue)
        {
          return this._nmPrfxField.Value;
        }
        else
        {
          return default(NamePrefix1Code);
        }
      }
      set
      {
        this._nmPrfxField = value;
      }
    }

    [XmlIgnore()]
    public bool NmPrfxSpecified
    {
      get
      {
        return this._nmPrfxField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._nmPrfxField = null;
        }
      }
    }

    [XmlElement("Nm")]
    public string Name
    {
      get
      {
        return this._nmField;
      }
      set
      {
        this._nmField = value;
      }
    }

    [XmlElement("PhneNb")]
    public string Phonenumber
    {
      get
      {
        return this._phneNbField;
      }
      set
      {
        this._phneNbField = value;
      }
    }

    [XmlElement("MobNb")]
    public string MobileNumber
    {
      get
      {
        return this._mobNbField;
      }
      set
      {
        this._mobNbField = value;
      }
    }

    [XmlElement("FaxNb")]
    public string Faxnumber
    {
      get
      {
        return this._faxNbField;
      }
      set
      {
        this._faxNbField = value;
      }
    }
   
    [XmlElement("EmailAdr")]
    public string EmailAddress
    {
      get
      {
        return this._emailAdrField;
      }
      set
      {
        this._emailAdrField = value;
      }
    }
   
    [XmlElement("Othr")]
    public string Other
    {
      get
      {
        return this._othrField;
      }
      set
      {
        this._othrField = value;
      }
    }
  }
}