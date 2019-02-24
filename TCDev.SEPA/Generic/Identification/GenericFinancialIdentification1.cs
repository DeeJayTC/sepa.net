// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GenericFinancialIdentification1.cs
// Author: Tim Cadenbach, TCDev    
// Created: 11.09.2013 -  TCA
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

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable]
  [DesignerCategory("code")]
  public class GenericFinancialIdentification1
  {
    private string _idField;

    private string _issrField;
    private FinancialIdentificationSchemeName1Choice _schmeNmField;

    public GenericFinancialIdentification1()
    {
      _schmeNmField = new FinancialIdentificationSchemeName1Choice();
    }

    public string Id
    {
      get { return _idField; }
      set { _idField = value; }
    }

    public FinancialIdentificationSchemeName1Choice SchmeNm
    {
      get { return _schmeNmField; }
      set { _schmeNmField = value; }
    }

    public string Issr
    {
      get { return _issrField; }
      set { _issrField = value; }
    }
  }
}