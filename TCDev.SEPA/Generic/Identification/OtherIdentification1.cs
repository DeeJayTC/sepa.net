// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.OtherIdentification1.cs
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
  public partial class OtherIdentification1
  {

    private string idField;

    private string sfxField;

    private IdentificationSource3Choice tpField;

    public OtherIdentification1()
    {
      this.tpField = new IdentificationSource3Choice();
    }

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

    public string Sfx
    {
      get
      {
        return this.sfxField;
      }
      set
      {
        this.sfxField = value;
      }
    }

    public IdentificationSource3Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }
  }
}