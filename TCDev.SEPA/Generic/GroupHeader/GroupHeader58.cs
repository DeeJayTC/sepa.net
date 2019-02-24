// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.GroupHeader58.cs
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
using TCDev.SEPA.CAMT;
using TCDev.SEPA.Generic.Identification;

namespace TCDev.SEPA.Generic.GroupHeader
{
  [Serializable]
  [DesignerCategory("code")]
  public class GroupHeader58
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private string _addtlInfField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime _creDtTmField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _msgIdField;
    [EditorBrowsable(EditorBrowsableState.Never)] private Pagination _msgPgntnField;
    [EditorBrowsable(EditorBrowsableState.Never)] private PartyIdentification43 _msgRcptField;
    [EditorBrowsable(EditorBrowsableState.Never)] private OriginalBusinessQuery1 _orgnlBizQryField;

    public GroupHeader58()
    {
      _orgnlBizQryField = new OriginalBusinessQuery1();
      _msgPgntnField = new Pagination();
      _msgRcptField = new PartyIdentification43();
    }

    public string MsgId
    {
      get { return _msgIdField; }
      set { _msgIdField = value; }
    }

    public DateTime CreDtTm
    {
      get { return _creDtTmField; }
      set { _creDtTmField = value; }
    }

    public PartyIdentification43 MsgRcpt
    {
      get { return _msgRcptField; }
      set { _msgRcptField = value; }
    }

    public Pagination MsgPgntn
    {
      get { return _msgPgntnField; }
      set { _msgPgntnField = value; }
    }

    public OriginalBusinessQuery1 OrgnlBizQry
    {
      get { return _orgnlBizQryField; }
      set { _orgnlBizQryField = value; }
    }

    public string AddtlInf
    {
      get { return _addtlInfField; }
      set { _addtlInfField = value; }
    }
  }
}