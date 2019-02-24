// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.TrackData1.cs
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

namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class TrackData1
  {

    private string trckNbField;

    private string trckValField;

    public string TrckNb
    {
      get
      {
        return this.trckNbField;
      }
      set
      {
        this.trckNbField = value;
      }
    }

    public string TrckVal
    {
      get
      {
        return this.trckValField;
      }
      set
      {
        this.trckValField = value;
      }
    }
  }
}