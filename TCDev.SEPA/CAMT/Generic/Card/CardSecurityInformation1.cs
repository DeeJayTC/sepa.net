// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CardSecurityInformation1.cs
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
using System.ComponentModel;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic.Card
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class CardSecurityInformation1
  {

    private CSCManagement1Code cSCMgmtField;

    private string cSCValField;

    public CSCManagement1Code CSCMgmt
    {
      get
      {
        return this.cSCMgmtField;
      }
      set
      {
        this.cSCMgmtField = value;
      }
    }

    public string CSCVal
    {
      get
      {
        return this.cSCValField;
      }
      set
      {
        this.cSCValField = value;
      }
    }
  }
}