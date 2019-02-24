// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.FinancialInstitutionIdentification8.cs
// Author: Tim Cadenbach, TCDev    
// Created: 10.09.2013 -  TCA
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
using TCDev.SEPA.CAMT;
using TCDev.SEPA.Generic.Contact;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable]
  [DesignerCategory("code")]
  public class FinancialInstitutionIdentification8
  {
    private string _bIcfiField;

    private ClearingSystemMemberIdentification2 _clrSysMmbIdField;

    private string _nmField;

    private GenericFinancialIdentification1 _othrField;
    private PostalAddress6 _pstlAdrField;

    public FinancialInstitutionIdentification8()
    {
      _othrField = new GenericFinancialIdentification1();
      _pstlAdrField = new PostalAddress6();
      _clrSysMmbIdField = new ClearingSystemMemberIdentification2();
    }

    [XmlElement("BICFI")]
    public string BICField
    {
      get { return _bIcfiField; }
      set { _bIcfiField = value; }
    }

    [XmlElement("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2 ClearingSystemMemberIdentification
    {
      get { return _clrSysMmbIdField; }
      set { _clrSysMmbIdField = value; }
    }

    [XmlElement("Nm")]
    public string Name
    {
      get { return _nmField; }
      set { _nmField = value; }
    }

    [XmlElement("PstlAdr")]
    public PostalAddress6 PostalAddress
    {
      get { return _pstlAdrField; }
      set { _pstlAdrField = value; }
    }

    [XmlElement("Othr")]
    public GenericFinancialIdentification1 GenericFinancialIdentification
    {
      get { return _othrField; }
      set { _othrField = value; }
    }
  }
}