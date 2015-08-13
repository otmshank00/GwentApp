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
        /// <summary>
        /// This is the player selected leader
        /// </summary>
        public string leader
        {
            get;
            set;
        }
        public static List<SelectListItem> factionselectlistitems
        {
            get
            {
                List<SelectListItem> listitems = new List<SelectListItem>();
                listitems.Add(new SelectListItem() { Value = "NE", Text = "Nilfgaardian Empire" });
                listitems.Add(new SelectListItem() { Value = "NR", Text = "Northern Realms" });
                listitems.Add(new SelectListItem() { Value = "ST", Text = "Scoia'tael" });
                listitems.Add(new SelectListItem() { Value = "MS", Text = "Monsters" });
                return listitems;
            }
        }
        
    }
}