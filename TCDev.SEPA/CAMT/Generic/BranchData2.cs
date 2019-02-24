// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.BranchData2.cs
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
using TCDev.SEPA.Generic.Contact;

namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class BranchData2
  {

    private string idField;

    private string nmField;

    private PostalAddress6 pstlAdrField;

    public BranchData2()
    {
      this.pstlAdrField = new PostalAddress6();
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

    public string Nm
    {
      get
      {
        return this.nmField;
      }
      set
      {
        this.nmField = value;
      }
    }

    public PostalAddress6 PstlAdr
    {
      get
      {
        return this.pstlAdrField;
      }
      set
      {
        this.pstlAdrField = value;
      }
    }
  }
}