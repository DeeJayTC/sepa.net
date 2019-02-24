// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.BranchAndFinancialInstitutionIdentification5.cs
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
using System.ComponentModel;
using TCDev.SEPA.CAMT.Generic;

namespace TCDev.SEPA.Generic.Identification
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class BranchAndFinancialInstitutionIdentification5
  {

    private FinancialInstitutionIdentification8 _finInstnIdField;

    private BranchData2 _brnchIdField;

    public BranchAndFinancialInstitutionIdentification5()
    {
      this._brnchIdField = new BranchData2();
      this._finInstnIdField = new FinancialInstitutionIdentification8();
    }

    public FinancialInstitutionIdentification8 FinInstnId
    {
      get
      {
        return this._finInstnIdField;
      }
      set
      {
        this._finInstnIdField = value;
      }
    }
    
    public BranchData2 BrnchId
    {
      get
      {
        return this._brnchIdField;
      }
      set
      {
        this._brnchIdField = value;
      }
    }
  }
}