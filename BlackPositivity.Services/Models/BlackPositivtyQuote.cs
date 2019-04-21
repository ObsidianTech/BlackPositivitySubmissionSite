using System;
using System.Collections.Generic;
using System.Text;

namespace BlackPositivity.Services.Models
{
    public class BlackPositivtyQuote
    {
        public Guid ID { get; set; }
        public string Contributor { get; set; }
        public string Quote { get; set; }
        public bool hasBeenUsed { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
