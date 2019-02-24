// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PlainCardData1.cs
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

namespace TCDev.SEPA.CAMT.Generic.Card
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class PlainCardData1
  {

    private string pANField;

    private string cardSeqNbField;

    private string fctvDtField;

    private string xpryDtField;

    private string svcCdField;

    private List<TrackData1> trckDataField;

    private CardSecurityInformation1 cardSctyCdField;

    public PlainCardData1()
    {
      this.cardSctyCdField = new CardSecurityInformation1();
      this.trckDataField = new List<TrackData1>();
    }

    public string PAN
    {
      get
      {
        return this.pANField;
      }
      set
      {
        this.pANField = value;
      }
    }

    public string CardSeqNb
    {
      get
      {
        return this.cardSeqNbField;
      }
      set
      {
        this.cardSeqNbField = value;
      }
    }

    [XmlElement(DataType = "gYearMonth")]
    public string FctvDt
    {
      get
      {
        return this.fctvDtField;
      }
      set
      {
        this.fctvDtField = value;
      }
    }

    [XmlElement(DataType = "gYearMonth")]
    public string XpryDt
    {
      get
      {
        return this.xpryDtField;
      }
      set
      {
        this.xpryDtField = value;
      }
    }

    public string SvcCd
    {
      get
      {
        return this.svcCdField;
      }
      set
      {
        this.svcCdField = value;
      }
    }

    [XmlElement("TrckData")]
    public List<TrackData1> TrckData
    {
      get
      {
        return this.trckDataField;
      }
      set
      {
        this.trckDataField = value;
      }
    }

    public CardSecurityInformation1 CardSctyCd
    {
      get
      {
        return this.cardSctyCdField;
      }
      set
      {
        this.cardSctyCdField = value;
      }
    }
  }
}