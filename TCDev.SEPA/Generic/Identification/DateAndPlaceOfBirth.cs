// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.DateAndPlaceOfBirth.cs
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
  public partial class DateAndPlaceOfBirth
  {

    private System.DateTime _birthDtField;
    private string _prvcOfBirthField;
    private string _cityOfBirthField;
    private string _ctryOfBirthField;

    [XmlElement(DataType = "date")]
    public System.DateTime BirthDt
    {
      get
      {
        return this._birthDtField;
      }
      set
      {
        this._birthDtField = value;
      }
    }
        [XmlElement(ElementName = "PrvcOfBirth")]
    public string PrvcOfBirth
    {
      get
      {
        return this._prvcOfBirthField;
      }
      set
      {
        this._prvcOfBirthField = value;
      }
    }
            [XmlElement(ElementName = "CityOfBirth")]
    public string CityOfBirth
    {
      get
      {
        return this._cityOfBirthField;
      }
      set
      {
        this._cityOfBirthField = value;
      }
    }
            [XmlElement(ElementName = "CtryOfBirth")]
    public string CountryOfBirth
    {
      get
      {
        return this._ctryOfBirthField;
      }
      set
      {
        this._ctryOfBirthField = value;
      }
    }
  }
}