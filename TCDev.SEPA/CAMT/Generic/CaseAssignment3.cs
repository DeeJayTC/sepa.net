// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CaseAssignment3.cs
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
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class CaseAssignment3
  {

    private string idField;

    private Party12Choice assgnrField;

    private Party12Choice assgneField;

    private System.DateTime creDtTmField;

    public CaseAssignment3()
    {
      this.assgneField = new Party12Choice();
      this.assgnrField = new Party12Choice();
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

    public Party12Choice Assgnr
    {
      get
      {
        return this.assgnrField;
      }
      set
      {
        this.assgnrField = value;
      }
    }

    public Party12Choice Assgne
    {
      get
      {
        return this.assgneField;
      }
      set
      {
        this.assgneField = value;
      }
    }

    public System.DateTime CreDtTm
    {
      get
      {
        return this.creDtTmField;
      }
      set
      {
        this.creDtTmField = value;
      }
    }
  }
}