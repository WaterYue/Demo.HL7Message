using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public abstract class Inventory
    {
        public Guid ID { get; set; }

        public int SeqID { get; set; }

        public int Address { get; set; }

        public string Revision { get; set; }
    }
}
