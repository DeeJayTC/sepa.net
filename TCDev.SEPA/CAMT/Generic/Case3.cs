// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Case3.cs
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
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class Case3
  {

    private string _idField;

    private Party12Choice _cretrField;

    private bool? _reopCaseIndctnField;

    public Case3()
    {
      this._cretrField = new Party12Choice();
    }

    public string Id
    {
      get
      {
        return this._idField;
      }
      set
      {
        this._idField = value;
      }
    }

    public Party12Choice Cretr
    {
      get
      {
        return this._cretrField;
      }
      set
      {
        this._cretrField = value;
      }
    }

    public bool ReopCaseIndctn
    {
      get
      {
        if (this._reopCaseIndctnField.HasValue)
        {
          return this._reopCaseIndctnField.Value;
        }
        else
        {
          return default(bool);
        }
      }
      set
      {
        this._reopCaseIndctnField = value;
      }
    }

    [XmlIgnore()]
    public bool ReopCaseIndctnSpecified
    {
      get
      {
        return this._reopCaseIndctnField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._reopCaseIndctnField = null;
        }
      }
    }
  }
}