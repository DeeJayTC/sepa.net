// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.OriginalGroupInformation3.cs
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
  [Serializable]
  [DesignerCategory("code")]
  public class OriginalGroupInformation3
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime? _orgnlCreDtTmField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _orgnlMsgIdField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _orgnlMsgNmIdField;

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
  }
}