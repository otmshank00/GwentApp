using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwentApp.Models
{
    public class Card
    {
        /// <summary>
        /// strength of card
        /// </summary>
        public int power
        {
            get; set;
        }
        /// <summary>
        /// name or type of unit
        /// </summary>
        public string name
        {
            get; set;
        }
    }
}
