using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public class Tier : Inventory
    {
        public Tier()
        {
            this.SeqID = 0;
            this.ID = Guid.Empty;
            this.Address = 0;
            this.Revision = string.Empty;
            this.Drawers = new List<Drawer>();

        }

        public List<Drawer> Drawers { get; set; }


    }
}
