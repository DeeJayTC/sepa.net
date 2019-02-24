// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PartyIdentification43.cs
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
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;
using TCDev.SEPA.Generic.Contact;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable]
  [DesignerCategory("code")]
  public class PartyIdentification43
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private ContactDetails2 _ctctDtlsField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _ctryOfResField;
    [EditorBrowsable(EditorBrowsableState.Never)] private Party11Choice _idField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _nmField;
    [EditorBrowsable(EditorBrowsableState.Never)] private PostalAddress6 _pstlAdrField;

    public PartyIdentification43()
    {
      _ctctDtlsField = new ContactDetails2();
      _idField = new Party11Choice();
      _pstlAdrField = new PostalAddress6();
    }

    public string Nm
    {
      get { return _nmField; }
      set { _nmField = value; }
    }

    public PostalAddress6 PstlAdr
    {
      get { return _pstlAdrField; }
      set { _pstlAdrField = value; }
    }

    public Party11Choice Id
    {
      get { return _idField; }
      set { _idField = value; }
    }

    [XmlElement("CtryOfRes")]
    public string CountryOfResidence
    {
      get { return _ctryOfResField; }
      set { _ctryOfResField = value; }
    }

    [XmlElement("CtctDtls")]
    public ContactDetails2 ContactDetails
    {
      get { return _ctctDtlsField; }
      set { _ctctDtlsField = value; }
    }
  }
}