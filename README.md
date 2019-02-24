Project Description
SEPA.Net is a parser for SEPA XML Messages based on ISO 2022. 

The parser can read and create messages that comply to the iso 20022 formats. 
At the moment Pain and camt are supported. We´re in the process of adding all the other messages.

When reading data, the parser can automatically decide which message format to choose based on the xml namespace tag. Simply load any xml file and the parser deserializes the xml file into a .net data structure which can be used for any purpose. Transactions in camt messages can be filtered using linq statements. 

Our Utility Library TCDev.SEPA.Utilities contains a couple of helpful things, like an IBAN Creator for example. 

The Parser is now able to automatically detect which SEPA Type to use. 
Parsing takes just 2 lines of code Read our implementation guide

In it´s current version the parser supports SEPA v3, v4 and v5 messages based on the shemes from may 2013.
http://www.iso20022.org/full_catalogue.page
http://www.iso20022.org/message_archive.page 

Read the list of Supported Messages.
Browse the Examples
Read our implementation guide
Update history
14.11.2013 - v.0.2
Renamed a couple of Attributes for CAMT_52
Added a couple of Messages
Completed File Type Auto Detection

07.09.2013 - v.0.1
Project added.
