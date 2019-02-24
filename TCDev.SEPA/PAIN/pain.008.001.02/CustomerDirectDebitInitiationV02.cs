// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CustomerDirectDebitInitiationV02.cs
// Author: Tim Cadenbach, TCDev    
// Created: 20.11.2013 -  TCA
// Changed: 06.12.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================


using System.Collections.Generic;
using System.IO;
using TCDev.SEPA.PAIN;
using TCDev.SEPA.PAIN.Generic;
using ChargeBearerType1Code = TCDev.SEPA.PAIN.Generic.ChargeBearerType1Code;
using PaymentMethod2Code = TCDev.SEPA.PAIN.Generic.PaymentMethod2Code;
using Priority2Code = TCDev.SEPA.PAIN.Generic.Priority2Code;

namespace TCDev.SEPA.PAIN
{
  using System;
  using System.Diagnostics;
  using System.Xml.Serialization;
  using System.Collections;
  using System.Xml.Schema;
  using System.ComponentModel;
  using System.IO;
  using System.Text;
  using System.Collections.Generic;

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  [XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02", IsNullable = false)]
  public class pain_008_001_02
  {

    private CustomerDirectDebitInitiationV02 cstmrDrctDbtInitnField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public pain_008_001_02()
    {
      this.cstmrDrctDbtInitnField = new CustomerDirectDebitInitiationV02();
    }

    public CustomerDirectDebitInitiationV02 CstmrDrctDbtInitn
    {
      get
      {
        return this.cstmrDrctDbtInitnField;
      }
      set
      {
        this.cstmrDrctDbtInitnField = value;
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class CustomerDirectDebitInitiationV02
  {

    private GroupHeader39 grpHdrField;

    private List<PaymentInstructionInformation4> pmtInfField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public CustomerDirectDebitInitiationV02()
    {
      this.pmtInfField = new List<PaymentInstructionInformation4>();
      this.grpHdrField = new GroupHeader39();
    }

    public GroupHeader39 GrpHdr
    {
      get
      {
        return this.grpHdrField;
      }
      set
      {
        this.grpHdrField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("PmtInf")]
    public List<PaymentInstructionInformation4> PmtInf
    {
      get
      {
        return this.pmtInfField;
      }
      set
      {
        this.pmtInfField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(CustomerDirectDebitInitiationV02));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CustomerDirectDebitInitiationV02 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an CustomerDirectDebitInitiationV02 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CustomerDirectDebitInitiationV02 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CustomerDirectDebitInitiationV02 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CustomerDirectDebitInitiationV02);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out CustomerDirectDebitInitiationV02 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CustomerDirectDebitInitiationV02 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CustomerDirectDebitInitiationV02)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CustomerDirectDebitInitiationV02 Deserialize(System.IO.Stream s)
    {
      return ((CustomerDirectDebitInitiationV02)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CustomerDirectDebitInitiationV02 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an CustomerDirectDebitInitiationV02 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CustomerDirectDebitInitiationV02 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CustomerDirectDebitInitiationV02 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CustomerDirectDebitInitiationV02);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out CustomerDirectDebitInitiationV02 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CustomerDirectDebitInitiationV02 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class GroupHeader39
  {

    private string msgIdField;

    private System.DateTime creDtTmField;

    private List<Authorisation1Choice> authstnField;

    private string nbOfTxsField;

    private System.Nullable<decimal> ctrlSumField;

    private PartyIdentification32 initgPtyField;

    private BranchAndFinancialInstitutionIdentification4 fwdgAgtField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public GroupHeader39()
    {
      this.fwdgAgtField = new BranchAndFinancialInstitutionIdentification4();
      this.initgPtyField = new PartyIdentification32();
      this.authstnField = new List<Authorisation1Choice>();
    }

    public string MsgId
    {
      get
      {
        return this.msgIdField;
      }
      set
      {
        this.msgIdField = value;
      }
    }

    public System.DateTime CreDtTm
    {
      get
      {
        return this.creDtTmField;
      }
      set
      {
        this.creDtTmField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Authstn")]
    public List<Authorisation1Choice> Authstn
    {
      get
      {
        return this.authstnField;
      }
      set
      {
        this.authstnField = value;
      }
    }

    public string NbOfTxs
    {
      get
      {
        return this.nbOfTxsField;
      }
      set
      {
        this.nbOfTxsField = value;
      }
    }

    public decimal CtrlSum
    {
      get
      {
        if (this.ctrlSumField.HasValue)
        {
          return this.ctrlSumField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.ctrlSumField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CtrlSumSpecified
    {
      get
      {
        return this.ctrlSumField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.ctrlSumField = null;
        }
      }
    }

    public PartyIdentification32 InitgPty
    {
      get
      {
        return this.initgPtyField;
      }
      set
      {
        this.initgPtyField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification4 FwdgAgt
    {
      get
      {
        return this.fwdgAgtField;
      }
      set
      {
        this.fwdgAgtField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(GroupHeader39));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current GroupHeader39 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an GroupHeader39 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output GroupHeader39 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out GroupHeader39 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GroupHeader39);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out GroupHeader39 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static GroupHeader39 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((GroupHeader39)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static GroupHeader39 Deserialize(System.IO.Stream s)
    {
      return ((GroupHeader39)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current GroupHeader39 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an GroupHeader39 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output GroupHeader39 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out GroupHeader39 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GroupHeader39);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out GroupHeader39 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static GroupHeader39 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class Authorisation1Choice
  {

    private object itemField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(Authorisation1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(Authorisation1Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current Authorisation1Choice object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an Authorisation1Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output Authorisation1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out Authorisation1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Authorisation1Choice);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out Authorisation1Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static Authorisation1Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((Authorisation1Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static Authorisation1Choice Deserialize(System.IO.Stream s)
    {
      return ((Authorisation1Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current Authorisation1Choice object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an Authorisation1Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output Authorisation1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out Authorisation1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Authorisation1Choice);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out Authorisation1Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static Authorisation1Choice LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class RemittanceAmount1
  {

    private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

    private ActiveOrHistoricCurrencyAndAmount dscntApldAmtField;

    private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

    private ActiveOrHistoricCurrencyAndAmount taxAmtField;

    private List<DocumentAdjustment1> adjstmntAmtAndRsnField;

    private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public RemittanceAmount1()
    {
      this.rmtdAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.adjstmntAmtAndRsnField = new List<DocumentAdjustment1>();
      this.taxAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.cdtNoteAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.dscntApldAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.duePyblAmtField = new ActiveOrHistoricCurrencyAndAmount();
    }

    public ActiveOrHistoricCurrencyAndAmount DuePyblAmt
    {
      get
      {
        return this.duePyblAmtField;
      }
      set
      {
        this.duePyblAmtField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount DscntApldAmt
    {
      get
      {
        return this.dscntApldAmtField;
      }
      set
      {
        this.dscntApldAmtField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt
    {
      get
      {
        return this.cdtNoteAmtField;
      }
      set
      {
        this.cdtNoteAmtField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount TaxAmt
    {
      get
      {
        return this.taxAmtField;
      }
      set
      {
        this.taxAmtField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
    public List<DocumentAdjustment1> AdjstmntAmtAndRsn
    {
      get
      {
        return this.adjstmntAmtAndRsnField;
      }
      set
      {
        this.adjstmntAmtAndRsnField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount RmtdAmt
    {
      get
      {
        return this.rmtdAmtField;
      }
      set
      {
        this.rmtdAmtField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(RemittanceAmount1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current RemittanceAmount1 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an RemittanceAmount1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output RemittanceAmount1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out RemittanceAmount1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceAmount1);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out RemittanceAmount1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static RemittanceAmount1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((RemittanceAmount1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static RemittanceAmount1 Deserialize(System.IO.Stream s)
    {
      return ((RemittanceAmount1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current RemittanceAmount1 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an RemittanceAmount1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output RemittanceAmount1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out RemittanceAmount1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceAmount1);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out RemittanceAmount1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static RemittanceAmount1 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
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


  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class StructuredRemittanceInformation7
  {

    private List<ReferredDocumentInformation3> rfrdDocInfField;

    private RemittanceAmount1 rfrdDocAmtField;

    private CreditorReferenceInformation2 cdtrRefInfField;

    private PartyIdentification32 invcrField;

    private PartyIdentification32 invceeField;

    private List<string> addtlRmtInfField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public StructuredRemittanceInformation7()
    {
      this.addtlRmtInfField = new List<string>();
      this.invceeField = new PartyIdentification32();
      this.invcrField = new PartyIdentification32();
      this.cdtrRefInfField = new CreditorReferenceInformation2();
      this.rfrdDocAmtField = new RemittanceAmount1();
      this.rfrdDocInfField = new List<ReferredDocumentInformation3>();
    }

    [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
    public List<ReferredDocumentInformation3> RfrdDocInf
    {
      get
      {
        return this.rfrdDocInfField;
      }
      set
      {
        this.rfrdDocInfField = value;
      }
    }

    public RemittanceAmount1 RfrdDocAmt
    {
      get
      {
        return this.rfrdDocAmtField;
      }
      set
      {
        this.rfrdDocAmtField = value;
      }
    }

    public CreditorReferenceInformation2 CdtrRefInf
    {
      get
      {
        return this.cdtrRefInfField;
      }
      set
      {
        this.cdtrRefInfField = value;
      }
    }

    public PartyIdentification32 Invcr
    {
      get
      {
        return this.invcrField;
      }
      set
      {
        this.invcrField = value;
      }
    }

    public PartyIdentification32 Invcee
    {
      get
      {
        return this.invceeField;
      }
      set
      {
        this.invceeField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
    public List<string> AddtlRmtInf
    {
      get
      {
        return this.addtlRmtInfField;
      }
      set
      {
        this.addtlRmtInfField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(StructuredRemittanceInformation7));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current StructuredRemittanceInformation7 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an StructuredRemittanceInformation7 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output StructuredRemittanceInformation7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out StructuredRemittanceInformation7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(StructuredRemittanceInformation7);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out StructuredRemittanceInformation7 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static StructuredRemittanceInformation7 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((StructuredRemittanceInformation7)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static StructuredRemittanceInformation7 Deserialize(System.IO.Stream s)
    {
      return ((StructuredRemittanceInformation7)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current StructuredRemittanceInformation7 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an StructuredRemittanceInformation7 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output StructuredRemittanceInformation7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out StructuredRemittanceInformation7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(StructuredRemittanceInformation7);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out StructuredRemittanceInformation7 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static StructuredRemittanceInformation7 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class PartyIdentification32
  {

    private string nmField;

    private PostalAddress6 pstlAdrField;

    private Party6Choice idField;

    private string ctryOfResField;

    private ContactDetails2 ctctDtlsField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public PartyIdentification32()
    {
      this.ctctDtlsField = new ContactDetails2();
      this.idField = new Party6Choice();
      this.pstlAdrField = new PostalAddress6();
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

    public PostalAddress6 PstlAdr
    {
      get
      {
        return this.pstlAdrField;
      }
      set
      {
        this.pstlAdrField = value;
      }
    }

    public Party6Choice Id
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

    public string CtryOfRes
    {
      get
      {
        return this.ctryOfResField;
      }
      set
      {
        this.ctryOfResField = value;
      }
    }

    public ContactDetails2 CtctDtls
    {
      get
      {
        return this.ctctDtlsField;
      }
      set
      {
        this.ctctDtlsField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(PartyIdentification32));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PartyIdentification32 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an PartyIdentification32 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PartyIdentification32 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PartyIdentification32 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PartyIdentification32);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out PartyIdentification32 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PartyIdentification32 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PartyIdentification32)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PartyIdentification32 Deserialize(System.IO.Stream s)
    {
      return ((PartyIdentification32)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PartyIdentification32 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an PartyIdentification32 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PartyIdentification32 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PartyIdentification32 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PartyIdentification32);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out PartyIdentification32 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PartyIdentification32 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class PostalAddress6
  {

    private System.Nullable<AddressType2Code> adrTpField;

    private string deptField;

    private string subDeptField;

    private string strtNmField;

    private string bldgNbField;

    private string pstCdField;

    private string twnNmField;

    private string ctrySubDvsnField;

    private string ctryField;

    private List<string> adrLineField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public PostalAddress6()
    {
      this.adrLineField = new List<string>();
    }

    public AddressType2Code AdrTp
    {
      get
      {
        if (this.adrTpField.HasValue)
        {
          return this.adrTpField.Value;
        }
        else
        {
          return default(AddressType2Code);
        }
      }
      set
      {
        this.adrTpField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdrTpSpecified
    {
      get
      {
        return this.adrTpField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.adrTpField = null;
        }
      }
    }

    public string Dept
    {
      get
      {
        return this.deptField;
      }
      set
      {
        this.deptField = value;
      }
    }

    public string SubDept
    {
      get
      {
        return this.subDeptField;
      }
      set
      {
        this.subDeptField = value;
      }
    }

    public string StrtNm
    {
      get
      {
        return this.strtNmField;
      }
      set
      {
        this.strtNmField = value;
      }
    }

    public string BldgNb
    {
      get
      {
        return this.bldgNbField;
      }
      set
      {
        this.bldgNbField = value;
      }
    }

    public string PstCd
    {
      get
      {
        return this.pstCdField;
      }
      set
      {
        this.pstCdField = value;
      }
    }

    public string TwnNm
    {
      get
      {
        return this.twnNmField;
      }
      set
      {
        this.twnNmField = value;
      }
    }

    public string CtrySubDvsn
    {
      get
      {
        return this.ctrySubDvsnField;
      }
      set
      {
        this.ctrySubDvsnField = value;
      }
    }

    public string Ctry
    {
      get
      {
        return this.ctryField;
      }
      set
      {
        this.ctryField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
    public List<string> AdrLine
    {
      get
      {
        return this.adrLineField;
      }
      set
      {
        this.adrLineField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(PostalAddress6));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PostalAddress6 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an PostalAddress6 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PostalAddress6 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PostalAddress6 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PostalAddress6);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out PostalAddress6 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PostalAddress6 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PostalAddress6)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PostalAddress6 Deserialize(System.IO.Stream s)
    {
      return ((PostalAddress6)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PostalAddress6 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an PostalAddress6 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PostalAddress6 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PostalAddress6 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PostalAddress6);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out PostalAddress6 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PostalAddress6 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class Party6Choice
  {

    private object itemField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification4))]
    [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification5))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(Party6Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current Party6Choice object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an Party6Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output Party6Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out Party6Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Party6Choice);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out Party6Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static Party6Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((Party6Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static Party6Choice Deserialize(System.IO.Stream s)
    {
      return ((Party6Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current Party6Choice object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an Party6Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output Party6Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out Party6Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Party6Choice);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out Party6Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static Party6Choice LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class OrganisationIdentification4
  {

    private string bICOrBEIField;

    private List<GenericOrganisationIdentification1> othrField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public OrganisationIdentification4()
    {
      this.othrField = new List<GenericOrganisationIdentification1>();
    }

    public string BICOrBEI
    {
      get
      {
        return this.bICOrBEIField;
      }
      set
      {
        this.bICOrBEIField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Othr")]
    public List<GenericOrganisationIdentification1> Othr
    {
      get
      {
        return this.othrField;
      }
      set
      {
        this.othrField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrganisationIdentification4));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current OrganisationIdentification4 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an OrganisationIdentification4 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output OrganisationIdentification4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out OrganisationIdentification4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(OrganisationIdentification4);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out OrganisationIdentification4 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static OrganisationIdentification4 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((OrganisationIdentification4)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static OrganisationIdentification4 Deserialize(System.IO.Stream s)
    {
      return ((OrganisationIdentification4)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current OrganisationIdentification4 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an OrganisationIdentification4 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output OrganisationIdentification4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out OrganisationIdentification4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(OrganisationIdentification4);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out OrganisationIdentification4 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static OrganisationIdentification4 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class RemittanceInformation5
  {

    private List<string> ustrdField;

    private List<StructuredRemittanceInformation7> strdField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public RemittanceInformation5()
    {
      this.strdField = new List<StructuredRemittanceInformation7>();
      this.ustrdField = new List<string>();
    }

    [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
    public List<string> Ustrd
    {
      get
      {
        return this.ustrdField;
      }
      set
      {
        this.ustrdField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Strd")]
    public List<StructuredRemittanceInformation7> Strd
    {
      get
      {
        return this.strdField;
      }
      set
      {
        this.strdField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(RemittanceInformation5));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current RemittanceInformation5 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an RemittanceInformation5 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output RemittanceInformation5 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out RemittanceInformation5 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceInformation5);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out RemittanceInformation5 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static RemittanceInformation5 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((RemittanceInformation5)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static RemittanceInformation5 Deserialize(System.IO.Stream s)
    {
      return ((RemittanceInformation5)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current RemittanceInformation5 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an RemittanceInformation5 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output RemittanceInformation5 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out RemittanceInformation5 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceInformation5);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out RemittanceInformation5 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static RemittanceInformation5 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public enum TaxRecordPeriod1Code
  {

    /// <remarks/>
    MM01,

    /// <remarks/>
    MM02,

    /// <remarks/>
    MM03,

    /// <remarks/>
    MM04,

    /// <remarks/>
    MM05,

    /// <remarks/>
    MM06,

    /// <remarks/>
    MM07,

    /// <remarks/>
    MM08,

    /// <remarks/>
    MM09,

    /// <remarks/>
    MM10,

    /// <remarks/>
    MM11,

    /// <remarks/>
    MM12,

    /// <remarks/>
    QTR1,

    /// <remarks/>
    QTR2,

    /// <remarks/>
    QTR3,

    /// <remarks/>
    QTR4,

    /// <remarks/>
    HLF1,

    /// <remarks/>
    HLF2,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class TaxInformation3
  {

    private TaxParty1 cdtrField;

    private TaxParty2 dbtrField;

    private string admstnZnField;

    private string refNbField;

    private string mtdField;

    private ActiveOrHistoricCurrencyAndAmount ttlTaxblBaseAmtField;

    private ActiveOrHistoricCurrencyAndAmount ttlTaxAmtField;

    private System.Nullable<System.DateTime> dtField;

    private System.Nullable<decimal> seqNbField;

    private List<TaxRecord1> rcrdField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public TaxInformation3()
    {
      this.rcrdField = new List<TaxRecord1>();
      this.ttlTaxAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.ttlTaxblBaseAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.dbtrField = new TaxParty2();
      this.cdtrField = new TaxParty1();
    }

    public TaxParty1 Cdtr
    {
      get
      {
        return this.cdtrField;
      }
      set
      {
        this.cdtrField = value;
      }
    }

    public TaxParty2 Dbtr
    {
      get
      {
        return this.dbtrField;
      }
      set
      {
        this.dbtrField = value;
      }
    }

    public string AdmstnZn
    {
      get
      {
        return this.admstnZnField;
      }
      set
      {
        this.admstnZnField = value;
      }
    }

    public string RefNb
    {
      get
      {
        return this.refNbField;
      }
      set
      {
        this.refNbField = value;
      }
    }

    public string Mtd
    {
      get
      {
        return this.mtdField;
      }
      set
      {
        this.mtdField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt
    {
      get
      {
        return this.ttlTaxblBaseAmtField;
      }
      set
      {
        this.ttlTaxblBaseAmtField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt
    {
      get
      {
        return this.ttlTaxAmtField;
      }
      set
      {
        this.ttlTaxAmtField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime Dt
    {
      get
      {
        if (this.dtField.HasValue)
        {
          return this.dtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.dtField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DtSpecified
    {
      get
      {
        return this.dtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.dtField = null;
        }
      }
    }

    public decimal SeqNb
    {
      get
      {
        if (this.seqNbField.HasValue)
        {
          return this.seqNbField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.seqNbField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SeqNbSpecified
    {
      get
      {
        return this.seqNbField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.seqNbField = null;
        }
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
    public List<TaxRecord1> Rcrd
    {
      get
      {
        return this.rcrdField;
      }
      set
      {
        this.rcrdField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(TaxInformation3));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current TaxInformation3 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an TaxInformation3 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output TaxInformation3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out TaxInformation3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxInformation3);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out TaxInformation3 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static TaxInformation3 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((TaxInformation3)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static TaxInformation3 Deserialize(System.IO.Stream s)
    {
      return ((TaxInformation3)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current TaxInformation3 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an TaxInformation3 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output TaxInformation3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out TaxInformation3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxInformation3);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out TaxInformation3 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static TaxInformation3 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class AmendmentInformationDetails6
  {

    private string orgnlMndtIdField;

    private PartyIdentification32 orgnlCdtrSchmeIdField;

    private BranchAndFinancialInstitutionIdentification4 orgnlCdtrAgtField;

    private CashAccount16 orgnlCdtrAgtAcctField;

    private PartyIdentification32 orgnlDbtrField;

    private CashAccount16 orgnlDbtrAcctField;

    private BranchAndFinancialInstitutionIdentification4 orgnlDbtrAgtField;

    private CashAccount16 orgnlDbtrAgtAcctField;

    private System.Nullable<System.DateTime> orgnlFnlColltnDtField;

    private System.Nullable<Frequency1Code> orgnlFrqcyField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public AmendmentInformationDetails6()
    {
      this.orgnlDbtrAgtAcctField = new CashAccount16();
      this.orgnlDbtrAgtField = new BranchAndFinancialInstitutionIdentification4();
      this.orgnlDbtrAcctField = new CashAccount16();
      this.orgnlDbtrField = new PartyIdentification32();
      this.orgnlCdtrAgtAcctField = new CashAccount16();
      this.orgnlCdtrAgtField = new BranchAndFinancialInstitutionIdentification4();
      this.orgnlCdtrSchmeIdField = new PartyIdentification32();
    }

    public string OrgnlMndtId
    {
      get
      {
        return this.orgnlMndtIdField;
      }
      set
      {
        this.orgnlMndtIdField = value;
      }
    }

    public PartyIdentification32 OrgnlCdtrSchmeId
    {
      get
      {
        return this.orgnlCdtrSchmeIdField;
      }
      set
      {
        this.orgnlCdtrSchmeIdField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification4 OrgnlCdtrAgt
    {
      get
      {
        return this.orgnlCdtrAgtField;
      }
      set
      {
        this.orgnlCdtrAgtField = value;
      }
    }

    public CashAccount16 OrgnlCdtrAgtAcct
    {
      get
      {
        return this.orgnlCdtrAgtAcctField;
      }
      set
      {
        this.orgnlCdtrAgtAcctField = value;
      }
    }

    public PartyIdentification32 OrgnlDbtr
    {
      get
      {
        return this.orgnlDbtrField;
      }
      set
      {
        this.orgnlDbtrField = value;
      }
    }

    public CashAccount16 OrgnlDbtrAcct
    {
      get
      {
        return this.orgnlDbtrAcctField;
      }
      set
      {
        this.orgnlDbtrAcctField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification4 OrgnlDbtrAgt
    {
      get
      {
        return this.orgnlDbtrAgtField;
      }
      set
      {
        this.orgnlDbtrAgtField = value;
      }
    }

    public CashAccount16 OrgnlDbtrAgtAcct
    {
      get
      {
        return this.orgnlDbtrAgtAcctField;
      }
      set
      {
        this.orgnlDbtrAgtAcctField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OrgnlFnlColltnDt
    {
      get
      {
        if (this.orgnlFnlColltnDtField.HasValue)
        {
          return this.orgnlFnlColltnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.orgnlFnlColltnDtField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OrgnlFnlColltnDtSpecified
    {
      get
      {
        return this.orgnlFnlColltnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.orgnlFnlColltnDtField = null;
        }
      }
    }

    public Frequency1Code OrgnlFrqcy
    {
      get
      {
        if (this.orgnlFrqcyField.HasValue)
        {
          return this.orgnlFrqcyField.Value;
        }
        else
        {
          return default(Frequency1Code);
        }
      }
      set
      {
        this.orgnlFrqcyField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OrgnlFrqcySpecified
    {
      get
      {
        return this.orgnlFrqcyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.orgnlFrqcyField = null;
        }
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(AmendmentInformationDetails6));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AmendmentInformationDetails6 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an AmendmentInformationDetails6 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output AmendmentInformationDetails6 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out AmendmentInformationDetails6 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AmendmentInformationDetails6);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out AmendmentInformationDetails6 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static AmendmentInformationDetails6 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((AmendmentInformationDetails6)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static AmendmentInformationDetails6 Deserialize(System.IO.Stream s)
    {
      return ((AmendmentInformationDetails6)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current AmendmentInformationDetails6 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an AmendmentInformationDetails6 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AmendmentInformationDetails6 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out AmendmentInformationDetails6 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AmendmentInformationDetails6);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out AmendmentInformationDetails6 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static AmendmentInformationDetails6 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class BranchAndFinancialInstitutionIdentification4
  {

    private FinancialInstitutionIdentification7 finInstnIdField;

    private BranchData2 brnchIdField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public BranchAndFinancialInstitutionIdentification4()
    {
      this.brnchIdField = new BranchData2();
      this.finInstnIdField = new FinancialInstitutionIdentification7();
    }

    public FinancialInstitutionIdentification7 FinInstnId
    {
      get
      {
        return this.finInstnIdField;
      }
      set
      {
        this.finInstnIdField = value;
      }
    }

    public BranchData2 BrnchId
    {
      get
      {
        return this.brnchIdField;
      }
      set
      {
        this.brnchIdField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(BranchAndFinancialInstitutionIdentification4));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current BranchAndFinancialInstitutionIdentification4 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an BranchAndFinancialInstitutionIdentification4 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output BranchAndFinancialInstitutionIdentification4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out BranchAndFinancialInstitutionIdentification4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(BranchAndFinancialInstitutionIdentification4);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out BranchAndFinancialInstitutionIdentification4 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static BranchAndFinancialInstitutionIdentification4 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((BranchAndFinancialInstitutionIdentification4)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static BranchAndFinancialInstitutionIdentification4 Deserialize(System.IO.Stream s)
    {
      return ((BranchAndFinancialInstitutionIdentification4)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current BranchAndFinancialInstitutionIdentification4 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an BranchAndFinancialInstitutionIdentification4 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output BranchAndFinancialInstitutionIdentification4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out BranchAndFinancialInstitutionIdentification4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(BranchAndFinancialInstitutionIdentification4);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out BranchAndFinancialInstitutionIdentification4 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static BranchAndFinancialInstitutionIdentification4 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class FinancialInstitutionIdentification7
  {

    private string bICField;

    private ClearingSystemMemberIdentification2 clrSysMmbIdField;

    private string nmField;

    private PostalAddress6 pstlAdrField;

    private GenericFinancialIdentification1 othrField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public FinancialInstitutionIdentification7()
    {
      this.othrField = new GenericFinancialIdentification1();
      this.pstlAdrField = new PostalAddress6();
      this.clrSysMmbIdField = new ClearingSystemMemberIdentification2();
    }

    public string BIC
    {
      get
      {
        return this.bICField;
      }
      set
      {
        this.bICField = value;
      }
    }

    public ClearingSystemMemberIdentification2 ClrSysMmbId
    {
      get
      {
        return this.clrSysMmbIdField;
      }
      set
      {
        this.clrSysMmbIdField = value;
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

    public PostalAddress6 PstlAdr
    {
      get
      {
        return this.pstlAdrField;
      }
      set
      {
        this.pstlAdrField = value;
      }
    }

    public GenericFinancialIdentification1 Othr
    {
      get
      {
        return this.othrField;
      }
      set
      {
        this.othrField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(FinancialInstitutionIdentification7));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current FinancialInstitutionIdentification7 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an FinancialInstitutionIdentification7 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output FinancialInstitutionIdentification7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out FinancialInstitutionIdentification7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(FinancialInstitutionIdentification7);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out FinancialInstitutionIdentification7 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static FinancialInstitutionIdentification7 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((FinancialInstitutionIdentification7)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static FinancialInstitutionIdentification7 Deserialize(System.IO.Stream s)
    {
      return ((FinancialInstitutionIdentification7)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current FinancialInstitutionIdentification7 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an FinancialInstitutionIdentification7 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output FinancialInstitutionIdentification7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out FinancialInstitutionIdentification7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(FinancialInstitutionIdentification7);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out FinancialInstitutionIdentification7 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static FinancialInstitutionIdentification7 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

}



  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class CashAccount16
  {

    private AccountIdentification4Choice idField;

    private CashAccountType2 tpField;

    private string ccyField;

    private string nmField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public CashAccount16()
    {
      this.tpField = new CashAccountType2();
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

    public CashAccountType2 Tp
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

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(CashAccount16));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CashAccount16 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an CashAccount16 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CashAccount16 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CashAccount16 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CashAccount16);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out CashAccount16 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CashAccount16 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CashAccount16)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CashAccount16 Deserialize(System.IO.Stream s)
    {
      return ((CashAccount16)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CashAccount16 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an CashAccount16 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CashAccount16 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CashAccount16 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CashAccount16);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out CashAccount16 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CashAccount16 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class AccountIdentification4Choice
  {

    private object itemField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    [System.Xml.Serialization.XmlElementAttribute("IBAN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(GenericAccountIdentification1))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(AccountIdentification4Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AccountIdentification4Choice object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an AccountIdentification4Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output AccountIdentification4Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out AccountIdentification4Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AccountIdentification4Choice);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out AccountIdentification4Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static AccountIdentification4Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((AccountIdentification4Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static AccountIdentification4Choice Deserialize(System.IO.Stream s)
    {
      return ((AccountIdentification4Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current AccountIdentification4Choice object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an AccountIdentification4Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AccountIdentification4Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out AccountIdentification4Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AccountIdentification4Choice);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out AccountIdentification4Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static AccountIdentification4Choice LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class GenericAccountIdentification1
  {

    private string idField;

    private AccountSchemeName1Choice schmeNmField;

    private string issrField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public GenericAccountIdentification1()
    {
      this.schmeNmField = new AccountSchemeName1Choice();
    }

    public string Id
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

    public AccountSchemeName1Choice SchmeNm
    {
      get
      {
        return this.schmeNmField;
      }
      set
      {
        this.schmeNmField = value;
      }
    }

    public string Issr
    {
      get
      {
        return this.issrField;
      }
      set
      {
        this.issrField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(GenericAccountIdentification1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current GenericAccountIdentification1 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an GenericAccountIdentification1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output GenericAccountIdentification1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out GenericAccountIdentification1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GenericAccountIdentification1);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out GenericAccountIdentification1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static GenericAccountIdentification1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((GenericAccountIdentification1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static GenericAccountIdentification1 Deserialize(System.IO.Stream s)
    {
      return ((GenericAccountIdentification1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current GenericAccountIdentification1 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an GenericAccountIdentification1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output GenericAccountIdentification1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out GenericAccountIdentification1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GenericAccountIdentification1);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out GenericAccountIdentification1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static GenericAccountIdentification1 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class AccountSchemeName1Choice
  {

    private string itemField;

    private ItemChoiceType7 itemElementNameField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType7 ItemElementName
    {
      get
      {
        return this.itemElementNameField;
      }
      set
      {
        this.itemElementNameField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(AccountSchemeName1Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AccountSchemeName1Choice object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an AccountSchemeName1Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output AccountSchemeName1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out AccountSchemeName1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AccountSchemeName1Choice);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out AccountSchemeName1Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static AccountSchemeName1Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((AccountSchemeName1Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static AccountSchemeName1Choice Deserialize(System.IO.Stream s)
    {
      return ((AccountSchemeName1Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current AccountSchemeName1Choice object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an AccountSchemeName1Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AccountSchemeName1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out AccountSchemeName1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AccountSchemeName1Choice);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out AccountSchemeName1Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static AccountSchemeName1Choice LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02", IncludeInSchema = false)]
  public enum ItemChoiceType7
  {

    /// <remarks/>
    Cd,

    /// <remarks/>
    Prtry,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class CashAccountType2
  {

    private object itemField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CashAccountType4Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(CashAccountType2));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CashAccountType2 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an CashAccountType2 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CashAccountType2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CashAccountType2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CashAccountType2);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out CashAccountType2 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CashAccountType2 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CashAccountType2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CashAccountType2 Deserialize(System.IO.Stream s)
    {
      return ((CashAccountType2)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CashAccountType2 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an CashAccountType2 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CashAccountType2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CashAccountType2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CashAccountType2);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out CashAccountType2 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CashAccountType2 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public enum CashAccountType4Code
  {

    /// <remarks/>
    CASH,

    /// <remarks/>
    CHAR,

    /// <remarks/>
    COMM,

    /// <remarks/>
    TAXE,

    /// <remarks/>
    CISH,

    /// <remarks/>
    TRAS,

    /// <remarks/>
    SACC,

    /// <remarks/>
    CACC,

    /// <remarks/>
    SVGS,

    /// <remarks/>
    ONDP,

    /// <remarks/>
    MGLD,

    /// <remarks/>
    NREX,

    /// <remarks/>
    MOMA,

    /// <remarks/>
    LOAN,

    /// <remarks/>
    SLRY,

    /// <remarks/>
    ODFT,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public enum Frequency1Code
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
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class MandateRelatedInformation6
  {

    private string mndtIdField;

    private System.Nullable<System.DateTime> dtOfSgntrField;

    private System.Nullable<bool> amdmntIndField;

    private AmendmentInformationDetails6 amdmntInfDtlsField;

    private string elctrncSgntrField;

    private System.Nullable<System.DateTime> frstColltnDtField;

    private System.Nullable<System.DateTime> fnlColltnDtField;

    private System.Nullable<Frequency1Code> frqcyField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public MandateRelatedInformation6()
    {
      this.amdmntInfDtlsField = new AmendmentInformationDetails6();
    }

    public string MndtId
    {
      get
      {
        return this.mndtIdField;
      }
      set
      {
        this.mndtIdField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DtOfSgntr
    {
      get
      {
        if (this.dtOfSgntrField.HasValue)
        {
          return this.dtOfSgntrField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.dtOfSgntrField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DtOfSgntrSpecified
    {
      get
      {
        return this.dtOfSgntrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.dtOfSgntrField = null;
        }
      }
    }

    public bool AmdmntInd
    {
      get
      {
        if (this.amdmntIndField.HasValue)
        {
          return this.amdmntIndField.Value;
        }
        else
        {
          return default(bool);
        }
      }
      set
      {
        this.amdmntIndField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AmdmntIndSpecified
    {
      get
      {
        return this.amdmntIndField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.amdmntIndField = null;
        }
      }
    }

    public AmendmentInformationDetails6 AmdmntInfDtls
    {
      get
      {
        return this.amdmntInfDtlsField;
      }
      set
      {
        this.amdmntInfDtlsField = value;
      }
    }

    public string ElctrncSgntr
    {
      get
      {
        return this.elctrncSgntrField;
      }
      set
      {
        this.elctrncSgntrField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FrstColltnDt
    {
      get
      {
        if (this.frstColltnDtField.HasValue)
        {
          return this.frstColltnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.frstColltnDtField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FrstColltnDtSpecified
    {
      get
      {
        return this.frstColltnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.frstColltnDtField = null;
        }
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FnlColltnDt
    {
      get
      {
        if (this.fnlColltnDtField.HasValue)
        {
          return this.fnlColltnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.fnlColltnDtField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FnlColltnDtSpecified
    {
      get
      {
        return this.fnlColltnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.fnlColltnDtField = null;
        }
      }
    }

    public Frequency1Code Frqcy
    {
      get
      {
        if (this.frqcyField.HasValue)
        {
          return this.frqcyField.Value;
        }
        else
        {
          return default(Frequency1Code);
        }
      }
      set
      {
        this.frqcyField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FrqcySpecified
    {
      get
      {
        return this.frqcyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.frqcyField = null;
        }
      }
    }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class DirectDebitTransaction6
  {

    private MandateRelatedInformation6 mndtRltdInfField;

    private PartyIdentification32 cdtrSchmeIdField;

    private string preNtfctnIdField;

    private System.Nullable<System.DateTime> preNtfctnDtField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public DirectDebitTransaction6()
    {
      this.cdtrSchmeIdField = new PartyIdentification32();
      this.mndtRltdInfField = new MandateRelatedInformation6();
    }

    public MandateRelatedInformation6 MndtRltdInf
    {
      get
      {
        return this.mndtRltdInfField;
      }
      set
      {
        this.mndtRltdInfField = value;
      }
    }

    public PartyIdentification32 CdtrSchmeId
    {
      get
      {
        return this.cdtrSchmeIdField;
      }
      set
      {
        this.cdtrSchmeIdField = value;
      }
    }

    public string PreNtfctnId
    {
      get
      {
        return this.preNtfctnIdField;
      }
      set
      {
        this.preNtfctnIdField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PreNtfctnDt
    {
      get
      {
        if (this.preNtfctnDtField.HasValue)
        {
          return this.preNtfctnDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.preNtfctnDtField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PreNtfctnDtSpecified
    {
      get
      {
        return this.preNtfctnDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.preNtfctnDtField = null;
        }
      }
    }

  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class DirectDebitTransactionInformation9
  {

    private PaymentIdentification1 pmtIdField;

    private PaymentTypeInformation20 pmtTpInfField;

    private ActiveOrHistoricCurrencyAndAmount instdAmtField;

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    private DirectDebitTransaction6 drctDbtTxField;

    private PartyIdentification32 ultmtCdtrField;

    private BranchAndFinancialInstitutionIdentification4 dbtrAgtField;

    private CashAccount16 dbtrAgtAcctField;

    private PartyIdentification32 dbtrField;

    private CashAccount16 dbtrAcctField;

    private PartyIdentification32 ultmtDbtrField;

    private string instrForCdtrAgtField;

    private Purpose2Choice purpField;

    private List<RegulatoryReporting3> rgltryRptgField;

    private TaxInformation3 taxField;

    private List<RemittanceLocation2> rltdRmtInfField;

    private RemittanceInformation5 rmtInfField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public DirectDebitTransactionInformation9()
    {
      this.rmtInfField = new RemittanceInformation5();
      this.rltdRmtInfField = new List<RemittanceLocation2>();
      this.taxField = new TaxInformation3();
      this.rgltryRptgField = new List<RegulatoryReporting3>();
      this.purpField = new Purpose2Choice();
      this.ultmtDbtrField = new PartyIdentification32();
      this.dbtrAcctField = new CashAccount16();
      this.dbtrField = new PartyIdentification32();
      this.dbtrAgtAcctField = new CashAccount16();
      this.dbtrAgtField = new BranchAndFinancialInstitutionIdentification4();
      this.ultmtCdtrField = new PartyIdentification32();
      this.drctDbtTxField = new DirectDebitTransaction6();
      this.instdAmtField = new ActiveOrHistoricCurrencyAndAmount();
      this.pmtTpInfField = new PaymentTypeInformation20();
      this.pmtIdField = new PaymentIdentification1();
    }

    public PaymentIdentification1 PmtId
    {
      get
      {
        return this.pmtIdField;
      }
      set
      {
        this.pmtIdField = value;
      }
    }

    public PaymentTypeInformation20 PmtTpInf
    {
      get
      {
        return this.pmtTpInfField;
      }
      set
      {
        this.pmtTpInfField = value;
      }
    }

    public ActiveOrHistoricCurrencyAndAmount InstdAmt
    {
      get
      {
        return this.instdAmtField;
      }
      set
      {
        this.instdAmtField = value;
      }
    }

    public ChargeBearerType1Code ChrgBr
    {
      get
      {
        if (this.chrgBrField.HasValue)
        {
          return this.chrgBrField.Value;
        }
        else
        {
          return default(ChargeBearerType1Code);
        }
      }
      set
      {
        this.chrgBrField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChrgBrSpecified
    {
      get
      {
        return this.chrgBrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.chrgBrField = null;
        }
      }
    }

    public DirectDebitTransaction6 DrctDbtTx
    {
      get
      {
        return this.drctDbtTxField;
      }
      set
      {
        this.drctDbtTxField = value;
      }
    }

    public PartyIdentification32 UltmtCdtr
    {
      get
      {
        return this.ultmtCdtrField;
      }
      set
      {
        this.ultmtCdtrField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification4 DbtrAgt
    {
      get
      {
        return this.dbtrAgtField;
      }
      set
      {
        this.dbtrAgtField = value;
      }
    }

    public CashAccount16 DbtrAgtAcct
    {
      get
      {
        return this.dbtrAgtAcctField;
      }
      set
      {
        this.dbtrAgtAcctField = value;
      }
    }

    public PartyIdentification32 Dbtr
    {
      get
      {
        return this.dbtrField;
      }
      set
      {
        this.dbtrField = value;
      }
    }

    public CashAccount16 DbtrAcct
    {
      get
      {
        return this.dbtrAcctField;
      }
      set
      {
        this.dbtrAcctField = value;
      }
    }

    public PartyIdentification32 UltmtDbtr
    {
      get
      {
        return this.ultmtDbtrField;
      }
      set
      {
        this.ultmtDbtrField = value;
      }
    }

    public string InstrForCdtrAgt
    {
      get
      {
        return this.instrForCdtrAgtField;
      }
      set
      {
        this.instrForCdtrAgtField = value;
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

    [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
    public List<RegulatoryReporting3> RgltryRptg
    {
      get
      {
        return this.rgltryRptgField;
      }
      set
      {
        this.rgltryRptgField = value;
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

    [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
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

    public RemittanceInformation5 RmtInf
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

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(DirectDebitTransactionInformation9));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current DirectDebitTransactionInformation9 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an DirectDebitTransactionInformation9 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output DirectDebitTransactionInformation9 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out DirectDebitTransactionInformation9 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(DirectDebitTransactionInformation9);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out DirectDebitTransactionInformation9 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static DirectDebitTransactionInformation9 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((DirectDebitTransactionInformation9)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static DirectDebitTransactionInformation9 Deserialize(System.IO.Stream s)
    {
      return ((DirectDebitTransactionInformation9)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current DirectDebitTransactionInformation9 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an DirectDebitTransactionInformation9 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output DirectDebitTransactionInformation9 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out DirectDebitTransactionInformation9 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(DirectDebitTransactionInformation9);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out DirectDebitTransactionInformation9 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static DirectDebitTransactionInformation9 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class PaymentTypeInformation20
  {

    private System.Nullable<Priority2Code> instrPrtyField;

    private ServiceLevel8Choice svcLvlField;

    private LocalInstrument2Choice lclInstrmField;

    private System.Nullable<SequenceType1Code> seqTpField;

    private CategoryPurpose1Choice ctgyPurpField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public PaymentTypeInformation20()
    {
      this.ctgyPurpField = new CategoryPurpose1Choice();
      this.lclInstrmField = new LocalInstrument2Choice();
      this.svcLvlField = new ServiceLevel8Choice();
    }

    public Priority2Code InstrPrty
    {
      get
      {
        if (this.instrPrtyField.HasValue)
        {
          return this.instrPrtyField.Value;
        }
        else
        {
          return default(Priority2Code);
        }
      }
      set
      {
        this.instrPrtyField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InstrPrtySpecified
    {
      get
      {
        return this.instrPrtyField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.instrPrtyField = null;
        }
      }
    }

    public ServiceLevel8Choice SvcLvl
    {
      get
      {
        return this.svcLvlField;
      }
      set
      {
        this.svcLvlField = value;
      }
    }

    public LocalInstrument2Choice LclInstrm
    {
      get
      {
        return this.lclInstrmField;
      }
      set
      {
        this.lclInstrmField = value;
      }
    }

    public SequenceType1Code SeqTp
    {
      get
      {
        if (this.seqTpField.HasValue)
        {
          return this.seqTpField.Value;
        }
        else
        {
          return default(SequenceType1Code);
        }
      }
      set
      {
        this.seqTpField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SeqTpSpecified
    {
      get
      {
        return this.seqTpField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.seqTpField = null;
        }
      }
    }

    public CategoryPurpose1Choice CtgyPurp
    {
      get
      {
        return this.ctgyPurpField;
      }
      set
      {
        this.ctgyPurpField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(PaymentTypeInformation20));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PaymentTypeInformation20 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an PaymentTypeInformation20 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PaymentTypeInformation20 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PaymentTypeInformation20 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PaymentTypeInformation20);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out PaymentTypeInformation20 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PaymentTypeInformation20 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PaymentTypeInformation20)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PaymentTypeInformation20 Deserialize(System.IO.Stream s)
    {
      return ((PaymentTypeInformation20)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PaymentTypeInformation20 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an PaymentTypeInformation20 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PaymentTypeInformation20 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PaymentTypeInformation20 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PaymentTypeInformation20);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out PaymentTypeInformation20 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PaymentTypeInformation20 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.02")]
  public partial class PaymentInstructionInformation4
  {

    private string pmtInfIdField;

    private PaymentMethod2Code pmtMtdField;

    private System.Nullable<bool> btchBookgField;

    private string nbOfTxsField;

    private System.Nullable<decimal> ctrlSumField;

    private PaymentTypeInformation20 pmtTpInfField;

    private System.DateTime reqdColltnDtField;

    private PartyIdentification32 cdtrField;

    private CashAccount16 cdtrAcctField;

    private BranchAndFinancialInstitutionIdentification4 cdtrAgtField;

    private CashAccount16 cdtrAgtAcctField;

    private PartyIdentification32 ultmtCdtrField;

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    private CashAccount16 chrgsAcctField;

    private BranchAndFinancialInstitutionIdentification4 chrgsAcctAgtField;

    private PartyIdentification32 cdtrSchmeIdField;

    private List<DirectDebitTransactionInformation9> drctDbtTxInfField;

    private static System.Xml.Serialization.XmlSerializer serializer;

    public PaymentInstructionInformation4()
    {
      this.drctDbtTxInfField = new List<DirectDebitTransactionInformation9>();
      this.cdtrSchmeIdField = new PartyIdentification32();
      this.chrgsAcctAgtField = new BranchAndFinancialInstitutionIdentification4();
      this.chrgsAcctField = new CashAccount16();
      this.ultmtCdtrField = new PartyIdentification32();
      this.cdtrAgtAcctField = new CashAccount16();
      this.cdtrAgtField = new BranchAndFinancialInstitutionIdentification4();
      this.cdtrAcctField = new CashAccount16();
      this.cdtrField = new PartyIdentification32();
      this.pmtTpInfField = new PaymentTypeInformation20();
    }

    public string PmtInfId
    {
      get
      {
        return this.pmtInfIdField;
      }
      set
      {
        this.pmtInfIdField = value;
      }
    }

    public PaymentMethod2Code PmtMtd
    {
      get
      {
        return this.pmtMtdField;
      }
      set
      {
        this.pmtMtdField = value;
      }
    }

    public bool BtchBookg
    {
      get
      {
        if (this.btchBookgField.HasValue)
        {
          return this.btchBookgField.Value;
        }
        else
        {
          return default(bool);
        }
      }
      set
      {
        this.btchBookgField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BtchBookgSpecified
    {
      get
      {
        return this.btchBookgField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.btchBookgField = null;
        }
      }
    }

    public string NbOfTxs
    {
      get
      {
        return this.nbOfTxsField;
      }
      set
      {
        this.nbOfTxsField = value;
      }
    }

    public decimal CtrlSum
    {
      get
      {
        if (this.ctrlSumField.HasValue)
        {
          return this.ctrlSumField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.ctrlSumField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CtrlSumSpecified
    {
      get
      {
        return this.ctrlSumField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.ctrlSumField = null;
        }
      }
    }

    public PaymentTypeInformation20 PmtTpInf
    {
      get
      {
        return this.pmtTpInfField;
      }
      set
      {
        this.pmtTpInfField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ReqdColltnDt
    {
      get
      {
        return this.reqdColltnDtField;
      }
      set
      {
        this.reqdColltnDtField = value;
      }
    }

    public PartyIdentification32 Cdtr
    {
      get
      {
        return this.cdtrField;
      }
      set
      {
        this.cdtrField = value;
      }
    }

    public CashAccount16 CdtrAcct
    {
      get
      {
        return this.cdtrAcctField;
      }
      set
      {
        this.cdtrAcctField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification4 CdtrAgt
    {
      get
      {
        return this.cdtrAgtField;
      }
      set
      {
        this.cdtrAgtField = value;
      }
    }

    public CashAccount16 CdtrAgtAcct
    {
      get
      {
        return this.cdtrAgtAcctField;
      }
      set
      {
        this.cdtrAgtAcctField = value;
      }
    }

    public PartyIdentification32 UltmtCdtr
    {
      get
      {
        return this.ultmtCdtrField;
      }
      set
      {
        this.ultmtCdtrField = value;
      }
    }

    public ChargeBearerType1Code ChrgBr
    {
      get
      {
        if (this.chrgBrField.HasValue)
        {
          return this.chrgBrField.Value;
        }
        else
        {
          return default(ChargeBearerType1Code);
        }
      }
      set
      {
        this.chrgBrField = value;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChrgBrSpecified
    {
      get
      {
        return this.chrgBrField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.chrgBrField = null;
        }
      }
    }

    public CashAccount16 ChrgsAcct
    {
      get
      {
        return this.chrgsAcctField;
      }
      set
      {
        this.chrgsAcctField = value;
      }
    }

    public BranchAndFinancialInstitutionIdentification4 ChrgsAcctAgt
    {
      get
      {
        return this.chrgsAcctAgtField;
      }
      set
      {
        this.chrgsAcctAgtField = value;
      }
    }

    public PartyIdentification32 CdtrSchmeId
    {
      get
      {
        return this.cdtrSchmeIdField;
      }
      set
      {
        this.cdtrSchmeIdField = value;
      }
    }

    [System.Xml.Serialization.XmlElementAttribute("DrctDbtTxInf")]
    public List<DirectDebitTransactionInformation9> DrctDbtTxInf
    {
      get
      {
        return this.drctDbtTxInfField;
      }
      set
      {
        this.drctDbtTxInfField = value;
      }
    }

    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(PaymentInstructionInformation4));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PaymentInstructionInformation4 object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        Serializer.Serialize(memoryStream, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes workflow markup into an PaymentInstructionInformation4 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PaymentInstructionInformation4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PaymentInstructionInformation4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PaymentInstructionInformation4);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out PaymentInstructionInformation4 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PaymentInstructionInformation4 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PaymentInstructionInformation4)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PaymentInstructionInformation4 Deserialize(System.IO.Stream s)
    {
      return ((PaymentInstructionInformation4)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PaymentInstructionInformation4 object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual void SaveToFile(string fileName)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize();
        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an PaymentInstructionInformation4 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PaymentInstructionInformation4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PaymentInstructionInformation4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PaymentInstructionInformation4);
      try
      {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out PaymentInstructionInformation4 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PaymentInstructionInformation4 LoadFromFile(string fileName)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }


