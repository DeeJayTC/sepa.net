// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GenericPersonIdentification1.cs
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
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class GenericPersonIdentification1
  {

    private string idField;

    private PersonIdentificationSchemeName1Choice schmeNmField;

    private string issrField;

    public GenericPersonIdentification1()
    {
      this.schmeNmField = new PersonIdentificationSchemeName1Choice();
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

    public PersonIdentificationSchemeName1Choice SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }
  }
}