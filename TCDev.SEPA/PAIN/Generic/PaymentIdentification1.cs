using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ==========================================================
// SEPA.Net SEPA Parser for C#                             ==
// https://sepa.codeplex.com                               ==
// File: PaymentIdentification1.cs                             ==
// Author: Tim Cadenbach, TCDev                            ==
// Created: 07.09.2013                                     ==
// Purpose:                                                ==
//                                                         ==
// Licensed under Microsoft Public License (Ms-PL)         ==
// https://sepa.codeplex.com/license                       ==
// Latest Changes                                          ==
// ==========================================================

using System.Xml.Serialization;


namespace TCDev.SEPA.PAIN.Generic
{
  [SerializableAttribute()]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03", TypeName = "PaymentIdentification1")]
  [XmlRoot("PaymentIdentification1")]
  public partial class PaymentIdentification1
  {

    [XmlElement(Order = 0, ElementName = "InstrId")]
    public string InstrId { get; set; }
    [XmlElement(Order = 1, ElementName = "EndToEndId")]
    public string EndToEndId { get; set; }
  }
}
