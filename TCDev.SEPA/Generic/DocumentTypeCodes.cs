using System;
using System.Text;

// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.DocumentTypeCodes.cs
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
namespace TCDev.SEPA.Generic
{
  [System.SerializableAttribute()]
  public enum DocumentType3Code
  {

    /// <remarks/>
    RADM,

    /// <remarks/>
    RPIN,

    /// <remarks/>
    FXDR,

    /// <remarks/>
    DISP,

    /// <remarks/>
    PUOR,

    /// <remarks/>
    SCOR,
  }

  [System.SerializableAttribute()]
  public enum DocumentType5Code
  {

    /// <remarks/>
    MSIN,

    /// <remarks/>
    CNFA,

    /// <remarks/>
    DNFA,

    /// <remarks/>
    CINV,

    /// <remarks/>
    CREN,

    /// <remarks/>
    DEBN,

    /// <remarks/>
    HIRI,

    /// <remarks/>
    SBIN,

    /// <remarks/>
    CMCN,

    /// <remarks/>
    SOAC,

    /// <remarks/>
    DISP,

    /// <remarks/>
    BOLD,

    /// <remarks/>
    VCHR,

    /// <remarks/>
    AROI,

    /// <remarks/>
    TSUT,
  }
}