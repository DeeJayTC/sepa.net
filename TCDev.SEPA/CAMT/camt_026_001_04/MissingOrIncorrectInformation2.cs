// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.MissingOrIncorrectInformation2.cs
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

namespace TCDev.SEPA.CAMT
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class MissingOrIncorrectInformation2
  {

    private System.Nullable<bool> aMLReqField;

    private List<UnableToApplyMissingInformation2Code> mssngInfField;

    private List<UnableToApplyIncorrectInformation3Code> incrrctInfField;

    public MissingOrIncorrectInformation2()
    {
      this.incrrctInfField = new List<UnableToApplyIncorrectInformation3Code>();
      this.mssngInfField = new List<UnableToApplyMissingInformation2Code>();
    }

    public bool AMLReq
    {
      get
      {
        if (this.aMLReqField.HasValue)
        {
          return this.aMLReqField.Value;
        }
        else
        {
          return default(bool);
        }
      }
      set
      {
        this.aMLReqField = value;
      }
    }

    [XmlIgnore()]
    public bool AMLReqSpecified
    {
      get
      {
        return this.aMLReqField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.aMLReqField = null;
        }
      }
    }

    [XmlElement("MssngInf")]
    public List<UnableToApplyMissingInformation2Code> MssngInf
    {
      get
      {
        return this.mssngInfField;
      }
      set
      {
        this.mssngInfField = value;
      }
    }

    [XmlElement("IncrrctInf")]
    public List<UnableToApplyIncorrectInformation3Code> IncrrctInf
    {
      get
      {
        return this.incrrctInfField;
      }
      set
      {
        this.incrrctInfField = value;
      }
    }
  }
}