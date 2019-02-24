// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Enumerations.cs
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
using System.Text;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic
{
  [System.SerializableAttribute()]
  public enum RemittanceLocationMethod2Code
  {

    /// <remarks/>
    FAXI,

    /// <remarks/>
    EDIC,

    /// <remarks/>
    URID,

    /// <remarks/>
    EMAL,

    /// <remarks/>
    POST,

    /// <remarks/>
    SMSM,
  }
  [System.SerializableAttribute()]
  public enum RegulatoryReportingType1Code
  {

    /// <remarks/>
    CRED,

    /// <remarks/>
    DEBT,

    /// <remarks/>
    BOTH,
  }
  [Serializable()]
  public enum CreditDebitCode
  {

    /// <remarks/>
    CRDT,

    /// <remarks/>
    DBIT,
  }

  [Serializable]
  public enum AddressType2Code
  {
    /// <remarks/>
    ADDR,

    /// <remarks/>
    PBOX,

    /// <remarks/>
    HOME,

    /// <remarks/>
    BIZZ,

    /// <remarks/>
    MLTO,

    /// <remarks/>
    DLVY,
  }

  [Serializable]
  public enum UnitOfMeasure1Code
  {
    /// <remarks/>
    PIEC,

    /// <remarks/>
    TONS,

    /// <remarks/>
    FOOT,

    /// <remarks/>
    GBGA,

    /// <remarks/>
    USGA,

    /// <remarks/>
    GRAM,

    /// <remarks/>
    INCH,

    /// <remarks/>
    KILO,

    /// <remarks/>
    PUND,

    /// <remarks/>
    METR,

    /// <remarks/>
    CMET,

    /// <remarks/>
    MMET,

    /// <remarks/>
    LITR,

    /// <remarks/>
    CELI,

    /// <remarks/>
    MILI,

    /// <remarks/>
    GBOU,

    /// <remarks/>
    USOU,

    /// <remarks/>
    GBQA,

    /// <remarks/>
    USQA,

    /// <remarks/>
    GBPI,

    /// <remarks/>
    USPI,

    /// <remarks/>
    MILE,

    /// <remarks/>
    KMET,

    /// <remarks/>
    YARD,

    /// <remarks/>
    SQKI,

    /// <remarks/>
    HECT,

    /// <remarks/>
    ARES,

    /// <remarks/>
    SMET,

    /// <remarks/>
    SCMT,

    /// <remarks/>
    SMIL,

    /// <remarks/>
    SQMI,

    /// <remarks/>
    SQYA,

    /// <remarks/>
    SQFO,

    /// <remarks/>
    SQIN,

    /// <remarks/>
    ACRE,
  }

  [Serializable]
  public enum PartyType3Code
  {
    /// <remarks/>
    OPOI,

    /// <remarks/>
    MERC,

    /// <remarks/>
    ACCP,

    /// <remarks/>
    ITAG,

    /// <remarks/>
    ACQR,

    /// <remarks/>
    CISS,

    /// <remarks/>
    DLIS,
  }

  [Serializable]
  public enum PartyType4Code
  {
    /// <remarks/>
    MERC,

    /// <remarks/>
    ACCP,

    /// <remarks/>
    ITAG,

    /// <remarks/>
    ACQR,

    /// <remarks/>
    CISS,

    /// <remarks/>
    TAXH,
  }

  [Serializable]
  public enum CardDataReading1Code
  {
    /// <remarks/>
    TAGC,

    /// <remarks/>
    PHYS,

    /// <remarks/>
    BRCD,

    /// <remarks/>
    MGST,

    /// <remarks/>
    CICC,

    /// <remarks/>
    DFLE,

    /// <remarks/>
    CTLS,

    /// <remarks/>
    ECTL,
  }

  [SerializableAttribute()]
  public enum CardPaymentServiceType2Code
  {

    /// <remarks/>
    AGGR,

    /// <remarks/>
    DCCV,

    /// <remarks/>
    GRTT,

    /// <remarks/>
    INSP,

    /// <remarks/>
    LOYT,

    /// <remarks/>
    NRES,

    /// <remarks/>
    PUCO,

    /// <remarks/>
    RECP,

    /// <remarks/>
    SOAF,

    /// <remarks/>
    UNAF,

    /// <remarks/>
    VCAU,
  }

  [Serializable]
  public enum CardholderVerificationCapability1Code
  {
    /// <remarks/>
    MNSG,

    /// <remarks/>
    NPIN,

    /// <remarks/>
    FCPN,

    /// <remarks/>
    FEPN,

    /// <remarks/>
    FDSG,

    /// <remarks/>
    FBIO,

    /// <remarks/>
    MNVR,

    /// <remarks/>
    FBIG,

    /// <remarks/>
    APKI,

    /// <remarks/>
    PKIS,

    /// <remarks/>
    CHDT,

    /// <remarks/>
    SCEC,
  }

  [Serializable]
  public enum OnLineCapability1Code
  {
    /// <remarks/>
    OFLN,

    /// <remarks/>
    ONLN,

    /// <remarks/>
    SMON,
  }

  [Serializable]
  public enum UserInterface2Code
  {
    /// <remarks/>
    MDSP,

    /// <remarks/>
    CDSP,
  }

  [Serializable]
  public enum POIComponentType1Code
  {
    /// <remarks/>
    SOFT,

    /// <remarks/>
    EMVK,

    /// <remarks/>
    EMVO,

    /// <remarks/>
    MRIT,

    /// <remarks/>
    CHIT,

    /// <remarks/>
    SECM,

    /// <remarks/>
    PEDV,
  }

 
  [Serializable]
  public enum CSCManagement1Code
  {
    /// <remarks/>
    PRST,

    /// <remarks/>
    BYPS,

    /// <remarks/>
    UNRD,

    /// <remarks/>
    NCSC,
  }


  [SerializableAttribute()]
  public enum NamePrefix1Code
  {

    /// <remarks/>
    DOCT,

    /// <remarks/>
    MIST,

    /// <remarks/>
    MISS,

    /// <remarks/>
    MADM,
  }

}