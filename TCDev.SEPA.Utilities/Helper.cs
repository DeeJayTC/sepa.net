// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Utilities.Helper.cs
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
using System.Text;
// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.Utilities.Helper.cs
// Author: Tim Cadenbach, TCDev    
// Created: 08.09.2013 -  TCA
// Changed: 08.09.2013 -  TCA
// Purpose:                                                
//                                                          
// Licensed under Microsoft Public License (Ms-PL)         
// https://sepa.codeplex.com/license                       
// 
// Recent Changes:                                 
// ==========================================================
using TCDev.SEPA.PAIN;
using TCDev.SEPA.Parser;

namespace TCDev.SEPA.Utilities
{
  public class Helper
  {
    public static int Modulo(string sModulus, int iTeiler)
    {
      int iStart, iEnde, iErgebniss, iRestTmp, iBuffer;
      string iRest = "", sErg = "";

      iStart = 0;
      iEnde = 0;

      while (iEnde <= sModulus.Length - 1)
      {
        iBuffer = int.Parse(iRest + sModulus.Substring(iStart, iEnde - iStart + 1));

        if (iBuffer >= iTeiler)
        {
          iErgebniss = iBuffer / iTeiler;
          iRestTmp = iBuffer - iErgebniss * iTeiler;
          iRest = iRestTmp.ToString();

          sErg = sErg + iErgebniss.ToString();

          iStart = iEnde + 1;
          iEnde = iStart;
        }
        else
        {
          if (sErg != "")
            sErg = sErg + "0";

          iEnde = iEnde + 1;
        }
      }

      if (iStart <= sModulus.Length)
        iRest = iRest + sModulus.Substring(iStart);

      return int.Parse(iRest);
    }

    public static bool IsNumeric(string value)
    {
      try
      {
        int.Parse(value);
        return (true);
      }
      catch
      {
        return (false);
      }
    }



    



  }
}