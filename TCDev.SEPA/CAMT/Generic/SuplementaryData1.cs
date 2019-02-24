// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.SuplementaryData1.cs
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
using System.Xml;
using System.Xml.Serialization;

namespace TCDev.SEPA.CAMT.Generic
{

  [Serializable]
  [DesignerCategory("code")]
  public class SupplementaryData1
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private XmlElement _envlpField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _plcAndNmField;

    [XmlElement("PlcAndNm")]
    public string PlaceAndName
    {
      get { return _plcAndNmField; }
      set { _plcAndNmField = value; }
    }

    [XmlElement("Envlp")]
    public XmlElement Envelope
    {
      get { return _envlpField; }
      set { _envlpField = value; }
    }
  }
}