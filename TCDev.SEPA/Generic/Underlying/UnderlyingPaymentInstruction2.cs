// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnderlyingPaymentInstruction2.cs
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
  [Serializable()]
  [DesignerCategory("code")]
  public partial class UnderlyingPaymentInstruction2
  {

    [EditorBrowsable(EditorBrowsableState.Never)]
    private UnderlyingGroupInformation1 _orgnlGrpInfField;

    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _orgnlPmtInfIdField;

    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _orgnlInstrIdField;

    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _orgnlEndToEndIdField;

    [EditorBrowsable(EditorBrowsableState.Never)]
    private ActiveOrHistoricCurrencyAndAmount _orgnlInstdAmtField;

    [EditorBrowsable(EditorBrowsableState.Never)]
    private DateTime? _reqdExctnDtField;

    [EditorBrowsable(EditorBrowsableState.Never)]
    private DateTime? _reqdColltnDtField;

    public UnderlyingPaymentInstruction2()
    {
      this._orgnlInstdAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this._orgnlGrpInfField = new UnderlyingGroupInformation1();
    }

    public UnderlyingGroupInformation1 OrgnlGrpInf
    {
      get
      {
        return this._orgnlGrpInfField;
      }
      set
      {
        this._orgnlGrpInfField = value;
      }
    }

    public string OrgnlPmtInfId
    {
      get
      {
        return this._orgnlPmtInfIdField;
      }
      set
      {
        this._orgnlPmtInfIdField = value;
      }
    }

    public string OrgnlInstrId
    {
      get
      {
        return this._orgnlInstrIdField;
      }
      set
      {
        this._orgnlInstrIdField = value;
      }
    }

    public string OrgnlEndToEndId
    {
      get
      {
        return this._orgnlEndToEndIdField;
      }
      set
      {
        this._orgnlEndToEndIdField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount OrgnlInstdAmt
    {
      get
      {
        return this._orgnlInstdAmtField;
      }
      set
      {
        this._orgnlInstdAmtField = value;
      }
    }

    [XmlElement(DataType = "date")]
    public System.DateTime ReqdExctnDt
    {
      get
      {
        if (this._reqdExctnDtField.HasValue)
        {
          return this._reqdExctnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this._reqdExctnDtField = value;
      }
    }

    [XmlIgnore()]
    public bool ReqdExctnDtSpecified
    {
      get
      {
        return this._reqdExctnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._reqdExctnDtField = null;
        }
      }
    }

    [XmlElement(DataType = "date")]
    public System.DateTime ReqdColltnDt
    {
      get
      {
        if (this._reqdColltnDtField.HasValue)
        {
          return this._reqdColltnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this._reqdColltnDtField = value;
      }
    }

    [XmlIgnore()]
    public bool ReqdColltnDtSpecified
    {
      get
      {
        return this._reqdColltnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this._reqdColltnDtField = null;
        }
      }
    }
  }
}