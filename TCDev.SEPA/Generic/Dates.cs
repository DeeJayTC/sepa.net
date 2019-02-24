// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Dates.cs
// Author: Tim Cadenbach, TCDev    
// Created: 07.09.2013 -  TCA
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
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using TCDev.SEPA.CAMT.Generic;
using TCDev.SEPA.PAIN;

namespace TCDev.SEPA.Generic
{
  [Serializable]
  [DesignerCategory("code")]
  public class DateAndDateTimeChoice
  {
    private ItemChoiceType9 _itemElementNameField;
    private DateTime _itemField;

    [XmlElement("Dt", typeof (DateTime))]
    [XmlElement("DtTm", typeof (DateTime))]
    [XmlChoiceIdentifier("ItemElementName")]
    public DateTime Item
    {
      get { return _itemField; }
      set { _itemField = value; }
    }

    [XmlIgnore]
    public ItemChoiceType9 ItemElementName
    {
      get { return _itemElementNameField; }
      set { _itemElementNameField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  public class DateOrDateTimePeriodChoice
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private object _itemField;

    [XmlElement("Dt", typeof (DatePeriodDetails))]
    [XmlElement("DtTm", typeof (DateTimePeriodDetails))]
    public object Item
    {
      get { return _itemField; }
      set { _itemField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  public class DatePeriodDetails
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime _frDtField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime _toDtField;

    [XmlElement(ElementName = "FrDt")]
    public DateTime FromDate
    {
      get { return _frDtField; }
      set { _frDtField = value; }
    }

    [XmlElement(ElementName = "ToDt")]
    public DateTime ToDate
    {
      get { return _toDtField; }
      set { _toDtField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  public class DateTimePeriodDetails
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime _frDtTmField;
    [EditorBrowsable(EditorBrowsableState.Never)] private DateTime _toDtTmField;

    [XmlElement(ElementName = "FrDtTm")]
    public DateTime FromDateTime
    {
      get { return _frDtTmField; }
      set { _frDtTmField = value; }
    }

    [XmlElement(ElementName = "ToDtTm")]
    public DateTime ToDateTime
    {
      get { return _toDtTmField; }
      set { _toDtTmField = value; }
    }
  }
}