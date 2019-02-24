using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.StructuredRemittanceInformation3.cs
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
using System.Xml.Serialization;
using TCDev.SEPA.CAMT;
using TCDev.SEPA.Generic.Identification;

namespace TCDev.SEPA.Generic.Structured
{
  [SerializableAttribute()]
  [DesignerCategory("code")]

  public partial class StructuredRemittanceInformation9
  {

    private List<ReferredDocumentInformation3> rfrdDocInfField;

    private RemittanceAmount2 rfrdDocAmtField;

    private CreditorReferenceInformation2 cdtrRefInfField;

    private PartyIdentification43 invcrField;

    private PartyIdentification43 invceeField;

    private List<string> addtlRmtInfField;

    public StructuredRemittanceInformation9()
    {
      this.addtlRmtInfField = new List<string>();
      this.invceeField = new PartyIdentification43();
      this.invcrField = new PartyIdentification43();
      this.cdtrRefInfField = new CreditorReferenceInformation2();
      this.rfrdDocAmtField = new RemittanceAmount2();
      this.rfrdDocInfField = new List<ReferredDocumentInformation3>();
    }

    [XmlElement("RfrdDocInf")]
    public List<ReferredDocumentInformation3> RfrdDocInf
    {
      get
      {
        return this.rfrdDocInfField;
      }
      set
      {
        this.rfrdDocInfField = value;
      }
    }

    public RemittanceAmount2 RfrdDocAmt
    {
      get
      {
        return this.rfrdDocAmtField;
      }
      set
      {
        this.rfrdDocAmtField = value;
      }
    }

    public CreditorReferenceInformation2 CdtrRefInf
    {
      get
      {
        return this.cdtrRefInfField;
      }
      set
      {
        this.cdtrRefInfField = value;
      }
    }

    public PartyIdentification43 Invcr
    {
      get
      {
        return this.invcrField;
      }
      set
      {
        this.invcrField = value;
      }
    }

    public PartyIdentification43 Invcee
    {
      get
      {
        return this.invceeField;
      }
      set
      {
        this.invceeField = value;
      }
    }

    [XmlElement("AddtlRmtInf")]
    public List<string> AddtlRmtInf
    {
      get
      {
        return this.addtlRmtInfField;
      }
      set
      {
        this.addtlRmtInfField = value;
      }
    }
  }
}