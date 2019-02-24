// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnderlyingGroupInformation1.cs
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

namespace TCDev.SEPA.Generic.Underlying
{
  [Serializable]
  [DesignerCategory("code")]
  public class UnderlyingGroupInformation1
  {
    private DateTime? _orgnlCreDtTmField;

    private string _orgnlMsgDlvryChanlField;
    private string _orgnlMsgIdField;

    private string _orgnlMsgNmIdField;

    public string OrgnlMsgId
    {
      get { return _orgnlMsgIdField; }
      set { _orgnlMsgIdField = value; }
    }

    public string OrgnlMsgNmId
    {
      get { return _orgnlMsgNmIdField; }
      set { _orgnlMsgNmIdField = value; }
    }

    public DateTime OrgnlCreDtTm
    {
      get
      {
        if (_orgnlCreDtTmField.HasValue)
        {
          return _orgnlCreDtTmField.Value;
        }
        return default(DateTime);
      }
      set { _orgnlCreDtTmField = value; }
    }

    [XmlIgnore]
    public bool OrgnlCreDtTmSpecified
    {
      get { return _orgnlCreDtTmField.HasValue; }
      set
      {
        if (value == false)
        {
          _orgnlCreDtTmField = null;
        }
      }
    }

    public string OrgnlMsgDlvryChanl
    {
      get { return _orgnlMsgDlvryChanlField; }
      set { _orgnlMsgDlvryChanlField = value; }
    }
  }
}