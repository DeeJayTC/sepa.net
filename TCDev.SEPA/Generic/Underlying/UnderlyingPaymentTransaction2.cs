// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.UnderlyingPaymentTransaction2.cs
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
  public partial class UnderlyingPaymentTransaction2
  {

    private UnderlyingGroupInformation1 _orgnlGrpInfField;

    private string _orgnlInstrIdField;

    private string _orgnlEndToEndIdField;

    private string _orgnlTxIdField;

    private ActiveOrHistoricCurrencyAndAmount _orgnlIntrBkSttlmAmtField;

    private System.DateTime _orgnlIntrBkSttlmDtField;

    public UnderlyingPaymentTransaction2()
    {
      this._orgnlIntrBkSttlmAmtField = new ActiveOrHistoricCurrencyAndAmount();
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

    public string OrgnlTxId
    {
      get
      {
        return this._orgnlTxIdField;
      }
      set
      {
        this._orgnlTxIdField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount OrgnlIntrBkSttlmAmt
    {
      get
      {
        return this._orgnlIntrBkSttlmAmtField;
      }
      set
      {
        this._orgnlIntrBkSttlmAmtField = value;
      }
    }

    [XmlElement(DataType = "date")]
    public System.DateTime OrgnlIntrBkSttlmDt
    {
      get
      {
        return this._orgnlIntrBkSttlmDtField;
      }
      set
      {
        this._orgnlIntrBkSttlmDtField = value;
      }
    }
  }
}