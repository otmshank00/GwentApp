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
                for (int i = 1; i < 5; i++)
                {
                    SelectListItem item = new SelectListItem();
                    string name = "faction" + i;
                    item.Value = name;
                    item.Text = name;
                    listitems.Add(item);

                }
                return listitems;
            }
        }
    }
}