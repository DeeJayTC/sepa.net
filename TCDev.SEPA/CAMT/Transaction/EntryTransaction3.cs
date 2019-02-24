// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.EntryTransaction3.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

using TCDev.SEPA.CAMT.Generic;
using TCDev.SEPA.CAMT.Generic.Card;
using TCDev.SEPA.Generic;
using TCDev.SEPA.Generic.Identification;
using TCDev.SEPA.Generic.Tax;


namespace TCDev.SEPA.CAMT.Transaction
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class EntryTransaction3
  {

    private TransactionReferences3 refsField;

    private ActiveOrHistoricCurrencyAndAmount amtField;

    private CreditDebitCode cdtDbtIndField;

    private AmountAndCurrencyExchange3 amtDtlsField;

    private List<CashBalanceAvailability2> avlbtyField;

    private BankTransactionCodeStructure4 bkTxCdField;

    private List<Charges3> chrgsField;

    private List<TransactionInterest3> intrstField;

    private TransactionParties3 rltdPtiesField;

    private TransactionAgents3 rltdAgtsField;

    private Purpose2Choice purpField;

    private List<RemittanceLocation2> rltdRmtInfField;

    private RemittanceInformation7 rmtInfField;

    private TransactionDates2 rltdDtsField;

    private TransactionPrice3Choice rltdPricField;

    private List<TransactionQuantities2Choice> rltdQtiesField;

    private SecurityIdentification14 finInstrmIdField;

    private TaxInformation3 taxField;

    private PaymentReturnReason2 rtrInfField;

    private CorporateAction9 corpActnField;

    private SecuritiesAccount13 sfkpgAcctField;

    private List<CashDeposit1> cshDpstField;

    private CardTransaction1 cardTxField;

    private string addtlTxInfField;

    public EntryTransaction3()
    {
      this.cardTxField = new CardTransaction1();
      this.cshDpstField = new List<CashDeposit1>();
      this.sfkpgAcctField = new SecuritiesAccount13();
      this.corpActnField = new CorporateAction9();
      this.rtrInfField = new PaymentReturnReason2();
      this.taxField = new TaxInformation3();
      this.finInstrmIdField = new SecurityIdentification14();
      this.rltdQtiesField = new List<TransactionQuantities2Choice>();
      this.rltdPricField = new TransactionPrice3Choice();
      this.rltdDtsField = new TransactionDates2();
      this.rmtInfField = new RemittanceInformation7();
      this.rltdRmtInfField = new List<RemittanceLocation2>();
      this.purpField = new Purpose2Choice();
      this.rltdAgtsField = new TransactionAgents3();
      this.rltdPtiesField = new TransactionParties3();
      this.intrstField = new List<TransactionInterest3>();
      this.chrgsField = new List<Charges3>();
      this.bkTxCdField = new BankTransactionCodeStructure4();
      this.avlbtyField = new List<CashBalanceAvailability2>();
      this.amtDtlsField = new AmountAndCurrencyExchange3();
      this.amtField = new ActiveOrHistoricCurrencyAndAmount();
      this.refsField = new TransactionReferences3();
    }

    public TransactionReferences3 Refs
    {
      get
      {
        return this.refsField;
      }
      set
      {
        this.refsField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount Amt
    {
      get
      {
        return this.amtField;
      }
      set
      {
        this.amtField = value;
      }
    }

    public CreditDebitCode CdtDbtInd
    {
      get
      {
        return this.cdtDbtIndField;
      }
      set
      {
        this.cdtDbtIndField = value;
      }
    }

    public AmountAndCurrencyExchange3 AmtDtls
    {
      get
      {
        return this.amtDtlsField;
      }
      set
      {
        this.amtDtlsField = value;
      }
    }

    [XmlElement("Avlbty")]
    public List<CashBalanceAvailability2> Avlbty
    {
      get
      {
        return this.avlbtyField;
      }
      set
      {
        this.avlbtyField = value;
      }
    }

    public BankTransactionCodeStructure4 BkTxCd
    {
      get
      {
        return this.bkTxCdField;
      }
      set
      {
        this.bkTxCdField = value;
      }
    }

    [XmlElement("Chrgs")]
    public List<Charges3> Chrgs
    {
      get
      {
        return this.chrgsField;
      }
      set
      {
        this.chrgsField = value;
      }
    }

    [XmlElement("Intrst")]
    public List<TransactionInterest3> Intrst
    {
      get
      {
        return this.intrstField;
      }
      set
      {
        this.intrstField = value;
      }
    }

    public TransactionParties3 RltdPties
    {
      get
      {
        return this.rltdPtiesField;
      }
      set
      {
        this.rltdPtiesField = value;
      }
    }

    public TransactionAgents3 RltdAgts
    {
      get
      {
        return this.rltdAgtsField;
      }
      set
      {
        this.rltdAgtsField = value;
      }
    }

    public Purpose2Choice Purp
    {
      get
      {
        return this.purpField;
      }
      set
      {
        this.purpField = value;
      }
    }

    [XmlElement("RltdRmtInf")]
    public List<RemittanceLocation2> RltdRmtInf
    {
      get
      {
        return this.rltdRmtInfField;
      }
      set
      {
        this.rltdRmtInfField = value;
      }
    }

    public RemittanceInformation7 RmtInf
    {
      get
      {
        return this.rmtInfField;
      }
      set
      {
        this.rmtInfField = value;
      }
    }

    public TransactionDates2 RltdDts
    {
      get
      {
        return this.rltdDtsField;
      }
      set
      {
        this.rltdDtsField = value;
      }
    }

    public TransactionPrice3Choice RltdPric
    {
      get
      {
        return this.rltdPricField;
      }
      set
      {
        this.rltdPricField = value;
      }
    }

    [XmlElement("RltdQties")]
    public List<TransactionQuantities2Choice> RltdQties
    {
      get
      {
        return this.rltdQtiesField;
      }
      set
      {
        this.rltdQtiesField = value;
      }
    }

    public SecurityIdentification14 FinInstrmId
    {
      get
      {
        return this.finInstrmIdField;
      }
      set
      {
        this.finInstrmIdField = value;
      }
    }

    public TaxInformation3 Tax
    {
      get
      {
        return this.taxField;
      }
      set
      {
        this.taxField = value;
      }
    }

    public PaymentReturnReason2 RtrInf
    {
      get
      {
        return this.rtrInfField;
      }
      set
      {
        this.rtrInfField = value;
      }
    }

    public CorporateAction9 CorpActn
    {
      get
      {
        return this.corpActnField;
      }
      set
      {
        this.corpActnField = value;
      }
    }

    public SecuritiesAccount13 SfkpgAcct
    {
      get
      {
        return this.sfkpgAcctField;
      }
      set
      {
        this.sfkpgAcctField = value;
      }
    }

    [XmlElement("CshDpst")]
    public List<CashDeposit1> CshDpst
    {
      get
      {
        return this.cshDpstField;
      }
      set
      {
        this.cshDpstField = value;
      }
    }

    public CardTransaction1 CardTx
    {
      get
      {
        return this.cardTxField;
      }
      set
      {
        this.cardTxField = value;
      }
    }

    public string AddtlTxInf
    {
      get
      {
        return this.addtlTxInfField;
      }
      set
      {
        this.addtlTxInfField = value;
      }
    }
  }
}