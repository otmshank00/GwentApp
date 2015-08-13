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
                listitems.Add(new SelectListItem() { Value = "NK", Text = "Northern Kingdoms" });
                listitems.Add(new SelectListItem() { Value = "ST", Text = "Scoia'tael" });
                listitems.Add(new SelectListItem() { Value = "MS", Text = "Monsters" });
                return listitems;
            }
        }
        public static List<SelectListItem> nkleaderlist
        {
            get
            {
                List<SelectListItem> leaderlist = new List<SelectListItem>();
                leaderlist.Add(new SelectListItem() { Value = "NK", Text = "Foltest the steel forged" });
                leaderlist.Add(new SelectListItem() { Value = "NK", Text = "Foltest Lord commander of the North" });
                leaderlist.Add(new SelectListItem() { Value = "NK", Text = "Foltest King of Temeria" });
                leaderlist.Add(new SelectListItem() { Value = "NK", Text = "Foltest the Siegemaster" });
                return leaderlist;
            }
        }
        public static List<SelectListItem> neleaderlist
        {
            get
            {
                List<SelectListItem> leaderlist = new List<SelectListItem>();
                leaderlist.Add(new SelectListItem() { Value = "NE", Text = "Emhyr var Emreis His Imperial Majesty" });
                leaderlist.Add(new SelectListItem() { Value = "NE", Text = "Emhyr var Emreis the Relentless" });
                leaderlist.Add(new SelectListItem() { Value = "NE", Text = "Emhyr var Emreis Emperor of Nilfgaard" });
                leaderlist.Add(new SelectListItem() { Value = "NE", Text = "Emhyr var Emreis the White Flame" });
                return leaderlist;
            }
        }
    }
}