/***********************************************************************
 * Module:  Recept.cs
 * Purpose: Definition of the Class Model.Recept
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Dtos
{
   public class Recept
   {
      public System.Collections.ArrayList racun;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRacun()
      {
         if (racun == null)
            racun = new System.Collections.ArrayList();
         return racun;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRacun(System.Collections.ArrayList newRacun)
      {
         RemoveAllRacun();
         foreach (Racun oRacun in newRacun)
            AddRacun(oRacun);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRacun(Racun newRacun)
      {
         if (newRacun == null)
            return;
         if (this.racun == null)
            this.racun = new System.Collections.ArrayList();
         if (!this.racun.Contains(newRacun))
            this.racun.Add(newRacun);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRacun(Racun oldRacun)
      {
         if (oldRacun == null)
            return;
         if (this.racun != null)
            if (this.racun.Contains(oldRacun))
               this.racun.Remove(oldRacun);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRacun()
      {
         if (racun != null)
            racun.Clear();
      }
      public Lek[] lek;
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
               oldApoteka.RemoveRecept(this);
            }
            if (newApoteka != null)
            {
               this.apoteka = newApoteka;
               this.apoteka.AddRecept(this);
            }
         }
      }
   
      private int sifra;
      private string lekar;
      private string jbmgPacijenta;
      private string datum;
      private Dictionary<string,float> lekoviKolicina;
   
   }
}