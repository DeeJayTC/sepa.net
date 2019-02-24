// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GroupHeader55.cs
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
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using TCDev.SEPA.Generic.Identification;
using TCDev.SEPA.PAIN;
using TCDev.SEPA.PAIN.Generic;
using Authorisation1Choice = TCDev.SEPA.PAIN.Generic.Authorisation1Choice;


namespace TCDev.SEPA.Generic.GroupHeader
{
  [Serializable]
  [DesignerCategory("code")]
  public class GroupHeader55
  {
    public GroupHeader55()
    {
      FwdgAgt = new BranchAndFinancialInstitutionIdentification5();
      InitgPty = new PartyIdentification43();
      Authstn = new List<Authorisation1Choice>();
    }

    public string MsgId { get; set; }
    public DateTime CreDtTm { get; set; }

    [XmlElement("Authstn")]
    public List<Authorisation1Choice> Authstn { get; set; }

    public string NbOfTxs { get; set; }
    public decimal CtrlSum { get; set; }

    [XmlIgnore]
    public bool CtrlSumSpecified { get; set; }

    public PartyIdentification43 InitgPty { get; set; }
    public BranchAndFinancialInstitutionIdentification5 FwdgAgt { get; set; }
  }
}