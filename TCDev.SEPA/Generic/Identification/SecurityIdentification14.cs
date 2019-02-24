// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.SecurityIdentification14.cs
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
  [Serializable()]
  [DesignerCategory("code")]

  public partial class SecurityIdentification14
  {

    private string _iSinField;

    private List<OtherIdentification1> _othrIdField;

    private string _descField;

    public SecurityIdentification14()
    {
      this._othrIdField = new List<OtherIdentification1>();
    }

    public string ISIN
    {
      get
      {
        return this._iSinField;
      }
      set
      {
        this._iSinField = value;
      }
    }

    [XmlElement("OthrId")]
    public List<OtherIdentification1> OthrId
    {
      get
      {
        return this._othrIdField;
      }
      set
      {
        this._othrIdField = value;
      }
    }

    public string Desc
    {
      get
      {
        return this._descField;
      }
      set
      {
        this._descField = value;
      }
    }
  }
}