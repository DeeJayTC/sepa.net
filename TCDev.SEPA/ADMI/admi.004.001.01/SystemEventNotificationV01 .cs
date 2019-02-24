// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.SystemEventNotificationV01 .cs
// Author: Tim Cadenbach, TCDev    
// Created: 20.11.2013 -  TCA
// Changed: 20.11.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================


namespace TCDev.SEPA
{
  using System;
  using System.Diagnostics;
  using System.Xml.Serialization;
  using System.Collections;
  using System.Xml.Schema;
  using System.ComponentModel;
  using System.Collections.Generic;


  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.01")]
  [XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.01", IsNullable = false)]
  public partial class admi_004_001_01
  {

    private admi00400101 admi00400101Field;

    public admi_004_001_01()
    {
      this.admi00400101Field = new admi00400101();
    }

    [XmlElementAttribute("admi.004.001.01")]
    public admi00400101 admi00400101
    {
      get
      {
        return this.admi00400101Field;
      }
      set
      {
        this.admi00400101Field = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(TypeName = "admi.004.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.01")]
  public partial class admi00400101
  {

    private Event1 evtInfField;

    public admi00400101()
    {
      this.evtInfField = new Event1();
    }

    public Event1 EvtInf
    {
      get
      {
        return this.evtInfField;
      }
      set
      {
        this.evtInfField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.01")]
  public class Event1
  {

    private string evtCdField;

    private List<string> evtParamField;

    private string evtDescField;

    private DateTime? evtTmField;

    public Event1()
    {
      this.evtParamField = new List<string>();
    }

    public string EvtCd
    {
      get
      {
        return this.evtCdField;
      }
      set
      {
        this.evtCdField = value;
      }
    }

    [XmlElementAttribute("EvtParam")]
    public List<string> EvtParam
    {
      get
      {
        return this.evtParamField;
      }
      set
      {
        this.evtParamField = value;
      }
    }

    public string EvtDesc
    {
      get
      {
        return this.evtDescField;
      }
      set
      {
        this.evtDescField = value;
      }
    }

    public System.DateTime EvtTm
    {
      get
      {
        if (this.evtTmField.HasValue)
        {
          return this.evtTmField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.evtTmField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool EvtTmSpecified
    {
      get
      {
        return this.evtTmField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.evtTmField = null;
        }
      }
    }
  }
}
