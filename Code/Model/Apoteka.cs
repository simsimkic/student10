/***********************************************************************
 * Module:  Apoteka.cs
 * Purpose: Definition of the Class Model.Apoteka
 ***********************************************************************/

using System;

namespace Dtos
{
   public class Apoteka
   {
      public System.Collections.ArrayList apotekar;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetApotekar()
      {
         if (apotekar == null)
            apotekar = new System.Collections.ArrayList();
         return apotekar;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetApotekar(System.Collections.ArrayList newApotekar)
      {
         RemoveAllApotekar();
         foreach (Apotekar oApotekar in newApotekar)
            AddApotekar(oApotekar);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddApotekar(Apotekar newApotekar)
      {
         if (newApotekar == null)
            return;
         if (this.apotekar == null)
            this.apotekar = new System.Collections.ArrayList();
         if (!this.apotekar.Contains(newApotekar))
         {
            this.apotekar.Add(newApotekar);
            newApotekar.SetApoteka(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveApotekar(Apotekar oldApotekar)
      {
         if (oldApotekar == null)
            return;
         if (this.apotekar != null)
            if (this.apotekar.Contains(oldApotekar))
            {
               this.apotekar.Remove(oldApotekar);
               oldApotekar.SetApoteka((Apoteka)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllApotekar()
      {
         if (apotekar != null)
         {
            System.Collections.ArrayList tmpApotekar = new System.Collections.ArrayList();
            foreach (Apotekar oldApotekar in apotekar)
               tmpApotekar.Add(oldApotekar);
            apotekar.Clear();
            foreach (Apotekar oldApotekar in tmpApotekar)
               oldApotekar.SetApoteka((Apoteka)null);
            tmpApotekar.Clear();
         }
      }
      public System.Collections.ArrayList admin;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAdmin()
      {
         if (admin == null)
            admin = new System.Collections.ArrayList();
         return admin;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAdmin(System.Collections.ArrayList newAdmin)
      {
         RemoveAllAdmin();
         foreach (Admin oAdmin in newAdmin)
            AddAdmin(oAdmin);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAdmin(Admin newAdmin)
      {
         if (newAdmin == null)
            return;
         if (this.admin == null)
            this.admin = new System.Collections.ArrayList();
         if (!this.admin.Contains(newAdmin))
         {
            this.admin.Add(newAdmin);
            newAdmin.SetApoteka(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAdmin(Admin oldAdmin)
      {
         if (oldAdmin == null)
            return;
         if (this.admin != null)
            if (this.admin.Contains(oldAdmin))
            {
               this.admin.Remove(oldAdmin);
               oldAdmin.SetApoteka((Apoteka)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAdmin()
      {
         if (admin != null)
         {
            System.Collections.ArrayList tmpAdmin = new System.Collections.ArrayList();
            foreach (Admin oldAdmin in admin)
               tmpAdmin.Add(oldAdmin);
            admin.Clear();
            foreach (Admin oldAdmin in tmpAdmin)
               oldAdmin.SetApoteka((Apoteka)null);
            tmpAdmin.Clear();
         }
      }
      public System.Collections.ArrayList lekar;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetLekar()
      {
         if (lekar == null)
            lekar = new System.Collections.ArrayList();
         return lekar;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetLekar(System.Collections.ArrayList newLekar)
      {
         RemoveAllLekar();
         foreach (Lekar oLekar in newLekar)
            AddLekar(oLekar);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddLekar(Lekar newLekar)
      {
         if (newLekar == null)
            return;
         if (this.lekar == null)
            this.lekar = new System.Collections.ArrayList();
         if (!this.lekar.Contains(newLekar))
         {
            this.lekar.Add(newLekar);
            newLekar.SetApoteka(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveLekar(Lekar oldLekar)
      {
         if (oldLekar == null)
            return;
         if (this.lekar != null)
            if (this.lekar.Contains(oldLekar))
            {
               this.lekar.Remove(oldLekar);
               oldLekar.SetApoteka((Apoteka)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllLekar()
      {
         if (lekar != null)
         {
            System.Collections.ArrayList tmpLekar = new System.Collections.ArrayList();
            foreach (Lekar oldLekar in lekar)
               tmpLekar.Add(oldLekar);
            lekar.Clear();
            foreach (Lekar oldLekar in tmpLekar)
               oldLekar.SetApoteka((Apoteka)null);
            tmpLekar.Clear();
         }
      }
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
         {
            this.recept.Add(newRecept);
            newRecept.SetApoteka(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecept(Recept oldRecept)
      {
         if (oldRecept == null)
            return;
         if (this.recept != null)
            if (this.recept.Contains(oldRecept))
            {
               this.recept.Remove(oldRecept);
               oldRecept.SetApoteka((Apoteka)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecept()
      {
         if (recept != null)
         {
            System.Collections.ArrayList tmpRecept = new System.Collections.ArrayList();
            foreach (Recept oldRecept in recept)
               tmpRecept.Add(oldRecept);
            recept.Clear();
            foreach (Recept oldRecept in tmpRecept)
               oldRecept.SetApoteka((Apoteka)null);
            tmpRecept.Clear();
         }
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
         {
            this.racun.Add(newRacun);
            newRacun.SetApoteka(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRacun(Racun oldRacun)
      {
         if (oldRacun == null)
            return;
         if (this.racun != null)
            if (this.racun.Contains(oldRacun))
            {
               this.racun.Remove(oldRacun);
               oldRacun.SetApoteka((Apoteka)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRacun()
      {
         if (racun != null)
         {
            System.Collections.ArrayList tmpRacun = new System.Collections.ArrayList();
            foreach (Racun oldRacun in racun)
               tmpRacun.Add(oldRacun);
            racun.Clear();
            foreach (Racun oldRacun in tmpRacun)
               oldRacun.SetApoteka((Apoteka)null);
            tmpRacun.Clear();
         }
      }
      public System.Collections.ArrayList lek;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetLek()
      {
         if (lek == null)
            lek = new System.Collections.ArrayList();
         return lek;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetLek(System.Collections.ArrayList newLek)
      {
         RemoveAllLek();
         foreach (Lek oLek in newLek)
            AddLek(oLek);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddLek(Lek newLek)
      {
         if (newLek == null)
            return;
         if (this.lek == null)
            this.lek = new System.Collections.ArrayList();
         if (!this.lek.Contains(newLek))
         {
            this.lek.Add(newLek);
            newLek.SetApoteka(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveLek(Lek oldLek)
      {
         if (oldLek == null)
            return;
         if (this.lek != null)
            if (this.lek.Contains(oldLek))
            {
               this.lek.Remove(oldLek);
               oldLek.SetApoteka((Apoteka)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllLek()
      {
         if (lek != null)
         {
            System.Collections.ArrayList tmpLek = new System.Collections.ArrayList();
            foreach (Lek oldLek in lek)
               tmpLek.Add(oldLek);
            lek.Clear();
            foreach (Lek oldLek in tmpLek)
               oldLek.SetApoteka((Apoteka)null);
            tmpLek.Clear();
         }
      }
   
      private string ImeApoteke;
   
   }
}