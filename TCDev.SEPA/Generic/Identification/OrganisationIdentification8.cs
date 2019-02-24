// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.OrganisationIdentification8.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]
  [XmlTypeAttribute(TypeName = "OrganisationIdentification8")]
  [XmlRoot("OrganisationIdentification8")]
  public partial class OrganisationIdentification8
  {

    private List<GenericOrganisationIdentification1> _othrField;

    [XmlElementAttribute(Order = 0, ElementName = "AnyBIC")]
    public string AnyBic { get; set; }

    [XmlElementAttribute("Othr", Order = 1, ElementName = "Othr")]
    public List<GenericOrganisationIdentification1> GenericOrganisationIdentification
    {
      get
      {
        if ((this._othrField == null))
        {
          this._othrField = new List<GenericOrganisationIdentification1>();
        }
        return this._othrField;
      }
      set
      {
        this._othrField = value;
      }
    }
  }
}