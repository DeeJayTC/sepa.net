// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GenericIdentification32.cs
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
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class GenericIdentification32
  {

    private string idField;

    private PartyType3Code? tpField;

    private PartyType4Code? issrField;

    private string shrtNmField;

    public string Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public PartyType3Code Tp
    {
      get
      {
        if (this.tpField.HasValue)
        {
          return this.tpField.Value;
        }
        else
        {
          return default(PartyType3Code);
        }
      }
      set
      {
        this.tpField = value;
      }
    }

    [XmlIgnore()]
    public bool TpSpecified
    {
      get
      {
        return this.tpField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.tpField = null;
        }
      }
    }

    public PartyType4Code Issr
    {
      get
      {
        if (this.issrField.HasValue)
        {
          return this.issrField.Value;
        }
        else
        {
          return default(PartyType4Code);
        }
      }
      set
      {
        this.issrField = value;
      }
    }

    [XmlIgnore()]
    public bool IssrSpecified
    {
      get
      {
        return this.issrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.issrField = null;
        }
      }
    }

    public string ShrtNm
    {
      get
      {
        return this.shrtNmField;
      }
      set
      {
        this.shrtNmField = value;
      }
    }
  }
}