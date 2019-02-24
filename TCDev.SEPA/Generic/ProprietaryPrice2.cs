// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.ProprietaryPrice2.cs
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


namespace TCDev.SEPA.Generic
{
  [Serializable]
  [DesignerCategory("code")]
  public class ProprietaryPrice2
  {
    private ActiveOrHistoricCurrencyAndAmount pricField;
    private string tpField;

    public ProprietaryPrice2()
    {
      pricField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public string Tp
    {
      get { return tpField; }
      set { tpField = value; }
    }

    public ActiveOrHistoricCurrencyAndAmount Pric
    {
      get { return pricField; }
      set { pricField = value; }
    }
  }
}