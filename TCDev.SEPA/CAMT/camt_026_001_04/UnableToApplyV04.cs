// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnableToApplyV04.cs
// Author: Tim Cadenbach, TCDev    
// Created: 10.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================

using System.CodeDom.Compiler;
using TCDev.SEPA.CAMT.Generic;
using TCDev.SEPA.Generic.Underlying;

namespace TCDev.SEPA.CAMT
{
  using System;
  using System.Diagnostics;
  using System.Xml.Serialization;
  using System.Collections;
  using System.Xml.Schema;
  using System.ComponentModel;
  using System.Collections.Generic;

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.04")]
  [XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.04", IsNullable = false)]
// ReSharper disable once InconsistentNaming
  public partial class camt_026_001_04
  {

    private UnableToApplyV04 _ublToApplyField;

    public camt_026_001_04()
    {
      this._ublToApplyField = new UnableToApplyV04();
    }

    [XmlElementAttribute("ublToApply")]
    public UnableToApplyV04 UnableToApplyMessage
    {
      get
      {
        return this._ublToApplyField;
      }
      set
      {
        this._ublToApplyField = value;
      }
    }
  }


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.04")]
  public partial class UnableToApplyV04
  {

    private CaseAssignment3 assgnmtField;

    private Case3 caseField;

    private UnderlyingTransaction2Choice undrlygField;

    private UnableToApplyJustification2Choice justfnField;

    private List<SupplementaryData1> splmtryDataField;

    public UnableToApplyV04()
    {
      this.splmtryDataField = new List<SupplementaryData1>();
      this.justfnField = new UnableToApplyJustification2Choice();
      this.undrlygField = new UnderlyingTransaction2Choice();
      this.caseField = new Case3();
      this.assgnmtField = new CaseAssignment3();
    }

    public CaseAssignment3 Assgnmt
    {
      get
      {
        return this.assgnmtField;
      }
      set
      {
        this.assgnmtField = value;
      }
    }

    public Case3 Case
    {
      get
      {
        return this.caseField;
      }
      set
      {
        this.caseField = value;
      }
    }

    public UnderlyingTransaction2Choice Undrlyg
    {
      get
      {
        return this.undrlygField;
      }
      set
      {
        this.undrlygField = value;
      }
    }

    public UnableToApplyJustification2Choice Justfn
    {
      get
      {
        return this.justfnField;
      }
      set
      {
        this.justfnField = value;
      }
    }

    [XmlElementAttribute("SplmtryData")]
    public List<SupplementaryData1> SuplementaryData
    {
      get
      {
        return this.splmtryDataField;
      }
      set
      {
        this.splmtryDataField = value;
      }
    }
  }
}
