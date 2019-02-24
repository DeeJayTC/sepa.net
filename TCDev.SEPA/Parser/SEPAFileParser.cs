// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.SEPAFileParser.cs
// Author: Tim Cadenbach, TCDev    
// Created: 07.09.2013 -  TCA
// Changed: 13.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:
// 19.11.2013 - TCA - Added Save to file, toStream methods                          
// ==========================================================
using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace TCDev.SEPA.Parser
{
    /// <summary>
    /// The sepa file parser.
    /// </summary>
    public static class SEPAFileParser
    {
        /// <summary>
        /// Loads any XML SEPA File into an Object of given Type
        /// </summary>
        /// <param name="filename">
        /// The filename.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public static object LoadFromFile(string filename)
        {
            var sr = new StreamReader(filename, new UTF8Encoding());
            string typeName = "";
            string className = "";
            Type sepaType;

            // Read File and Close Stream
            string fileContent = sr.ReadToEnd();
            sr.Close();

            // Find Type to use using Regex and SEPA Namespace
            var search = new Regex(@"urn:iso:std:iso:20022:tech:xsd:(.*\.*\.*\.*)");

            Match result = search.Match(fileContent);
            if (result.Success)
            {
                className = result.Groups[1].Value.Replace(".", "_").Replace("xmlns", "");
                className = className.Replace(">", "").Replace("\"", "");
                search = new Regex(@"(\D*)_");
                result = search.Match(className);
                typeName = result.Groups[1].Value.ToUpper();

                sepaType = Type.GetType("TCDev.SEPA." + typeName + "." + className);
                if (sepaType == null) return new ParserException() { ExceptionText = "The Type " + typeName + "." + className + " is currently not supported." };

                return XMLStringSerializer.XmlDeserializeFromString(fileContent, sepaType);

            }

            return new ParserException()
            {
                ExceptionText = "Typname could not be found." +
                                "Type lookup needs xml namespace format: xmlns='urn:iso:std:iso:20022:tech:xsd:xxx.xxx.xxx.xx"
            };
        }

        /// <summary>
        /// Saves any SEPA Object to file
        /// </summary>
        /// <param name="data">SEPA Data</param>
        /// <param name="filename">Target FileName</param>
        public static void SaveToFile(this object data, string filename)
        {
            // 1st -> Serialize the object
            var fileContent = data.SerializeToString();

            // 3rd -> Save file to destination
            System.IO.File.WriteAllText(filename, fileContent, Encoding.UTF8);
        }

        /// <summary>
        /// The serialize to string.
        /// </summary>
        /// <param name="toSerialize">
        /// The to serialize.
        /// </param>
        /// <typeparam name="T">any type to serialize
        /// </typeparam>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string SerializeToString<T>(this T toSerialize)
        {
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            var textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }

        /// <summary>
        /// The xml serialize.
        /// </summary>
        /// <param name="objectInstance">
        /// The object instance.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string XmlSerialize(this object objectInstance)
        {
            var serializer = new XmlSerializer(objectInstance.GetType());
            var sb = new StringBuilder();

            using (TextWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, objectInstance);
            }

            return sb.ToString();
        }

        /// <summary> The xml deserialize. </summary>
        /// <param name="objectData"> The object data.</param>
        /// <typeparam name="T"> Any Type</typeparam>
        /// <returns> The <see cref="T"/>.</returns>
        public static T XmlDeserialize<T>(string objectData)
        {
            return (T)XmlDeserialize(objectData, typeof(T));
        }

        /// <summary>
        /// The xml deserialize.
        /// </summary>
        /// <param name="objectData">
        /// The object data.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public static object XmlDeserialize(string objectData, Type type)
        {
            var serializer = new XmlSerializer(type);
            object result;

            using (TextReader reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }

            return result;
        }

        /// <summary>
        /// Checks if an object is serializable or not
        /// </summary>
        /// <param name="obj">anything</param>
        /// <returns>true or false</returns>
        public static bool IsSerializable(this object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj", "Object can´t be serialized: Object is null!");
            }

            if (!obj.GetType().IsSerializable)
            {
                throw new SerializationException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "Object of Type {0} can´t be serialized, type is not serializable.",
                        obj.GetType().Name));
            }

            return true;
        }

        /// <summary>
        /// Converts an object to Stream of XML or JSON Data
        /// Object must be serializable!
        /// </summary>
        /// <param name="obj">
        /// </param>
        /// <returns>
        /// Stream containing serialized data
        /// </returns>
        public static Stream ToStream(this object obj)
        {
            if (!obj.IsSerializable()) return null;
            try
            {
                Stream stream = new MemoryStream();
                var xmlSerializer = new XmlSerializer(obj.GetType());
                xmlSerializer.Serialize(stream, obj);
                return stream;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
