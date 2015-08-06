using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GwentApp.Models
{
    
    public class Player
    {
        /// <summary>
        /// This is the player faction
        /// </summary>
        public string faction
        {
            get;
            set;
        }
        public static List<SelectListItem> factionselectlistitems
        {
            get
            {
                List<SelectListItem> listitems = new List<SelectListItem>();
                SelectListItem f1 = new SelectListItem() { Value = "NE", Text = "Nilfgaardian Empire" };
                listitems.Add(f1);
                SelectListItem f2 = new SelectListItem() { Value = "NK", Text = "Northern Kingdoms" };
                listitems.Add(f2);
                SelectListItem f3 = new SelectListItem() { Value = "ST", Text = "Scoia'tael" };
                listitems.Add(f3);
                SelectListItem f4 = new SelectListItem() { Value = "MS", Text = "Monsters" };
                listitems.Add(f4);
                return listitems;
            }
        }
    }
}