// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PointOfInteractionComponent1.cs
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

  public partial class PointOfInteractionComponent1
  {

    private POIComponentType1Code pOICmpntTpField;

    private string manfctrIdField;

    private string mdlField;

    private string vrsnNbField;

    private string srlNbField;

    private List<string> apprvlNbField;

    public PointOfInteractionComponent1()
    {
      this.apprvlNbField = new List<string>();
    }

    public POIComponentType1Code POICmpntTp
    {
      get
      {
        return this.pOICmpntTpField;
      }
      set
      {
        this.pOICmpntTpField = value;
      }
    }

    public string ManfctrId
    {
      get
      {
        return this.manfctrIdField;
      }
      set
      {
        this.manfctrIdField = value;
      }
    }

    public string Mdl
    {
      get
      {
        return this.mdlField;
      }
      set
      {
        this.mdlField = value;
      }
    }

    public string VrsnNb
    {
      get
      {
        return this.vrsnNbField;
      }
      set
      {
        this.vrsnNbField = value;
      }
    }

    public string SrlNb
    {
      get
      {
        return this.srlNbField;
      }
      set
      {
        this.srlNbField = value;
      }
    }

    [XmlElement("ApprvlNb")]
    public List<string> ApprvlNb
    {
      get
      {
        return this.apprvlNbField;
      }
      set
      {
        this.apprvlNbField = value;
      }
    }
  }
}