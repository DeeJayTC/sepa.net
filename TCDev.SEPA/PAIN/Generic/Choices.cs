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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace TCDev.SEPA.PAIN.Generic
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(TypeName = "Authorisation1Choice")]
  [XmlRoot("Authorisation1Choice")]
  public class Authorisation1Choice
  {
    [XmlElement("Cd", typeof (Authorisation1Code), Order = 0, ElementName = "Item")]
    [XmlElement("Prtry", typeof (string), Order = 0)]
    public object Item { get; set; }
  }

}