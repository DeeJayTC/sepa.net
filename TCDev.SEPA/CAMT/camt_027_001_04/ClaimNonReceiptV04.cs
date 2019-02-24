// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.ClaimNonReceiptV04.cs
// Author: Tim Cadenbach, TCDev    
// Created: 10.09.2013 -  TCA
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
using TCDev.SEPA.CAMT.Generic;
using TCDev.SEPA.Generic;

namespace TCDev.SEPA.CAMT
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.04")]
  [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.04", IsNullable = false)]
// ReSharper disable once InconsistentNaming
  public class camt_027_001_04
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private ClaimNonReceiptV04 _clmNonRctField;

    public camt_027_001_04()
    {
      _clmNonRctField = new ClaimNonReceiptV04();
    }

    [XmlElement("ClmNonRct")]
    public ClaimNonReceiptV04 ClaimNonReceiptV04
    {
      get { return _clmNonRctField; }
      set { _clmNonRctField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.04")]
  public class ClaimNonReceiptV04
  {
    [EditorBrowsable(EditorBrowsableState.Never)] private CaseAssignment3 _assgnmtField;
    [EditorBrowsable(EditorBrowsableState.Never)] private Case3 _caseField;
    [EditorBrowsable(EditorBrowsableState.Never)] private MissingCover3 _coverDtlsField;
    [EditorBrowsable(EditorBrowsableState.Never)] private List<SupplementaryData1> _splmtryDataField;
    [EditorBrowsable(EditorBrowsableState.Never)] private UnderlyingTransaction2Choice _undrlygField;

    public ClaimNonReceiptV04()
    {
      _splmtryDataField = new List<SupplementaryData1>();
      _coverDtlsField = new MissingCover3();
      _undrlygField = new UnderlyingTransaction2Choice();
      _caseField = new Case3();
      _assgnmtField = new CaseAssignment3();
    }

    [XmlElement("Assgnmt")]
    public CaseAssignment3 Assignment
    {
      get { return _assgnmtField; }
      set { _assgnmtField = value; }
    }

    public Case3 Case
    {
      get { return _caseField; }
      set { _caseField = value; }
    }

    [XmlElement("Undrlyg")]
    public UnderlyingTransaction2Choice UnderlyingTransaction
    {
      get { return _undrlygField; }
      set { _undrlygField = value; }
    }

    [XmlElement("CoverDtls")]
    public MissingCover3 CoverDtls
    {
      get { return _coverDtlsField; }
      set { _coverDtlsField = value; }
    }

    [XmlElement("SplmtryData")]
    public List<SupplementaryData1> SuplementaryData
    {
      get { return _splmtryDataField; }
      set { _splmtryDataField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.04")]
  public class BranchAndFinancialInstitutionIdentification5
  {
    private BranchData2 brnchIdField;
    private FinancialInstitutionIdentification8 finInstnIdField;

    public BranchAndFinancialInstitutionIdentification5()
    {
      brnchIdField = new BranchData2();
      finInstnIdField = new FinancialInstitutionIdentification8();
    }

    public FinancialInstitutionIdentification8 FinInstnId
    {
      get { return finInstnIdField; }
      set { finInstnIdField = value; }
    }

    public BranchData2 BrnchId
    {
      get { return brnchIdField; }
      set { brnchIdField = value; }
    }
  }


 
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.04")]
  public class SettlementInstruction3
  {
    private CashAccount24 instdRmbrsmntAgtAcctField;
    private BranchAndFinancialInstitutionIdentification5 instdRmbrsmntAgtField;
    private CashAccount24 instgRmbrsmntAgtAcctField;
    private BranchAndFinancialInstitutionIdentification5 instgRmbrsmntAgtField;

    public SettlementInstruction3()
    {
      instdRmbrsmntAgtAcctField = new CashAccount24();
      instdRmbrsmntAgtField = new BranchAndFinancialInstitutionIdentification5();
      instgRmbrsmntAgtAcctField = new CashAccount24();
      instgRmbrsmntAgtField = new BranchAndFinancialInstitutionIdentification5();
    }

    public BranchAndFinancialInstitutionIdentification5 InstgRmbrsmntAgt
    {
      get { return instgRmbrsmntAgtField; }
      set { instgRmbrsmntAgtField = value; }
    }

    public CashAccount24 InstgRmbrsmntAgtAcct
    {
      get { return instgRmbrsmntAgtAcctField; }
      set { instgRmbrsmntAgtAcctField = value; }
    }

    public BranchAndFinancialInstitutionIdentification5 InstdRmbrsmntAgt
    {
      get { return instdRmbrsmntAgtField; }
      set { instdRmbrsmntAgtField = value; }
    }

    public CashAccount24 InstdRmbrsmntAgtAcct
    {
      get { return instdRmbrsmntAgtAcctField; }
      set { instdRmbrsmntAgtAcctField = value; }
    }
  }

  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.04")]
  public class MissingCover3
  {
    private SettlementInstruction3 coverCrrctnField;
    private bool mssngCoverIndField;

    public MissingCover3()
    {
      coverCrrctnField = new SettlementInstruction3();
    }

    public bool MssngCoverInd
    {
      get { return mssngCoverIndField; }
      set { mssngCoverIndField = value; }
    }

    public SettlementInstruction3 CoverCrrctn
    {
      get { return coverCrrctnField; }
      set { coverCrrctnField = value; }
    }
  }
}