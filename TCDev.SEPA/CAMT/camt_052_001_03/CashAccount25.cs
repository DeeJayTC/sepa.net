using System;
using System.ComponentModel;
using TCDev.SEPA.Generic.Identification;

namespace TCDev.SEPA.CAMT
{
  [Serializable()]
  [DesignerCategory("code")]

  public partial class CashAccount25
  {

    private AccountIdentification4Choice idField;

    private CashAccountType2Choice tpField;

    private string ccyField;

    private string nmField;

    private PartyIdentification43 ownrField;

    private BranchAndFinancialInstitutionIdentification5 svcrField;

    public CashAccount25()
    {
      this.svcrField = new BranchAndFinancialInstitutionIdentification5();
      this.ownrField = new PartyIdentification43();
      this.tpField = new CashAccountType2Choice();
      this.idField = new AccountIdentification4Choice();
    }

    public AccountIdentification4Choice Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    public CashAccountType2Choice Tp
    {
      get
      {
        return this.tpField;
      }
      set
      {
        this.tpField = value;
      }
    }

    public string Ccy
    {
      get
      {
        return this.ccyField;
      }
      set
      {
        this.ccyField = value;
      }
    }

    public string Nm
    {
      get
      {
        return this.nmField;
      }
      set
      {
        this.nmField = value;
      }
    }

    public PartyIdentification43 Ownr
    {
      get
      {
        return this.ownrField;
      }
      set
      {
        this.ownrField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification5 Svcr
    {
      get
      {
        return this.svcrField;
      }
      set
      {
        this.svcrField = value;
      }
    }
  }
}