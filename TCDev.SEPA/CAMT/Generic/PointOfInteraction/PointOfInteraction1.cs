// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PointOfInteraction1.cs
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
using TCDev.SEPA.Generic.Identification;


namespace TCDev.SEPA.CAMT.Generic.PointOfInteraction
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class PointOfInteraction1
  {

    private GenericIdentification32 idField;

    private string sysNmField;

    private string grpIdField;

    private PointOfInteractionCapabilities1 cpbltiesField;

    private List<PointOfInteractionComponent1> cmpntField;

    public PointOfInteraction1()
    {
      this.cmpntField = new List<PointOfInteractionComponent1>();
      this.cpbltiesField = new PointOfInteractionCapabilities1();
      this.idField = new GenericIdentification32();
    }

    public GenericIdentification32 Id
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

    public string SysNm
    {
      get
      {
        return this.sysNmField;
      }
      set
      {
        this.sysNmField = value;
      }
    }

    public string GrpId
    {
      get
      {
        return this.grpIdField;
      }
      set
      {
        this.grpIdField = value;
      }
    }

    public PointOfInteractionCapabilities1 Cpblties
    {
      get
      {
        return this.cpbltiesField;
      }
      set
      {
        this.cpbltiesField = value;
      }
    }

    [XmlElement("Cmpnt")]
    public List<PointOfInteractionComponent1> Cmpnt
    {
      get
      {
        return this.cmpntField;
      }
      set
      {
        this.cmpntField = value;
      }
    }
  }
}