// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.PostalAddress6.cs
// Author: Tim Cadenbach, TCDev    
// Created: 11.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TCDev.SEPA.Generic.Contact
{
  [Serializable]
  [DesignerCategory("code")]
  public class PostalAddress6
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private List<string> _adrLineField;
    [EditorBrowsable(EditorBrowsableState.Never)] private AddressType2Code? _adrTpField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _bldgNbField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _ctryField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _ctrySubDvsnField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _deptField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _pstCdField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _strtNmField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _subDeptField;
    [EditorBrowsable(EditorBrowsableState.Never)] private string _twnNmField;

    public PostalAddress6()
    {
      _adrLineField = new List<string>();
    }

    [XmlElement("AdrTp")]
    public AddressType2Code AddressType
    {
      get
      {
        if (_adrTpField.HasValue)
        {
          return _adrTpField.Value;
        }
        return default(AddressType2Code);
      }
      set { _adrTpField = value; }
    }

    [XmlIgnore]
    public bool AdrTpSpecified
    {
      get { return _adrTpField.HasValue; }
      set
      {
        if (value == false)
        {
          _adrTpField = null;
        }
      }
    }

    [XmlElement("Dept")]
    public string Department
    {
      get { return _deptField; }
      set { _deptField = value; }
    }

    [XmlElement("SubDept")]
    public string SubDepartment
    {
      get { return _subDeptField; }
      set { _subDeptField = value; }
    }

    [XmlElement("StrtNm")]
    public string Street
    {
      get { return _strtNmField; }
      set { _strtNmField = value; }
    }

    [XmlElement("BldgNb")]
    public string Buildingnumber
    {
      get { return _bldgNbField; }
      set { _bldgNbField = value; }
    }

    [XmlElement("PstCd")]
    public string Postalcode
    {
      get { return _pstCdField; }
      set { _pstCdField = value; }
    }

    [XmlElement("TwnNm")]
    public string TwnNm
    {
      get { return _twnNmField; }
      set { _twnNmField = value; }
    }

    [XmlElement("CtrySubDvsn")]
    public string CountrySubDivision
    {
      get { return _ctrySubDvsnField; }
      set { _ctrySubDvsnField = value; }
    }

    [XmlElement("Ctry")]
    public string Country
    {
      get { return _ctryField; }
      set { _ctryField = value; }
    }

    [XmlElement("AdrLine")]
    public List<string> AddressLine
    {
      get { return _adrLineField; }
      set { _adrLineField = value; }
    }
  }
}