/***********************************************************************
 * Module:  Admin.cs
 * Purpose: Definition of the Class Model.Admin
 ***********************************************************************/

using System;

namespace Dtos
{
   public class Admin : Korisnik
   {
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
               oldApoteka.RemoveAdmin(this);
            }
            if (newApoteka != null)
            {
               this.apoteka = newApoteka;
               this.apoteka.AddAdmin(this);
            }
         }
      }
   
      private string id;
   
   }
}