// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GenericIdentification20.cs
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

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class GenericIdentification20
  {

    private string idField;

    private string issrField;

    private string schmeNmField;

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

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }

    public string SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }
  }
}