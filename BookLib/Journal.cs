﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
   public class Journal : AbstractItem
    {
        
        public Journal(string name, double edition, int copies, Theme theme, Categories category, double price) : base(name, edition, copies, theme, category,price)
        {
         
           
            ItemCollection.AddToLibrary(this);
        }
       
        
    }
}
