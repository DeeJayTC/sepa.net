// 
// SEPA.Net SEPA Parser for C# 
// https://sepa.codeplex.com
// File: TCDev.SEPA.CardTransaction1.cs
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
using System.ComponentModel;
using TCDev.SEPA.CAMT.Generic.PointOfInteraction;

namespace TCDev.SEPA.CAMT.Generic.Card
{
  [Serializable()]
  [DesignerCategory("code")]
  public partial class CardTransaction1
  {

    private PaymentCard4 cardField;

    private PointOfInteraction1 pOIField;

    private CardTransaction1Choice txField;

    public CardTransaction1()
    {
      this.txField = new CardTransaction1Choice();
      this.pOIField = new PointOfInteraction1();
      this.cardField = new PaymentCard4();
    }

    public PaymentCard4 Card
    {
      get
      {
        return this.cardField;
      }
      set
      {
        this.cardField = value;
      }
    }

    public PointOfInteraction1 POI
    {
      get
      {
        return this.pOIField;
      }
      set
      {
        this.pOIField = value;
      }
    }

    public CardTransaction1Choice Tx
    {
      get
      {
        return this.txField;
      }
      set
      {
        this.txField = value;
      }
    }
  }
}