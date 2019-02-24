// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.XMLStringSerializer.cs
// Author: Tim Cadenbach, TCDev    
// Created: 07.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TCDev.SEPA.Parser
{
  public static class XMLStringSerializer
  {
    public static string XmlSerializeToString(this object objectInstance)
    {
      var serializer = new XmlSerializer(objectInstance.GetType());
      var sb = new StringBuilder();

      using (TextWriter writer = new StringWriter(sb))
      {
        serializer.Serialize(writer, objectInstance);
      }

      return sb.ToString();
    }

    public static T XmlDeserializeFromString<T>(string objectData)
    {
      return (T)XmlDeserializeFromString(objectData, typeof(T));
    }

    public static object XmlDeserializeFromString(string objectData, Type type)
    {
      var serializer = new XmlSerializer(type);
      object result;

      using (TextReader reader = new StringReader(objectData))
      {
        result = serializer.Deserialize(reader);
      }

      return result;
    } 
  }
}