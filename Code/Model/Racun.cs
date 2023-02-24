/***********************************************************************
 * Module:  Racun.cs
 * Purpose: Definition of the Class Model.Racun
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Dtos
{
   public class Racun
   {
      public Lek[] lek;
      public Recept[] recept;
      public Apoteka apoteka;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Apoteka GetApoteka()
      {
         return apoteka;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newApoteka</param>
      public void SetApoteka(Apoteka newApoteka)
      {
         if (this.apoteka != newApoteka)
         {
            if (this.apoteka != null)
            {
               Apoteka oldApoteka = this.apoteka;
               this.apoteka = null;
               oldApoteka.RemoveRacun(this);
            }
            if (newApoteka != null)
            {
               this.apoteka = newApoteka;
               this.apoteka.AddRacun(this);
            }
         }
      }
   
      private int sifra;
      private string apotekar;
      private string datum;
      private Dictionary <string,float> lekoviKolicina;
      private float ukupnaCena;
   
   }
}