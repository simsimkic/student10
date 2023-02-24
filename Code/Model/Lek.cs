/***********************************************************************
 * Module:  Lek.cs
 * Purpose: Definition of the Class Model.Lek
 ***********************************************************************/

using System;

namespace Dtos
{
   public class Lek
   {
      public System.Collections.ArrayList recept;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRecept()
      {
         if (recept == null)
            recept = new System.Collections.ArrayList();
         return recept;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRecept(System.Collections.ArrayList newRecept)
      {
         RemoveAllRecept();
         foreach (Recept oRecept in newRecept)
            AddRecept(oRecept);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRecept(Recept newRecept)
      {
         if (newRecept == null)
            return;
         if (this.recept == null)
            this.recept = new System.Collections.ArrayList();
         if (!this.recept.Contains(newRecept))
            this.recept.Add(newRecept);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecept(Recept oldRecept)
      {
         if (oldRecept == null)
            return;
         if (this.recept != null)
            if (this.recept.Contains(oldRecept))
               this.recept.Remove(oldRecept);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecept()
      {
         if (recept != null)
            recept.Clear();
      }
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
               oldApoteka.RemoveLek(this);
            }
            if (newApoteka != null)
            {
               this.apoteka = newApoteka;
               this.apoteka.AddLek(this);
            }
         }
      }
   
      private string sifra;
      private string ime;
      private string proizvodjac;
      private bool izdajeSeNaRecept;
      private float cena;
      private bool brisan = false;
   
   }
}