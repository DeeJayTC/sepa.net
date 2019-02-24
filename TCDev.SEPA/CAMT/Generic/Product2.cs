// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Product2.cs
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
using System.Xml.Serialization;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT.Generic
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class Product2
  {

    private string pdctCdField;

    private UnitOfMeasure1Code? unitOfMeasrField;

    private decimal? pdctQtyField;

    private decimal? unitPricField;

    private decimal? pdctAmtField;

    private string taxTpField;

    private string addtlPdctInfField;

    public string PdctCd
    {
      get
      {
        return this.pdctCdField;
      }
      set
      {
        this.pdctCdField = value;
      }
    }

    public UnitOfMeasure1Code UnitOfMeasr
    {
      get
      {
        if (this.unitOfMeasrField.HasValue)
        {
          return this.unitOfMeasrField.Value;
        }
        else
        {
          return default(UnitOfMeasure1Code);
        }
      }
      set
      {
        this.unitOfMeasrField = value;
      }
    }

    [XmlIgnore()]
    public bool UnitOfMeasrSpecified
    {
      get
      {
        return this.unitOfMeasrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.unitOfMeasrField = null;
        }
      }
    }

    public decimal PdctQty
    {
      get
      {
        if (this.pdctQtyField.HasValue)
        {
          return this.pdctQtyField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.pdctQtyField = value;
      }
    }

    [XmlIgnore()]
    public bool PdctQtySpecified
    {
      get
      {
        return this.pdctQtyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.pdctQtyField = null;
        }
      }
    }

    public decimal UnitPric
    {
      get
      {
        if (this.unitPricField.HasValue)
        {
          return this.unitPricField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.unitPricField = value;
      }
    }

    [XmlIgnore()]
    public bool UnitPricSpecified
    {
      get
      {
        return this.unitPricField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.unitPricField = null;
        }
      }
    }

    public decimal PdctAmt
    {
      get
      {
        if (this.pdctAmtField.HasValue)
        {
          return this.pdctAmtField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.pdctAmtField = value;
      }
    }

    [XmlIgnore()]
    public bool PdctAmtSpecified
    {
      get
      {
        return this.pdctAmtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.pdctAmtField = null;
        }
      }
    }

    public string TaxTp
    {
      get
      {
        return this.taxTpField;
      }
      set
      {
        this.taxTpField = value;
      }
    }

    public string AddtlPdctInf
    {
      get
      {
        return this.addtlPdctInfField;
      }
      set
      {
        this.addtlPdctInfField = value;
      }
    }
  }
}