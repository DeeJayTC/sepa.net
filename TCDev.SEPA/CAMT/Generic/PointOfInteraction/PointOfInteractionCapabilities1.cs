// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PointOfInteractionCapabilities1.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic.PointOfInteraction
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class PointOfInteractionCapabilities1
  {

    private List<CardDataReading1Code> cardRdngCpbltiesField;

    private List<CardholderVerificationCapability1Code> crdhldrVrfctnCpbltiesField;

    private System.Nullable<OnLineCapability1Code> onLineCpbltiesField;

    private List<DisplayCapabilities1> dispCpbltiesField;

    private string prtLineWidthField;

    public PointOfInteractionCapabilities1()
    {
      this.dispCpbltiesField = new List<DisplayCapabilities1>();
      this.crdhldrVrfctnCpbltiesField = new List<CardholderVerificationCapability1Code>();
      this.cardRdngCpbltiesField = new List<CardDataReading1Code>();
    }

    [XmlElement("CardRdngCpblties")]
    public List<CardDataReading1Code> CardRdngCpblties
    {
      get
      {
        return this.cardRdngCpbltiesField;
      }
      set
      {
        this.cardRdngCpbltiesField = value;
      }
    }

    [XmlElement("CrdhldrVrfctnCpblties")]
    public List<CardholderVerificationCapability1Code> CrdhldrVrfctnCpblties
    {
      get
      {
        return this.crdhldrVrfctnCpbltiesField;
      }
      set
      {
        this.crdhldrVrfctnCpbltiesField = value;
      }
    }

    public OnLineCapability1Code OnLineCpblties
    {
      get
      {
        if (this.onLineCpbltiesField.HasValue)
        {
          return this.onLineCpbltiesField.Value;
        }
        else
        {
          return default(OnLineCapability1Code);
        }
      }
      set
      {
        this.onLineCpbltiesField = value;
      }
    }

    [XmlIgnore()]
    public bool OnLineCpbltiesSpecified
    {
      get
      {
        return this.onLineCpbltiesField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.onLineCpbltiesField = null;
        }
      }
    }

    [XmlElement("DispCpblties")]
    public List<DisplayCapabilities1> DispCpblties
    {
      get
      {
        return this.dispCpbltiesField;
      }
      set
      {
        this.dispCpbltiesField = value;
      }
    }

    public string PrtLineWidth
    {
      get
      {
        return this.prtLineWidthField;
      }
      set
      {
        this.prtLineWidthField = value;
      }
    }
  }
}