// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PersonIdentification5.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable]
  [DesignerCategory("code")]
  public class PersonIdentification5
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private DateAndPlaceOfBirth _dtAndPlcOfBirthField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<GenericPersonIdentification1> _othrField;

    public PersonIdentification5()
    {
      _othrField = new List<GenericPersonIdentification1>();
      _dtAndPlcOfBirthField = new DateAndPlaceOfBirth();
    }

    public DateAndPlaceOfBirth DtAndPlcOfBirth
    {
      get { return _dtAndPlcOfBirthField; }
      set { _dtAndPlcOfBirthField = value; }
    }

    [XmlElement("Othr")]
    public List<GenericPersonIdentification1> Othr
    {
      get { return _othrField; }
      set { _othrField = value; }
    }
  }
}