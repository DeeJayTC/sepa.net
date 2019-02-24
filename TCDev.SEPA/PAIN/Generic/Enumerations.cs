using System;
using System.Text;
// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Enumerations.cs
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
using System.Xml.Serialization;

namespace TCDev.SEPA.PAIN.Generic
{
  [System.SerializableAttribute()]
  public enum Frequency6Code
  {

    /// <remarks/>
    YEAR,

    /// <remarks/>
    MNTH,

    /// <remarks/>
    QURT,

    /// <remarks/>
    MIAN,

    /// <remarks/>
    WEEK,

    /// <remarks/>
    DAIL,

    /// <remarks/>
    ADHO,

    /// <remarks/>
    INDA,

    /// <remarks/>
    FRTN,
  }

  [System.SerializableAttribute()]
  public enum Priority2Code
  {

    /// <remarks/>
    HIGH,

    /// <remarks/>
    NORM,
  }

  [System.SerializableAttribute()]
  public enum SequenceType3Code
  {

    /// <remarks/>
    FRST,

    /// <remarks/>
    RCUR,

    /// <remarks/>
    FNAL,

    /// <remarks/>
    OOFF,

    /// <remarks/>
    RPRE,
  }

  [System.SerializableAttribute()]
  public enum ChargeBearerType1Code
  {

    /// <remarks/>
    DEBT,

    /// <remarks/>
    CRED,

    /// <remarks/>
    SHAR,

    /// <remarks/>
    SLEV,
  }
  [System.SerializableAttribute()]
  public enum PaymentMethod2Code
  {

    /// <remarks/>
    DD,
  }
  [Serializable]
  [XmlType(TypeName = "Authorisation1Code")]
  [XmlRoot("Authorisation1Code")]
  public enum Authorisation1Code
  {
    AUTH,

    FDET,

    FSUM,

    ILEV,
  }
}