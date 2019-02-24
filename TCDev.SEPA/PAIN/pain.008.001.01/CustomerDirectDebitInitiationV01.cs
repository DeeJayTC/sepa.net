// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CustomerDirectDebitInitiationV01.cs
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

using TCDev.SEPA.PAIN.Generic;

namespace TCDev.SEPA.PAIN
{
  using System;
  using System.Xml.Serialization;
  using System.ComponentModel;
  using System.IO;
  using System.Collections.Generic;


  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  [XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IsNullable = false)]
  public class pain_008_001_01
  {

    private pain00800101 pain00800101Field;

    private static XmlSerializer serializer;

    public pain_008_001_01()
    {
      this.pain00800101Field = new pain00800101();
    }

    [XmlElementAttribute("pain.008.001.01")]
    public pain00800101 CustomerDirectDebitInitiationV01
    {
      get
      {
        return this.pain00800101Field;
      }
      set
      {
        this.pain00800101Field = value;
      }
    }

  }

  [SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(TypeName = "pain.008.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public class pain00800101
  {

    private GroupHeader1 grpHdrField;

    private List<PaymentInstructionInformation2> pmtInfField;

    private static XmlSerializer serializer;

    public pain00800101()
    {
      this.pmtInfField = new List<PaymentInstructionInformation2>();
      this.grpHdrField = new GroupHeader1();
    }

    public GroupHeader1 GrpHdr
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

    [XmlElementAttribute("PmtInf")]
    public List<PaymentInstructionInformation2> PaymentInformation
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
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class GroupHeader1
  {

    private string msgIdField;

    private System.DateTime creDtTmField;

    private List<string> authstnField;

    private System.Nullable<bool> btchBookgField;

    private string nbOfTxsField;

    private System.Nullable<decimal> ctrlSumField;

    private Grouping1Code grpgField;

    private PartyIdentification8 initgPtyField;

    private BranchAndFinancialInstitutionIdentification3 fwdgAgtField;

    private static XmlSerializer serializer;

    public GroupHeader1()
    {
      this.fwdgAgtField = new BranchAndFinancialInstitutionIdentification3();
      this.initgPtyField = new PartyIdentification8();
      this.authstnField = new List<string>();
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

    [XmlElementAttribute("Authstn")]
    public List<string> Authstn
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

    [XmlIgnoreAttribute()]
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

    [XmlIgnoreAttribute()]
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

    public Grouping1Code Grpg
    {
      get
      {
        return this.grpgField;
      }
      set
      {
        this.grpgField = value;
      }
    }

    public PartyIdentification8 InitgPty
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

    public BranchAndFinancialInstitutionIdentification3 FwdgAgt
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(GroupHeader1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current GroupHeader1 object into an XML document
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
    /// Deserializes workflow markup into an GroupHeader1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output GroupHeader1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out GroupHeader1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GroupHeader1);
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

    public static bool Deserialize(string xml, out GroupHeader1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static GroupHeader1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((GroupHeader1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static GroupHeader1 Deserialize(System.IO.Stream s)
    {
      return ((GroupHeader1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current GroupHeader1 object into file
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
    /// Deserializes xml markup from file into an GroupHeader1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output GroupHeader1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out GroupHeader1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GroupHeader1);
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

    public static bool LoadFromFile(string fileName, out GroupHeader1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static GroupHeader1 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum Grouping1Code
  {

    /// <remarks/>
    SNGL,

    /// <remarks/>
    GRPD,

    /// <remarks/>
    MIXD,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class PartyIdentification8
  {

    private string nmField;

    private PostalAddress1 pstlAdrField;

    private Party2Choice idField;

    private string ctryOfResField;

    private static XmlSerializer serializer;

    public PartyIdentification8()
    {
      this.idField = new Party2Choice();
      this.pstlAdrField = new PostalAddress1();
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

    public PostalAddress1 PstlAdr
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

    public Party2Choice Id
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(PartyIdentification8));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PartyIdentification8 object into an XML document
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
    /// Deserializes workflow markup into an PartyIdentification8 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PartyIdentification8 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PartyIdentification8 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PartyIdentification8);
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

    public static bool Deserialize(string xml, out PartyIdentification8 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PartyIdentification8 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PartyIdentification8)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PartyIdentification8 Deserialize(System.IO.Stream s)
    {
      return ((PartyIdentification8)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PartyIdentification8 object into file
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
    /// Deserializes xml markup from file into an PartyIdentification8 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PartyIdentification8 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PartyIdentification8 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PartyIdentification8);
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

    public static bool LoadFromFile(string fileName, out PartyIdentification8 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PartyIdentification8 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class PostalAddress1
  {

    private System.Nullable<AddressType2Code> adrTpField;

    private List<string> adrLineField;

    private string strtNmField;

    private string bldgNbField;

    private string pstCdField;

    private string twnNmField;

    private string ctrySubDvsnField;

    private string ctryField;

    private static XmlSerializer serializer;

    public PostalAddress1()
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

    [XmlIgnoreAttribute()]
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

    [XmlElementAttribute("AdrLine")]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(PostalAddress1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PostalAddress1 object into an XML document
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
    /// Deserializes workflow markup into an PostalAddress1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PostalAddress1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PostalAddress1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PostalAddress1);
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

    public static bool Deserialize(string xml, out PostalAddress1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PostalAddress1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PostalAddress1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PostalAddress1 Deserialize(System.IO.Stream s)
    {
      return ((PostalAddress1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PostalAddress1 object into file
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
    /// Deserializes xml markup from file into an PostalAddress1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PostalAddress1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PostalAddress1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PostalAddress1);
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

    public static bool LoadFromFile(string fileName, out PostalAddress1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PostalAddress1 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
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

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class CreditorReferenceType1
  {

    private object itemField;

    private string issrField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Cd", typeof(DocumentType3Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(CreditorReferenceType1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CreditorReferenceType1 object into an XML document
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
    /// Deserializes workflow markup into an CreditorReferenceType1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CreditorReferenceType1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CreditorReferenceType1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CreditorReferenceType1);
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

    public static bool Deserialize(string xml, out CreditorReferenceType1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CreditorReferenceType1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CreditorReferenceType1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CreditorReferenceType1 Deserialize(System.IO.Stream s)
    {
      return ((CreditorReferenceType1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CreditorReferenceType1 object into file
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
    /// Deserializes xml markup from file into an CreditorReferenceType1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CreditorReferenceType1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CreditorReferenceType1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CreditorReferenceType1);
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

    public static bool LoadFromFile(string fileName, out CreditorReferenceType1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CreditorReferenceType1 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
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

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class CreditorReferenceInformation1
  {

    private CreditorReferenceType1 cdtrRefTpField;

    private string cdtrRefField;

    private static XmlSerializer serializer;

    public CreditorReferenceInformation1()
    {
      this.cdtrRefTpField = new CreditorReferenceType1();
    }

    public CreditorReferenceType1 CdtrRefTp
    {
      get
      {
        return this.cdtrRefTpField;
      }
      set
      {
        this.cdtrRefTpField = value;
      }
    }

    public string CdtrRef
    {
      get
      {
        return this.cdtrRefField;
      }
      set
      {
        this.cdtrRefField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(CreditorReferenceInformation1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CreditorReferenceInformation1 object into an XML document
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
    /// Deserializes workflow markup into an CreditorReferenceInformation1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CreditorReferenceInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CreditorReferenceInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CreditorReferenceInformation1);
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

    public static bool Deserialize(string xml, out CreditorReferenceInformation1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CreditorReferenceInformation1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CreditorReferenceInformation1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CreditorReferenceInformation1 Deserialize(System.IO.Stream s)
    {
      return ((CreditorReferenceInformation1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CreditorReferenceInformation1 object into file
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
    /// Deserializes xml markup from file into an CreditorReferenceInformation1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CreditorReferenceInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CreditorReferenceInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CreditorReferenceInformation1);
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

    public static bool LoadFromFile(string fileName, out CreditorReferenceInformation1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CreditorReferenceInformation1 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class ReferredDocumentAmount1Choice
  {

    private CurrencyAndAmount itemField;

    private ItemChoiceType5 itemElementNameField;

    private static XmlSerializer serializer;

    public ReferredDocumentAmount1Choice()
    {
      this.itemField = new CurrencyAndAmount();
    }

    [XmlElementAttribute("CdtNoteAmt", typeof(CurrencyAndAmount))]
    [XmlElementAttribute("DscntApldAmt", typeof(CurrencyAndAmount))]
    [XmlElementAttribute("DuePyblAmt", typeof(CurrencyAndAmount))]
    [XmlElementAttribute("RmtdAmt", typeof(CurrencyAndAmount))]
    [XmlElementAttribute("TaxAmt", typeof(CurrencyAndAmount))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public CurrencyAndAmount Item
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType5 ItemElementName
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(ReferredDocumentAmount1Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ReferredDocumentAmount1Choice object into an XML document
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
    /// Deserializes workflow markup into an ReferredDocumentAmount1Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output ReferredDocumentAmount1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out ReferredDocumentAmount1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ReferredDocumentAmount1Choice);
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

    public static bool Deserialize(string xml, out ReferredDocumentAmount1Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static ReferredDocumentAmount1Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((ReferredDocumentAmount1Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static ReferredDocumentAmount1Choice Deserialize(System.IO.Stream s)
    {
      return ((ReferredDocumentAmount1Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current ReferredDocumentAmount1Choice object into file
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
    /// Deserializes xml markup from file into an ReferredDocumentAmount1Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ReferredDocumentAmount1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ReferredDocumentAmount1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ReferredDocumentAmount1Choice);
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

    public static bool LoadFromFile(string fileName, out ReferredDocumentAmount1Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static ReferredDocumentAmount1Choice LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class CurrencyAndAmount
  {

    private string ccyField;

    private decimal valueField;

    private static XmlSerializer serializer;

    [XmlAttributeAttribute()]
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

    [XmlTextAttribute()]
    public decimal Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(CurrencyAndAmount));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CurrencyAndAmount object into an XML document
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
    /// Deserializes workflow markup into an CurrencyAndAmount object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CurrencyAndAmount object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CurrencyAndAmount obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CurrencyAndAmount);
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

    public static bool Deserialize(string xml, out CurrencyAndAmount obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CurrencyAndAmount Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CurrencyAndAmount)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CurrencyAndAmount Deserialize(System.IO.Stream s)
    {
      return ((CurrencyAndAmount)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CurrencyAndAmount object into file
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
    /// Deserializes xml markup from file into an CurrencyAndAmount object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CurrencyAndAmount object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CurrencyAndAmount obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CurrencyAndAmount);
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

    public static bool LoadFromFile(string fileName, out CurrencyAndAmount obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CurrencyAndAmount LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema = false)]
  public enum ItemChoiceType5
  {

    /// <remarks/>
    CdtNoteAmt,

    /// <remarks/>
    DscntApldAmt,

    /// <remarks/>
    DuePyblAmt,

    /// <remarks/>
    RmtdAmt,

    /// <remarks/>
    TaxAmt,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class ReferredDocumentType1
  {

    private object itemField;

    private string issrField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Cd", typeof(DocumentType2Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(ReferredDocumentType1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ReferredDocumentType1 object into an XML document
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
    /// Deserializes workflow markup into an ReferredDocumentType1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output ReferredDocumentType1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out ReferredDocumentType1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ReferredDocumentType1);
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

    public static bool Deserialize(string xml, out ReferredDocumentType1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static ReferredDocumentType1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((ReferredDocumentType1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static ReferredDocumentType1 Deserialize(System.IO.Stream s)
    {
      return ((ReferredDocumentType1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current ReferredDocumentType1 object into file
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
    /// Deserializes xml markup from file into an ReferredDocumentType1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ReferredDocumentType1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ReferredDocumentType1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ReferredDocumentType1);
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

    public static bool LoadFromFile(string fileName, out ReferredDocumentType1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static ReferredDocumentType1 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum DocumentType2Code
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
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class ReferredDocumentInformation1
  {

    private ReferredDocumentType1 rfrdDocTpField;

    private string rfrdDocNbField;

    private static XmlSerializer serializer;

    public ReferredDocumentInformation1()
    {
      this.rfrdDocTpField = new ReferredDocumentType1();
    }

    public ReferredDocumentType1 RfrdDocTp
    {
      get
      {
        return this.rfrdDocTpField;
      }
      set
      {
        this.rfrdDocTpField = value;
      }
    }

    public string RfrdDocNb
    {
      get
      {
        return this.rfrdDocNbField;
      }
      set
      {
        this.rfrdDocNbField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(ReferredDocumentInformation1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ReferredDocumentInformation1 object into an XML document
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
    /// Deserializes workflow markup into an ReferredDocumentInformation1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output ReferredDocumentInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out ReferredDocumentInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ReferredDocumentInformation1);
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

    public static bool Deserialize(string xml, out ReferredDocumentInformation1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static ReferredDocumentInformation1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((ReferredDocumentInformation1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static ReferredDocumentInformation1 Deserialize(System.IO.Stream s)
    {
      return ((ReferredDocumentInformation1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current ReferredDocumentInformation1 object into file
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
    /// Deserializes xml markup from file into an ReferredDocumentInformation1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ReferredDocumentInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ReferredDocumentInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ReferredDocumentInformation1);
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

    public static bool LoadFromFile(string fileName, out ReferredDocumentInformation1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static ReferredDocumentInformation1 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class StructuredRemittanceInformation6
  {

    private ReferredDocumentInformation1 rfrdDocInfField;

    private System.Nullable<System.DateTime> rfrdDocRltdDtField;

    private List<ReferredDocumentAmount1Choice> rfrdDocAmtField;

    private CreditorReferenceInformation1 cdtrRefInfField;

    private PartyIdentification8 invcrField;

    private PartyIdentification8 invceeField;

    private string addtlRmtInfField;

    private static XmlSerializer serializer;

    public StructuredRemittanceInformation6()
    {
      this.invceeField = new PartyIdentification8();
      this.invcrField = new PartyIdentification8();
      this.cdtrRefInfField = new CreditorReferenceInformation1();
      this.rfrdDocAmtField = new List<ReferredDocumentAmount1Choice>();
      this.rfrdDocInfField = new ReferredDocumentInformation1();
    }

    public ReferredDocumentInformation1 RfrdDocInf
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

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime RfrdDocRltdDt
    {
      get
      {
        if (this.rfrdDocRltdDtField.HasValue)
        {
          return this.rfrdDocRltdDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.rfrdDocRltdDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool RfrdDocRltdDtSpecified
    {
      get
      {
        return this.rfrdDocRltdDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rfrdDocRltdDtField = null;
        }
      }
    }

    [XmlElementAttribute("RfrdDocAmt")]
    public List<ReferredDocumentAmount1Choice> RfrdDocAmt
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

    public CreditorReferenceInformation1 CdtrRefInf
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

    public PartyIdentification8 Invcr
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

    public PartyIdentification8 Invcee
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

    public string AddtlRmtInf
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(StructuredRemittanceInformation6));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current StructuredRemittanceInformation6 object into an XML document
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
    /// Deserializes workflow markup into an StructuredRemittanceInformation6 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output StructuredRemittanceInformation6 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out StructuredRemittanceInformation6 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(StructuredRemittanceInformation6);
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

    public static bool Deserialize(string xml, out StructuredRemittanceInformation6 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static StructuredRemittanceInformation6 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((StructuredRemittanceInformation6)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static StructuredRemittanceInformation6 Deserialize(System.IO.Stream s)
    {
      return ((StructuredRemittanceInformation6)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current StructuredRemittanceInformation6 object into file
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
    /// Deserializes xml markup from file into an StructuredRemittanceInformation6 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output StructuredRemittanceInformation6 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out StructuredRemittanceInformation6 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(StructuredRemittanceInformation6);
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

    public static bool LoadFromFile(string fileName, out StructuredRemittanceInformation6 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static StructuredRemittanceInformation6 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class RemittanceInformation1
  {

    private List<string> ustrdField;

    private List<StructuredRemittanceInformation6> strdField;

    private static XmlSerializer serializer;

    public RemittanceInformation1()
    {
      this.strdField = new List<StructuredRemittanceInformation6>();
      this.ustrdField = new List<string>();
    }

    [XmlElementAttribute("Ustrd")]
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

    [XmlElementAttribute("Strd")]
    public List<StructuredRemittanceInformation6> Strd
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(RemittanceInformation1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current RemittanceInformation1 object into an XML document
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
    /// Deserializes workflow markup into an RemittanceInformation1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output RemittanceInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out RemittanceInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceInformation1);
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

    public static bool Deserialize(string xml, out RemittanceInformation1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static RemittanceInformation1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((RemittanceInformation1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static RemittanceInformation1 Deserialize(System.IO.Stream s)
    {
      return ((RemittanceInformation1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current RemittanceInformation1 object into file
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
    /// Deserializes xml markup from file into an RemittanceInformation1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output RemittanceInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out RemittanceInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceInformation1);
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

    public static bool LoadFromFile(string fileName, out RemittanceInformation1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static RemittanceInformation1 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class NameAndAddress3
  {

    private string nmField;

    private PostalAddress1 adrField;

    private static XmlSerializer serializer;

    public NameAndAddress3()
    {
      this.adrField = new PostalAddress1();
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

    public PostalAddress1 Adr
    {
      get
      {
        return this.adrField;
      }
      set
      {
        this.adrField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(NameAndAddress3));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current NameAndAddress3 object into an XML document
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
    /// Deserializes workflow markup into an NameAndAddress3 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output NameAndAddress3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out NameAndAddress3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(NameAndAddress3);
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

    public static bool Deserialize(string xml, out NameAndAddress3 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static NameAndAddress3 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((NameAndAddress3)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static NameAndAddress3 Deserialize(System.IO.Stream s)
    {
      return ((NameAndAddress3)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current NameAndAddress3 object into file
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
    /// Deserializes xml markup from file into an NameAndAddress3 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NameAndAddress3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out NameAndAddress3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(NameAndAddress3);
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

    public static bool LoadFromFile(string fileName, out NameAndAddress3 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static NameAndAddress3 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class RemittanceLocation1
  {

    private string rmtIdField;

    private System.Nullable<RemittanceLocationMethod1Code> rmtLctnMtdField;

    private string rmtLctnElctrncAdrField;

    private NameAndAddress3 rmtLctnPstlAdrField;

    private static XmlSerializer serializer;

    public RemittanceLocation1()
    {
      this.rmtLctnPstlAdrField = new NameAndAddress3();
    }

    public string RmtId
    {
      get
      {
        return this.rmtIdField;
      }
      set
      {
        this.rmtIdField = value;
      }
    }

    public RemittanceLocationMethod1Code RmtLctnMtd
    {
      get
      {
        if (this.rmtLctnMtdField.HasValue)
        {
          return this.rmtLctnMtdField.Value;
        }
        else
        {
          return default(RemittanceLocationMethod1Code);
        }
      }
      set
      {
        this.rmtLctnMtdField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool RmtLctnMtdSpecified
    {
      get
      {
        return this.rmtLctnMtdField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rmtLctnMtdField = null;
        }
      }
    }

    public string RmtLctnElctrncAdr
    {
      get
      {
        return this.rmtLctnElctrncAdrField;
      }
      set
      {
        this.rmtLctnElctrncAdrField = value;
      }
    }

    public NameAndAddress3 RmtLctnPstlAdr
    {
      get
      {
        return this.rmtLctnPstlAdrField;
      }
      set
      {
        this.rmtLctnPstlAdrField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(RemittanceLocation1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current RemittanceLocation1 object into an XML document
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
    /// Deserializes workflow markup into an RemittanceLocation1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output RemittanceLocation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out RemittanceLocation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceLocation1);
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

    public static bool Deserialize(string xml, out RemittanceLocation1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static RemittanceLocation1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((RemittanceLocation1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static RemittanceLocation1 Deserialize(System.IO.Stream s)
    {
      return ((RemittanceLocation1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current RemittanceLocation1 object into file
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
    /// Deserializes xml markup from file into an RemittanceLocation1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output RemittanceLocation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out RemittanceLocation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RemittanceLocation1);
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

    public static bool LoadFromFile(string fileName, out RemittanceLocation1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static RemittanceLocation1 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum RemittanceLocationMethod1Code
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
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class TaxType
  {

    private string ctgyDescField;

    private System.Nullable<decimal> rateField;

    private CurrencyAndAmount taxblBaseAmtField;

    private CurrencyAndAmount amtField;

    private static XmlSerializer serializer;

    public TaxType()
    {
      this.amtField = new CurrencyAndAmount();
      this.taxblBaseAmtField = new CurrencyAndAmount();
    }

    public string CtgyDesc
    {
      get
      {
        return this.ctgyDescField;
      }
      set
      {
        this.ctgyDescField = value;
      }
    }

    public decimal Rate
    {
      get
      {
        if (this.rateField.HasValue)
        {
          return this.rateField.Value;
        }
        else
        {
          return default(decimal);
        }
      }
      set
      {
        this.rateField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool RateSpecified
    {
      get
      {
        return this.rateField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.rateField = null;
        }
      }
    }

    public CurrencyAndAmount TaxblBaseAmt
    {
      get
      {
        return this.taxblBaseAmtField;
      }
      set
      {
        this.taxblBaseAmtField = value;
      }
    }

    public CurrencyAndAmount Amt
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(TaxType));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current TaxType object into an XML document
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
    /// Deserializes workflow markup into an TaxType object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output TaxType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out TaxType obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxType);
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

    public static bool Deserialize(string xml, out TaxType obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static TaxType Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((TaxType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static TaxType Deserialize(System.IO.Stream s)
    {
      return ((TaxType)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current TaxType object into file
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
    /// Deserializes xml markup from file into an TaxType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output TaxType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out TaxType obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxType);
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

    public static bool LoadFromFile(string fileName, out TaxType obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static TaxType LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class TaxDetails
  {

    private string certIdField;

    private TaxType taxTpField;

    private static XmlSerializer serializer;

    public TaxDetails()
    {
      this.taxTpField = new TaxType();
    }

    public string CertId
    {
      get
      {
        return this.certIdField;
      }
      set
      {
        this.certIdField = value;
      }
    }

    public TaxType TaxTp
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(TaxDetails));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current TaxDetails object into an XML document
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
    /// Deserializes workflow markup into an TaxDetails object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output TaxDetails object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out TaxDetails obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxDetails);
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

    public static bool Deserialize(string xml, out TaxDetails obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static TaxDetails Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((TaxDetails)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static TaxDetails Deserialize(System.IO.Stream s)
    {
      return ((TaxDetails)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current TaxDetails object into file
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
    /// Deserializes xml markup from file into an TaxDetails object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output TaxDetails object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out TaxDetails obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxDetails);
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

    public static bool LoadFromFile(string fileName, out TaxDetails obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static TaxDetails LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class TaxInformation2
  {

    private string cdtrTaxIdField;

    private string cdtrTaxTpField;

    private string dbtrTaxIdField;

    private string taxRefNbField;

    private CurrencyAndAmount ttlTaxblBaseAmtField;

    private CurrencyAndAmount ttlTaxAmtField;

    private System.Nullable<System.DateTime> taxDtField;

    private List<TaxDetails> taxTpInfField;

    private static XmlSerializer serializer;

    public TaxInformation2()
    {
      this.taxTpInfField = new List<TaxDetails>();
      this.ttlTaxAmtField = new CurrencyAndAmount();
      this.ttlTaxblBaseAmtField = new CurrencyAndAmount();
    }

    public string CdtrTaxId
    {
      get
      {
        return this.cdtrTaxIdField;
      }
      set
      {
        this.cdtrTaxIdField = value;
      }
    }

    public string CdtrTaxTp
    {
      get
      {
        return this.cdtrTaxTpField;
      }
      set
      {
        this.cdtrTaxTpField = value;
      }
    }

    public string DbtrTaxId
    {
      get
      {
        return this.dbtrTaxIdField;
      }
      set
      {
        this.dbtrTaxIdField = value;
      }
    }

    public string TaxRefNb
    {
      get
      {
        return this.taxRefNbField;
      }
      set
      {
        this.taxRefNbField = value;
      }
    }

    public CurrencyAndAmount TtlTaxblBaseAmt
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

    public CurrencyAndAmount TtlTaxAmt
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

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime TaxDt
    {
      get
      {
        if (this.taxDtField.HasValue)
        {
          return this.taxDtField.Value;
        }
        else
        {
          return default(System.DateTime);
        }
      }
      set
      {
        this.taxDtField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool TaxDtSpecified
    {
      get
      {
        return this.taxDtField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.taxDtField = null;
        }
      }
    }

    [XmlElementAttribute("TaxTpInf")]
    public List<TaxDetails> TaxTpInf
    {
      get
      {
        return this.taxTpInfField;
      }
      set
      {
        this.taxTpInfField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(TaxInformation2));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current TaxInformation2 object into an XML document
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
    /// Deserializes workflow markup into an TaxInformation2 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output TaxInformation2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out TaxInformation2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxInformation2);
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

    public static bool Deserialize(string xml, out TaxInformation2 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static TaxInformation2 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((TaxInformation2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static TaxInformation2 Deserialize(System.IO.Stream s)
    {
      return ((TaxInformation2)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current TaxInformation2 object into file
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
    /// Deserializes xml markup from file into an TaxInformation2 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output TaxInformation2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out TaxInformation2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(TaxInformation2);
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

    public static bool LoadFromFile(string fileName, out TaxInformation2 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static TaxInformation2 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class StructuredRegulatoryReporting2
  {

    private string cdField;

    private CurrencyAndAmount amtField;

    private string infField;

    private static XmlSerializer serializer;

    public StructuredRegulatoryReporting2()
    {
      this.amtField = new CurrencyAndAmount();
    }

    public string Cd
    {
      get
      {
        return this.cdField;
      }
      set
      {
        this.cdField = value;
      }
    }

    public CurrencyAndAmount Amt
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

    public string Inf
    {
      get
      {
        return this.infField;
      }
      set
      {
        this.infField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(StructuredRegulatoryReporting2));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current StructuredRegulatoryReporting2 object into an XML document
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
    /// Deserializes workflow markup into an StructuredRegulatoryReporting2 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output StructuredRegulatoryReporting2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out StructuredRegulatoryReporting2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(StructuredRegulatoryReporting2);
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

    public static bool Deserialize(string xml, out StructuredRegulatoryReporting2 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static StructuredRegulatoryReporting2 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((StructuredRegulatoryReporting2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static StructuredRegulatoryReporting2 Deserialize(System.IO.Stream s)
    {
      return ((StructuredRegulatoryReporting2)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current StructuredRegulatoryReporting2 object into file
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
    /// Deserializes xml markup from file into an StructuredRegulatoryReporting2 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output StructuredRegulatoryReporting2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out StructuredRegulatoryReporting2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(StructuredRegulatoryReporting2);
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

    public static bool LoadFromFile(string fileName, out StructuredRegulatoryReporting2 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static StructuredRegulatoryReporting2 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class RegulatoryAuthority
  {

    private string authrtyNmField;

    private string authrtyCtryField;

    private static XmlSerializer serializer;

    public string AuthrtyNm
    {
      get
      {
        return this.authrtyNmField;
      }
      set
      {
        this.authrtyNmField = value;
      }
    }

    public string AuthrtyCtry
    {
      get
      {
        return this.authrtyCtryField;
      }
      set
      {
        this.authrtyCtryField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(RegulatoryAuthority));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current RegulatoryAuthority object into an XML document
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
    /// Deserializes workflow markup into an RegulatoryAuthority object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output RegulatoryAuthority object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out RegulatoryAuthority obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RegulatoryAuthority);
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

    public static bool Deserialize(string xml, out RegulatoryAuthority obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static RegulatoryAuthority Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((RegulatoryAuthority)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static RegulatoryAuthority Deserialize(System.IO.Stream s)
    {
      return ((RegulatoryAuthority)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current RegulatoryAuthority object into file
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
    /// Deserializes xml markup from file into an RegulatoryAuthority object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output RegulatoryAuthority object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out RegulatoryAuthority obj, out System.Exception exception)
    {
      exception = null;
      obj = default(RegulatoryAuthority);
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

    public static bool LoadFromFile(string fileName, out RegulatoryAuthority obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static RegulatoryAuthority LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class RegulatoryReporting2
  {

    private System.Nullable<RegulatoryReportingType1Code> dbtCdtRptgIndField;

    private RegulatoryAuthority authrtyField;

    private StructuredRegulatoryReporting2 rgltryDtlsField;

    private static XmlSerializer serializer;

    public RegulatoryReporting2()
    {
      this.rgltryDtlsField = new StructuredRegulatoryReporting2();
      this.authrtyField = new RegulatoryAuthority();
    }

    public RegulatoryReportingType1Code DbtCdtRptgInd
    {
      get
      {
        if (this.dbtCdtRptgIndField.HasValue)
        {
          return this.dbtCdtRptgIndField.Value;
        }
        else
        {
          return default(RegulatoryReportingType1Code);
        }
      }
      set
      {
        this.dbtCdtRptgIndField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool DbtCdtRptgIndSpecified
    {
      get
      {
        return this.dbtCdtRptgIndField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.dbtCdtRptgIndField = null;
        }
      }
    }

    public RegulatoryAuthority Authrty
    {
      get
      {
        return this.authrtyField;
      }
      set
      {
        this.authrtyField = value;
      }
    }

    public StructuredRegulatoryReporting2 RgltryDtls
    {
      get
      {
        return this.rgltryDtlsField;
      }
      set
      {
        this.rgltryDtlsField = value;
      }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class Purpose1Choice
  {

    private string itemField;

    private ItemChoiceType4 itemElementNameField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType4 ItemElementName
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(Purpose1Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current Purpose1Choice object into an XML document
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
    /// Deserializes workflow markup into an Purpose1Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output Purpose1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out Purpose1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Purpose1Choice);
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

    public static bool Deserialize(string xml, out Purpose1Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static Purpose1Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((Purpose1Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static Purpose1Choice Deserialize(System.IO.Stream s)
    {
      return ((Purpose1Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current Purpose1Choice object into file
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
    /// Deserializes xml markup from file into an Purpose1Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output Purpose1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out Purpose1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Purpose1Choice);
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

    public static bool LoadFromFile(string fileName, out Purpose1Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static Purpose1Choice LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema = false)]
  public enum ItemChoiceType4
  {

    /// <remarks/>
    Cd,

    /// <remarks/>
    Prtry,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class AmendmentInformationDetails1
  {

    private string orgnlMndtIdField;

    private PartyIdentification8 orgnlCdtrSchmeIdField;

    private BranchAndFinancialInstitutionIdentification3 orgnlCdtrAgtField;

    private CashAccount7 orgnlCdtrAgtAcctField;

    private PartyIdentification8 orgnlDbtrField;

    private CashAccount7 orgnlDbtrAcctField;

    private BranchAndFinancialInstitutionIdentification3 orgnlDbtrAgtField;

    private CashAccount7 orgnlDbtrAgtAcctField;

    private System.Nullable<System.DateTime> orgnlFnlColltnDtField;

    private System.Nullable<Frequency1Code> orgnlFrqcyField;

    private static XmlSerializer serializer;

    public AmendmentInformationDetails1()
    {
      this.orgnlDbtrAgtAcctField = new CashAccount7();
      this.orgnlDbtrAgtField = new BranchAndFinancialInstitutionIdentification3();
      this.orgnlDbtrAcctField = new CashAccount7();
      this.orgnlDbtrField = new PartyIdentification8();
      this.orgnlCdtrAgtAcctField = new CashAccount7();
      this.orgnlCdtrAgtField = new BranchAndFinancialInstitutionIdentification3();
      this.orgnlCdtrSchmeIdField = new PartyIdentification8();
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

    public PartyIdentification8 OrgnlCdtrSchmeId
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

    public BranchAndFinancialInstitutionIdentification3 OrgnlCdtrAgt
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

    public CashAccount7 OrgnlCdtrAgtAcct
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

    public PartyIdentification8 OrgnlDbtr
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

    public CashAccount7 OrgnlDbtrAcct
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

    public BranchAndFinancialInstitutionIdentification3 OrgnlDbtrAgt
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

    public CashAccount7 OrgnlDbtrAgtAcct
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

    [XmlElementAttribute(DataType = "date")]
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

    [XmlIgnoreAttribute()]
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

    [XmlIgnoreAttribute()]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(AmendmentInformationDetails1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AmendmentInformationDetails1 object into an XML document
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
    /// Deserializes workflow markup into an AmendmentInformationDetails1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output AmendmentInformationDetails1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out AmendmentInformationDetails1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AmendmentInformationDetails1);
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

    public static bool Deserialize(string xml, out AmendmentInformationDetails1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static AmendmentInformationDetails1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((AmendmentInformationDetails1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static AmendmentInformationDetails1 Deserialize(System.IO.Stream s)
    {
      return ((AmendmentInformationDetails1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current AmendmentInformationDetails1 object into file
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
    /// Deserializes xml markup from file into an AmendmentInformationDetails1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AmendmentInformationDetails1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out AmendmentInformationDetails1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AmendmentInformationDetails1);
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

    public static bool LoadFromFile(string fileName, out AmendmentInformationDetails1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static AmendmentInformationDetails1 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class BranchAndFinancialInstitutionIdentification3
  {

    private FinancialInstitutionIdentification5Choice finInstnIdField;

    private BranchData brnchIdField;

    private static XmlSerializer serializer;

    public BranchAndFinancialInstitutionIdentification3()
    {
      this.brnchIdField = new BranchData();
      this.finInstnIdField = new FinancialInstitutionIdentification5Choice();
    }

    public FinancialInstitutionIdentification5Choice FinInstnId
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

    public BranchData BrnchId
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(BranchAndFinancialInstitutionIdentification3));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current BranchAndFinancialInstitutionIdentification3 object into an XML document
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
    /// Deserializes workflow markup into an BranchAndFinancialInstitutionIdentification3 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output BranchAndFinancialInstitutionIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out BranchAndFinancialInstitutionIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(BranchAndFinancialInstitutionIdentification3);
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

    public static bool Deserialize(string xml, out BranchAndFinancialInstitutionIdentification3 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static BranchAndFinancialInstitutionIdentification3 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((BranchAndFinancialInstitutionIdentification3)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static BranchAndFinancialInstitutionIdentification3 Deserialize(System.IO.Stream s)
    {
      return ((BranchAndFinancialInstitutionIdentification3)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current BranchAndFinancialInstitutionIdentification3 object into file
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
    /// Deserializes xml markup from file into an BranchAndFinancialInstitutionIdentification3 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output BranchAndFinancialInstitutionIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out BranchAndFinancialInstitutionIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(BranchAndFinancialInstitutionIdentification3);
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

    public static bool LoadFromFile(string fileName, out BranchAndFinancialInstitutionIdentification3 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static BranchAndFinancialInstitutionIdentification3 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class FinancialInstitutionIdentification5Choice
  {

    private object itemField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("BIC", typeof(string))]
    [XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentification3Choice))]
    [XmlElementAttribute("CmbndId", typeof(FinancialInstitutionIdentification3))]
    [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress7))]
    [XmlElementAttribute("PrtryId", typeof(GenericIdentification3))]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(FinancialInstitutionIdentification5Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current FinancialInstitutionIdentification5Choice object into an XML document
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
    /// Deserializes workflow markup into an FinancialInstitutionIdentification5Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output FinancialInstitutionIdentification5Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out FinancialInstitutionIdentification5Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(FinancialInstitutionIdentification5Choice);
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

    public static bool Deserialize(string xml, out FinancialInstitutionIdentification5Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static FinancialInstitutionIdentification5Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((FinancialInstitutionIdentification5Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static FinancialInstitutionIdentification5Choice Deserialize(System.IO.Stream s)
    {
      return ((FinancialInstitutionIdentification5Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current FinancialInstitutionIdentification5Choice object into file
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
    /// Deserializes xml markup from file into an FinancialInstitutionIdentification5Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output FinancialInstitutionIdentification5Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out FinancialInstitutionIdentification5Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(FinancialInstitutionIdentification5Choice);
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

    public static bool LoadFromFile(string fileName, out FinancialInstitutionIdentification5Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static FinancialInstitutionIdentification5Choice LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class ClearingSystemMemberIdentification3Choice
  {

    private string itemField;

    private ItemChoiceType1 itemElementNameField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Id", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(ClearingSystemMemberIdentification3Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ClearingSystemMemberIdentification3Choice object into an XML document
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
    /// Deserializes workflow markup into an ClearingSystemMemberIdentification3Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output ClearingSystemMemberIdentification3Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out ClearingSystemMemberIdentification3Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ClearingSystemMemberIdentification3Choice);
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

    public static bool Deserialize(string xml, out ClearingSystemMemberIdentification3Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static ClearingSystemMemberIdentification3Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((ClearingSystemMemberIdentification3Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static ClearingSystemMemberIdentification3Choice Deserialize(System.IO.Stream s)
    {
      return ((ClearingSystemMemberIdentification3Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current ClearingSystemMemberIdentification3Choice object into file
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
    /// Deserializes xml markup from file into an ClearingSystemMemberIdentification3Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ClearingSystemMemberIdentification3Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ClearingSystemMemberIdentification3Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ClearingSystemMemberIdentification3Choice);
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

    public static bool LoadFromFile(string fileName, out ClearingSystemMemberIdentification3Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static ClearingSystemMemberIdentification3Choice LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema = false)]
  public enum ItemChoiceType1
  {

    /// <remarks/>
    Id,

    /// <remarks/>
    Prtry,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class FinancialInstitutionIdentification3
  {

    private string bICField;

    private ClearingSystemMemberIdentification3Choice clrSysMmbIdField;

    private string nmField;

    private PostalAddress1 pstlAdrField;

    private GenericIdentification3 prtryIdField;

    private static XmlSerializer serializer;

    public FinancialInstitutionIdentification3()
    {
      this.prtryIdField = new GenericIdentification3();
      this.pstlAdrField = new PostalAddress1();
      this.clrSysMmbIdField = new ClearingSystemMemberIdentification3Choice();
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

    public ClearingSystemMemberIdentification3Choice ClrSysMmbId
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

    public PostalAddress1 PstlAdr
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

    public GenericIdentification3 PrtryId
    {
      get
      {
        return this.prtryIdField;
      }
      set
      {
        this.prtryIdField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(FinancialInstitutionIdentification3));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current FinancialInstitutionIdentification3 object into an XML document
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
    /// Deserializes workflow markup into an FinancialInstitutionIdentification3 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output FinancialInstitutionIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out FinancialInstitutionIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(FinancialInstitutionIdentification3);
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

    public static bool Deserialize(string xml, out FinancialInstitutionIdentification3 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static FinancialInstitutionIdentification3 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((FinancialInstitutionIdentification3)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static FinancialInstitutionIdentification3 Deserialize(System.IO.Stream s)
    {
      return ((FinancialInstitutionIdentification3)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current FinancialInstitutionIdentification3 object into file
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
    /// Deserializes xml markup from file into an FinancialInstitutionIdentification3 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output FinancialInstitutionIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out FinancialInstitutionIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(FinancialInstitutionIdentification3);
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

    public static bool LoadFromFile(string fileName, out FinancialInstitutionIdentification3 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static FinancialInstitutionIdentification3 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class GenericIdentification3
  {

    private string idField;

    private string issrField;

    private static XmlSerializer serializer;

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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(GenericIdentification3));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current GenericIdentification3 object into an XML document
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
    /// Deserializes workflow markup into an GenericIdentification3 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output GenericIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out GenericIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GenericIdentification3);
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

    public static bool Deserialize(string xml, out GenericIdentification3 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static GenericIdentification3 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((GenericIdentification3)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static GenericIdentification3 Deserialize(System.IO.Stream s)
    {
      return ((GenericIdentification3)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current GenericIdentification3 object into file
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
    /// Deserializes xml markup from file into an GenericIdentification3 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output GenericIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out GenericIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GenericIdentification3);
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

    public static bool LoadFromFile(string fileName, out GenericIdentification3 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static GenericIdentification3 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class NameAndAddress7
  {

    private string nmField;

    private PostalAddress1 pstlAdrField;

    private static XmlSerializer serializer;

    public NameAndAddress7()
    {
      this.pstlAdrField = new PostalAddress1();
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

    public PostalAddress1 PstlAdr
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(NameAndAddress7));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current NameAndAddress7 object into an XML document
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
    /// Deserializes workflow markup into an NameAndAddress7 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output NameAndAddress7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out NameAndAddress7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(NameAndAddress7);
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

    public static bool Deserialize(string xml, out NameAndAddress7 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static NameAndAddress7 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((NameAndAddress7)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static NameAndAddress7 Deserialize(System.IO.Stream s)
    {
      return ((NameAndAddress7)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current NameAndAddress7 object into file
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
    /// Deserializes xml markup from file into an NameAndAddress7 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output NameAndAddress7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out NameAndAddress7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(NameAndAddress7);
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

    public static bool LoadFromFile(string fileName, out NameAndAddress7 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static NameAndAddress7 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class BranchData
  {

    private string idField;

    private string nmField;

    private PostalAddress1 pstlAdrField;

    private static XmlSerializer serializer;

    public BranchData()
    {
      this.pstlAdrField = new PostalAddress1();
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

    public PostalAddress1 PstlAdr
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(BranchData));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current BranchData object into an XML document
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
    /// Deserializes workflow markup into an BranchData object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output BranchData object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out BranchData obj, out System.Exception exception)
    {
      exception = null;
      obj = default(BranchData);
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

    public static bool Deserialize(string xml, out BranchData obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static BranchData Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((BranchData)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static BranchData Deserialize(System.IO.Stream s)
    {
      return ((BranchData)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current BranchData object into file
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
    /// Deserializes xml markup from file into an BranchData object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output BranchData object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out BranchData obj, out System.Exception exception)
    {
      exception = null;
      obj = default(BranchData);
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

    public static bool LoadFromFile(string fileName, out BranchData obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static BranchData LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class CashAccount7
  {

    private AccountIdentification3Choice idField;

    private CashAccountType2 tpField;

    private string ccyField;

    private string nmField;

    private static XmlSerializer serializer;

    public CashAccount7()
    {
      this.tpField = new CashAccountType2();
      this.idField = new AccountIdentification3Choice();
    }

    public AccountIdentification3Choice Id
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(CashAccount7));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current CashAccount7 object into an XML document
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
    /// Deserializes workflow markup into an CashAccount7 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output CashAccount7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out CashAccount7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CashAccount7);
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

    public static bool Deserialize(string xml, out CashAccount7 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static CashAccount7 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((CashAccount7)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static CashAccount7 Deserialize(System.IO.Stream s)
    {
      return ((CashAccount7)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current CashAccount7 object into file
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
    /// Deserializes xml markup from file into an CashAccount7 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CashAccount7 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CashAccount7 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(CashAccount7);
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

    public static bool LoadFromFile(string fileName, out CashAccount7 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static CashAccount7 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class AccountIdentification3Choice
  {

    private object itemField;

    private ItemChoiceType3 itemElementNameField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("BBAN", typeof(string))]
    [XmlElementAttribute("IBAN", typeof(string))]
    [XmlElementAttribute("PrtryAcct", typeof(SimpleIdentificationInformation2))]
    [XmlElementAttribute("UPIC", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType3 ItemElementName
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(AccountIdentification3Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AccountIdentification3Choice object into an XML document
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
    /// Deserializes workflow markup into an AccountIdentification3Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output AccountIdentification3Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out AccountIdentification3Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AccountIdentification3Choice);
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

    public static bool Deserialize(string xml, out AccountIdentification3Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static AccountIdentification3Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((AccountIdentification3Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static AccountIdentification3Choice Deserialize(System.IO.Stream s)
    {
      return ((AccountIdentification3Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current AccountIdentification3Choice object into file
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
    /// Deserializes xml markup from file into an AccountIdentification3Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AccountIdentification3Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out AccountIdentification3Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(AccountIdentification3Choice);
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

    public static bool LoadFromFile(string fileName, out AccountIdentification3Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static AccountIdentification3Choice LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class SimpleIdentificationInformation2
  {

    private string idField;

    private static XmlSerializer serializer;

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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(SimpleIdentificationInformation2));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current SimpleIdentificationInformation2 object into an XML document
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
    /// Deserializes workflow markup into an SimpleIdentificationInformation2 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output SimpleIdentificationInformation2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out SimpleIdentificationInformation2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(SimpleIdentificationInformation2);
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

    public static bool Deserialize(string xml, out SimpleIdentificationInformation2 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static SimpleIdentificationInformation2 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((SimpleIdentificationInformation2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static SimpleIdentificationInformation2 Deserialize(System.IO.Stream s)
    {
      return ((SimpleIdentificationInformation2)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current SimpleIdentificationInformation2 object into file
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
    /// Deserializes xml markup from file into an SimpleIdentificationInformation2 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output SimpleIdentificationInformation2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out SimpleIdentificationInformation2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(SimpleIdentificationInformation2);
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

    public static bool LoadFromFile(string fileName, out SimpleIdentificationInformation2 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static SimpleIdentificationInformation2 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema = false)]
  public enum ItemChoiceType3
  {

    /// <remarks/>
    BBAN,

    /// <remarks/>
    IBAN,

    /// <remarks/>
    PrtryAcct,

    /// <remarks/>
    UPIC,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class CashAccountType2
  {

    private object itemField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Cd", typeof(CashAccountType4Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(CashAccountType2));
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class MandateRelatedInformation1
  {

    private string mndtIdField;

    private System.Nullable<System.DateTime> dtOfSgntrField;

    private System.Nullable<bool> amdmntIndField;

    private AmendmentInformationDetails1 amdmntInfDtlsField;

    private string elctrncSgntrField;

    private System.Nullable<System.DateTime> frstColltnDtField;

    private System.Nullable<System.DateTime> fnlColltnDtField;

    private System.Nullable<Frequency1Code> frqcyField;

    private static XmlSerializer serializer;

    public MandateRelatedInformation1()
    {
      this.amdmntInfDtlsField = new AmendmentInformationDetails1();
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

    [XmlElementAttribute(DataType = "date")]
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

    [XmlIgnoreAttribute()]
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

    [XmlIgnoreAttribute()]
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

    public AmendmentInformationDetails1 AmdmntInfDtls
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

    [XmlElementAttribute(DataType = "date")]
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

    [XmlIgnoreAttribute()]
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

    [XmlElementAttribute(DataType = "date")]
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

    [XmlIgnoreAttribute()]
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

    [XmlIgnoreAttribute()]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(MandateRelatedInformation1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current MandateRelatedInformation1 object into an XML document
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
    /// Deserializes workflow markup into an MandateRelatedInformation1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output MandateRelatedInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out MandateRelatedInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(MandateRelatedInformation1);
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

    public static bool Deserialize(string xml, out MandateRelatedInformation1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static MandateRelatedInformation1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((MandateRelatedInformation1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static MandateRelatedInformation1 Deserialize(System.IO.Stream s)
    {
      return ((MandateRelatedInformation1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current MandateRelatedInformation1 object into file
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
    /// Deserializes xml markup from file into an MandateRelatedInformation1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output MandateRelatedInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out MandateRelatedInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(MandateRelatedInformation1);
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

    public static bool LoadFromFile(string fileName, out MandateRelatedInformation1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static MandateRelatedInformation1 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class DirectDebitTransaction1
  {

    private MandateRelatedInformation1 mndtRltdInfField;

    private PartyIdentification8 cdtrSchmeIdField;

    private string preNtfctnIdField;

    private System.Nullable<System.DateTime> preNtfctnDtField;

    private static XmlSerializer serializer;

    public DirectDebitTransaction1()
    {
      this.cdtrSchmeIdField = new PartyIdentification8();
      this.mndtRltdInfField = new MandateRelatedInformation1();
    }

    public MandateRelatedInformation1 MndtRltdInf
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

    public PartyIdentification8 CdtrSchmeId
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

    [XmlElementAttribute(DataType = "date")]
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

    [XmlIgnoreAttribute()]
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class DirectDebitTransactionInformation1
  {

    private PaymentIdentification1 pmtIdField;

    private PaymentTypeInformation2 pmtTpInfField;

    private CurrencyAndAmount instdAmtField;

    private System.Nullable<ChargeBearerType1Code> chrgBrField;

    private DirectDebitTransaction1 drctDbtTxField;

    private PartyIdentification8 ultmtCdtrField;

    private BranchAndFinancialInstitutionIdentification3 dbtrAgtField;

    private CashAccount7 dbtrAgtAcctField;

    private PartyIdentification8 dbtrField;

    private CashAccount7 dbtrAcctField;

    private PartyIdentification8 ultmtDbtrField;

    private string instrForCdtrAgtField;

    private Purpose1Choice purpField;

    private List<RegulatoryReporting2> rgltryRptgField;

    private TaxInformation2 taxField;

    private List<RemittanceLocation1> rltdRmtInfField;

    private RemittanceInformation1 rmtInfField;

    private static XmlSerializer serializer;

    public DirectDebitTransactionInformation1()
    {
      rmtInfField = new RemittanceInformation1();
      rltdRmtInfField = new List<RemittanceLocation1>();
      taxField = new TaxInformation2();
      rgltryRptgField = new List<RegulatoryReporting2>();
      purpField = new Purpose1Choice();
      ultmtDbtrField = new PartyIdentification8();
      dbtrAcctField = new CashAccount7();
      dbtrField = new PartyIdentification8();
      dbtrAgtAcctField = new CashAccount7();
      dbtrAgtField = new BranchAndFinancialInstitutionIdentification3();
      ultmtCdtrField = new PartyIdentification8();
      drctDbtTxField = new DirectDebitTransaction1();
      instdAmtField = new CurrencyAndAmount();
      pmtTpInfField = new PaymentTypeInformation2();
      pmtIdField = new PaymentIdentification1();
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

    public PaymentTypeInformation2 PmtTpInf
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

    public CurrencyAndAmount InstdAmt
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

    [XmlIgnoreAttribute()]
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

    public DirectDebitTransaction1 DrctDbtTx
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

    public PartyIdentification8 UltmtCdtr
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

    public BranchAndFinancialInstitutionIdentification3 DbtrAgt
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

    public CashAccount7 DbtrAgtAcct
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

    public PartyIdentification8 Dbtr
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

    public CashAccount7 DbtrAcct
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

    public PartyIdentification8 UltmtDbtr
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

    public Purpose1Choice Purp
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

    [XmlElementAttribute("RgltryRptg")]
    public List<RegulatoryReporting2> RgltryRptg
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

    public TaxInformation2 Tax
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

    [XmlElementAttribute("RltdRmtInf")]
    public List<RemittanceLocation1> RltdRmtInf
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

    public RemittanceInformation1 RmtInf
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(DirectDebitTransactionInformation1));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current DirectDebitTransactionInformation1 object into an XML document
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
    /// Deserializes workflow markup into an DirectDebitTransactionInformation1 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output DirectDebitTransactionInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out DirectDebitTransactionInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(DirectDebitTransactionInformation1);
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

    public static bool Deserialize(string xml, out DirectDebitTransactionInformation1 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static DirectDebitTransactionInformation1 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((DirectDebitTransactionInformation1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static DirectDebitTransactionInformation1 Deserialize(System.IO.Stream s)
    {
      return ((DirectDebitTransactionInformation1)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current DirectDebitTransactionInformation1 object into file
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
    /// Deserializes xml markup from file into an DirectDebitTransactionInformation1 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output DirectDebitTransactionInformation1 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out DirectDebitTransactionInformation1 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(DirectDebitTransactionInformation1);
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

    public static bool LoadFromFile(string fileName, out DirectDebitTransactionInformation1 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static DirectDebitTransactionInformation1 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class PaymentTypeInformation2
  {

    private System.Nullable<Priority2Code> instrPrtyField;

    private object itemField;

    private LocalInstrument1Choice lclInstrmField;

    private System.Nullable<SequenceType1Code> seqTpField;

    private System.Nullable<PaymentCategoryPurpose1Code> ctgyPurpField;

    private static XmlSerializer serializer;

    public PaymentTypeInformation2()
    {
      this.lclInstrmField = new LocalInstrument1Choice();
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

    [XmlIgnoreAttribute()]
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

    [XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code))]
    [XmlElementAttribute("SvcLvl", typeof(ServiceLevel3Choice))]
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

    public LocalInstrument1Choice LclInstrm
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

    [XmlIgnoreAttribute()]
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

    public PaymentCategoryPurpose1Code CtgyPurp
    {
      get
      {
        if (this.ctgyPurpField.HasValue)
        {
          return this.ctgyPurpField.Value;
        }
        else
        {
          return default(PaymentCategoryPurpose1Code);
        }
      }
      set
      {
        this.ctgyPurpField = value;
      }
    }

    [XmlIgnoreAttribute()]
    public bool CtgyPurpSpecified
    {
      get
      {
        return this.ctgyPurpField.HasValue;
      }
      set
      {
        if (value == false)
        {
          this.ctgyPurpField = null;
        }
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(PaymentTypeInformation2));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PaymentTypeInformation2 object into an XML document
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
    /// Deserializes workflow markup into an PaymentTypeInformation2 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PaymentTypeInformation2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PaymentTypeInformation2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PaymentTypeInformation2);
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

    public static bool Deserialize(string xml, out PaymentTypeInformation2 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PaymentTypeInformation2 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PaymentTypeInformation2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PaymentTypeInformation2 Deserialize(System.IO.Stream s)
    {
      return ((PaymentTypeInformation2)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PaymentTypeInformation2 object into file
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
    /// Deserializes xml markup from file into an PaymentTypeInformation2 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PaymentTypeInformation2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PaymentTypeInformation2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PaymentTypeInformation2);
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

    public static bool LoadFromFile(string fileName, out PaymentTypeInformation2 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PaymentTypeInformation2 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum ClearingChannel2Code
  {

    /// <remarks/>
    RTGS,

    /// <remarks/>
    RTNS,

    /// <remarks/>
    MPNS,

    /// <remarks/>
    BOOK,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class ServiceLevel3Choice
  {

    private object itemField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Cd", typeof(ServiceLevel2Code))]
    [XmlElementAttribute("Prtry", typeof(string))]
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(ServiceLevel3Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ServiceLevel3Choice object into an XML document
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
    /// Deserializes workflow markup into an ServiceLevel3Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output ServiceLevel3Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out ServiceLevel3Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ServiceLevel3Choice);
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

    public static bool Deserialize(string xml, out ServiceLevel3Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static ServiceLevel3Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((ServiceLevel3Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static ServiceLevel3Choice Deserialize(System.IO.Stream s)
    {
      return ((ServiceLevel3Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current ServiceLevel3Choice object into file
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
    /// Deserializes xml markup from file into an ServiceLevel3Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ServiceLevel3Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ServiceLevel3Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(ServiceLevel3Choice);
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

    public static bool LoadFromFile(string fileName, out ServiceLevel3Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static ServiceLevel3Choice LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum ServiceLevel2Code
  {

    /// <remarks/>
    SEPA,

    /// <remarks/>
    SDVA,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class LocalInstrument1Choice
  {

    private string itemField;

    private ItemChoiceType2 itemElementNameField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("Cd", typeof(string))]
    [XmlElementAttribute("Prtry", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(LocalInstrument1Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current LocalInstrument1Choice object into an XML document
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
    /// Deserializes workflow markup into an LocalInstrument1Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output LocalInstrument1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out LocalInstrument1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(LocalInstrument1Choice);
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

    public static bool Deserialize(string xml, out LocalInstrument1Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static LocalInstrument1Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((LocalInstrument1Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static LocalInstrument1Choice Deserialize(System.IO.Stream s)
    {
      return ((LocalInstrument1Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current LocalInstrument1Choice object into file
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
    /// Deserializes xml markup from file into an LocalInstrument1Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output LocalInstrument1Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out LocalInstrument1Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(LocalInstrument1Choice);
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

    public static bool LoadFromFile(string fileName, out LocalInstrument1Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static LocalInstrument1Choice LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema = false)]
  public enum ItemChoiceType2
  {

    /// <remarks/>
    Cd,

    /// <remarks/>
    Prtry,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum SequenceType1Code
  {

    /// <remarks/>
    FRST,

    /// <remarks/>
    RCUR,

    /// <remarks/>
    FNAL,

    /// <remarks/>
    OOFF,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public enum PaymentCategoryPurpose1Code
  {

    /// <remarks/>
    CORT,

    /// <remarks/>
    SALA,

    /// <remarks/>
    TREA,

    /// <remarks/>
    CASH,

    /// <remarks/>
    DIVI,

    /// <remarks/>
    GOVT,

    /// <remarks/>
    INTE,

    /// <remarks/>
    LOAN,

    /// <remarks/>
    PENS,

    /// <remarks/>
    SECU,

    /// <remarks/>
    SSBE,

    /// <remarks/>
    SUPP,

    /// <remarks/>
    TAXS,

    /// <remarks/>
    TRAD,

    /// <remarks/>
    VATX,
    
    /// <remarks/>
    HEDG,

    /// <remarks/>
    INTC,

    /// <remarks/>
    WHLD,
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class PaymentInstructionInformation2
  {

    private string pmtInfIdField;

    private PaymentMethod2Code pmtMtdField;

    private PaymentTypeInformation2 pmtTpInfField;

    private System.DateTime reqdColltnDtField;

    private PartyIdentification8 cdtrField;

    private CashAccount7 cdtrAcctField;

    private BranchAndFinancialInstitutionIdentification3 cdtrAgtField;

    private CashAccount7 cdtrAgtAcctField;

    private PartyIdentification8 ultmtCdtrField;

    private ChargeBearerType1Code? chrgBrField;

    private CashAccount7 chrgsAcctField;

    private BranchAndFinancialInstitutionIdentification3 chrgsAcctAgtField;

    private List<DirectDebitTransactionInformation1> drctDbtTxInfField;

    private static XmlSerializer serializer;

    public PaymentInstructionInformation2()
    {
      this.drctDbtTxInfField = new List<DirectDebitTransactionInformation1>();
      this.chrgsAcctAgtField = new BranchAndFinancialInstitutionIdentification3();
      this.chrgsAcctField = new CashAccount7();
      this.ultmtCdtrField = new PartyIdentification8();
      this.cdtrAgtAcctField = new CashAccount7();
      this.cdtrAgtField = new BranchAndFinancialInstitutionIdentification3();
      this.cdtrAcctField = new CashAccount7();
      this.cdtrField = new PartyIdentification8();
      this.pmtTpInfField = new PaymentTypeInformation2();
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

    public PaymentTypeInformation2 PmtTpInf
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

    [XmlElementAttribute(DataType = "date")]
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

    public PartyIdentification8 Cdtr
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

    public CashAccount7 CdtrAcct
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

    public BranchAndFinancialInstitutionIdentification3 CdtrAgt
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

    public CashAccount7 CdtrAgtAcct
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

    public PartyIdentification8 UltmtCdtr
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

    [XmlIgnoreAttribute()]
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

    public CashAccount7 ChrgsAcct
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

    public BranchAndFinancialInstitutionIdentification3 ChrgsAcctAgt
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

    [XmlElementAttribute("DrctDbtTxInf")]
    public List<DirectDebitTransactionInformation1> DrctDbtTxInf
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
  }


  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class GenericIdentification4
  {

    private string idField;

    private string idTpField;

    private static XmlSerializer serializer;

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

    public string IdTp
    {
      get
      {
        return this.idTpField;
      }
      set
      {
        this.idTpField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(GenericIdentification4));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current GenericIdentification4 object into an XML document
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
    /// Deserializes workflow markup into an GenericIdentification4 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output GenericIdentification4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out GenericIdentification4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GenericIdentification4);
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

    public static bool Deserialize(string xml, out GenericIdentification4 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static GenericIdentification4 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((GenericIdentification4)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static GenericIdentification4 Deserialize(System.IO.Stream s)
    {
      return ((GenericIdentification4)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current GenericIdentification4 object into file
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
    /// Deserializes xml markup from file into an GenericIdentification4 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output GenericIdentification4 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out GenericIdentification4 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(GenericIdentification4);
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

    public static bool LoadFromFile(string fileName, out GenericIdentification4 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static GenericIdentification4 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class PersonIdentification3
  {

    private object itemField;

    private ItemChoiceType itemElementNameField;

    private string issrField;

    private static XmlSerializer serializer;

    [XmlElementAttribute("AlnRegnNb", typeof(string))]
    [XmlElementAttribute("CstmrNb", typeof(string))]
    [XmlElementAttribute("DrvrsLicNb", typeof(string))]
    [XmlElementAttribute("DtAndPlcOfBirth", typeof(DateAndPlaceOfBirth))]
    [XmlElementAttribute("IdntyCardNb", typeof(string))]
    [XmlElementAttribute("MplyrIdNb", typeof(string))]
    [XmlElementAttribute("OthrId", typeof(GenericIdentification4))]
    [XmlElementAttribute("PsptNb", typeof(string))]
    [XmlElementAttribute("SclSctyNb", typeof(string))]
    [XmlElementAttribute("TaxIdNb", typeof(string))]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
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

    [XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName
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

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(PersonIdentification3));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current PersonIdentification3 object into an XML document
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
    /// Deserializes workflow markup into an PersonIdentification3 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output PersonIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out PersonIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PersonIdentification3);
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

    public static bool Deserialize(string xml, out PersonIdentification3 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static PersonIdentification3 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((PersonIdentification3)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static PersonIdentification3 Deserialize(System.IO.Stream s)
    {
      return ((PersonIdentification3)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current PersonIdentification3 object into file
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
    /// Deserializes xml markup from file into an PersonIdentification3 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output PersonIdentification3 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out PersonIdentification3 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(PersonIdentification3);
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

    public static bool LoadFromFile(string fileName, out PersonIdentification3 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static PersonIdentification3 LoadFromFile(string fileName)
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
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema = false)]
  public enum ItemChoiceType
  {

    /// <remarks/>
    AlnRegnNb,

    /// <remarks/>
    CstmrNb,

    /// <remarks/>
    DrvrsLicNb,

    /// <remarks/>
    DtAndPlcOfBirth,

    /// <remarks/>
    IdntyCardNb,

    /// <remarks/>
    MplyrIdNb,

    /// <remarks/>
    OthrId,

    /// <remarks/>
    PsptNb,

    /// <remarks/>
    SclSctyNb,

    /// <remarks/>
    TaxIdNb,
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
  [System.SerializableAttribute()]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class OrganisationIdentification2
  {

    private string bICField;

    private string iBEIField;

    private string bEIField;

    private string eANGLNField;

    private string uSCHUField;

    private string dUNSField;

    private string bkPtyIdField;

    private string taxIdNbField;

    private GenericIdentification3 prtryIdField;

    private static XmlSerializer serializer;

    public OrganisationIdentification2()
    {
      this.prtryIdField = new GenericIdentification3();
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

    public string IBEI
    {
      get
      {
        return this.iBEIField;
      }
      set
      {
        this.iBEIField = value;
      }
    }

    public string BEI
    {
      get
      {
        return this.bEIField;
      }
      set
      {
        this.bEIField = value;
      }
    }

    public string EANGLN
    {
      get
      {
        return this.eANGLNField;
      }
      set
      {
        this.eANGLNField = value;
      }
    }

    public string USCHU
    {
      get
      {
        return this.uSCHUField;
      }
      set
      {
        this.uSCHUField = value;
      }
    }

    public string DUNS
    {
      get
      {
        return this.dUNSField;
      }
      set
      {
        this.dUNSField = value;
      }
    }

    public string BkPtyId
    {
      get
      {
        return this.bkPtyIdField;
      }
      set
      {
        this.bkPtyIdField = value;
      }
    }

    public string TaxIdNb
    {
      get
      {
        return this.taxIdNbField;
      }
      set
      {
        this.taxIdNbField = value;
      }
    }

    public GenericIdentification3 PrtryId
    {
      get
      {
        return this.prtryIdField;
      }
      set
      {
        this.prtryIdField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(OrganisationIdentification2));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current OrganisationIdentification2 object into an XML document
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
    /// Deserializes workflow markup into an OrganisationIdentification2 object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output OrganisationIdentification2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out OrganisationIdentification2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(OrganisationIdentification2);
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

    public static bool Deserialize(string xml, out OrganisationIdentification2 obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static OrganisationIdentification2 Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((OrganisationIdentification2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static OrganisationIdentification2 Deserialize(System.IO.Stream s)
    {
      return ((OrganisationIdentification2)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current OrganisationIdentification2 object into file
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
    /// Deserializes xml markup from file into an OrganisationIdentification2 object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output OrganisationIdentification2 object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out OrganisationIdentification2 obj, out System.Exception exception)
    {
      exception = null;
      obj = default(OrganisationIdentification2);
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

    public static bool LoadFromFile(string fileName, out OrganisationIdentification2 obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static OrganisationIdentification2 LoadFromFile(string fileName)
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
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
  public partial class Party2Choice
  {

    private List<object> itemsField;

    private static XmlSerializer serializer;

    public Party2Choice()
    {
      this.itemsField = new List<object>();
    }

    [XmlElementAttribute("OrgId", typeof(OrganisationIdentification2))]
    [XmlElementAttribute("PrvtId", typeof(PersonIdentification3))]
    public List<object> Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new XmlSerializer(typeof(Party2Choice));
        }
        return serializer;
      }
    }

    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current Party2Choice object into an XML document
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
    /// Deserializes workflow markup into an Party2Choice object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output Party2Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out Party2Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Party2Choice);
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

    public static bool Deserialize(string xml, out Party2Choice obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static Party2Choice Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((Party2Choice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    public static Party2Choice Deserialize(System.IO.Stream s)
    {
      return ((Party2Choice)(Serializer.Deserialize(s)));
    }

    /// <summary>
    /// Serializes current Party2Choice object into file
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
    /// Deserializes xml markup from file into an Party2Choice object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output Party2Choice object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out Party2Choice obj, out System.Exception exception)
    {
      exception = null;
      obj = default(Party2Choice);
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

    public static bool LoadFromFile(string fileName, out Party2Choice obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static Party2Choice LoadFromFile(string fileName)
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
