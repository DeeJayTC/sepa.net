// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GenericIdentification1.cs
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

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class GenericIdentification1
  {

    private string _idField;

    private string _schmeNmField;

    private string _issrField;

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

    public string SchmeNm
    {
      get
      {
        return this._schmeNmField;
      }
      set
      {
        this._schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this._issrField;
      }
      set
      {
        this._issrField = value;
      }
    }
  }
}