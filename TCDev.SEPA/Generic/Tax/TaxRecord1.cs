using System;
using System.ComponentModel;

namespace TCDev.SEPA.Generic.Tax
{
  [Serializable]
  [DesignerCategory("code")]
  public class TaxRecord1
  {
    private string addtlInfField;
    private string certIdField;
    private string ctgyDtlsField;
    private string ctgyField;

    private string dbtrStsField;

    private string frmsCdField;

    private TaxPeriod1 prdField;

    private TaxAmount1 taxAmtField;
    private string tpField;

    public TaxRecord1()
    {
      taxAmtField = new TaxAmount1();
      prdField = new TaxPeriod1();
    }

    public string Tp
    {
      get { return tpField; }
      set { tpField = value; }
    }

    public string Ctgy
    {
      get { return ctgyField; }
      set { ctgyField = value; }
    }

    public string CtgyDtls
    {
      get { return ctgyDtlsField; }
      set { ctgyDtlsField = value; }
    }

    public string DbtrSts
    {
      get { return dbtrStsField; }
      set { dbtrStsField = value; }
    }

    public string CertId
    {
      get { return certIdField; }
      set { certIdField = value; }
    }

    public string FrmsCd
    {
      get { return frmsCdField; }
      set { frmsCdField = value; }
    }

    public TaxPeriod1 Prd
    {
      get { return prdField; }
      set { prdField = value; }
    }

    public TaxAmount1 TaxAmt
    {
      get { return taxAmtField; }
      set { taxAmtField = value; }
    }

    public string AddtlInf
    {
      get { return addtlInfField; }
      set { addtlInfField = value; }
    }
  }
}