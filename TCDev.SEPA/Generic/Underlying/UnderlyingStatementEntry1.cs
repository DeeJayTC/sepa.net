// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnderlyingStatementEntry1.cs
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
using TCDev.SEPA.Generic.Identification;

namespace TCDev.SEPA.Generic.Underlying
{
  [Serializable]
  [DesignerCategory("code")]
  public class UnderlyingStatementEntry1
  {
    private OriginalGroupInformation3 _orgnlGrpInfField;

    private string _orgnlNtryIdField;
    private string _orgnlStmtIdField;

    public UnderlyingStatementEntry1()
    {
      _orgnlGrpInfField = new OriginalGroupInformation3();
    }

    public OriginalGroupInformation3 OrgnlGrpInf
    {
      get { return _orgnlGrpInfField; }
      set { _orgnlGrpInfField = value; }
    }

    public string OrgnlStmtId
    {
      get { return _orgnlStmtIdField; }
      set { _orgnlStmtIdField = value; }
    }

    public string OrgnlNtryId
    {
      get { return _orgnlNtryIdField; }
      set { _orgnlNtryIdField = value; }
    }
  }
}