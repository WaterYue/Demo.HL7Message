using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public class Drawer : Inventory
    {
        public Drawer()
        {
            this.SeqID = 0;
            this.ID = Guid.Empty;
            //this.Smart = false;
            this.Type = 0;
            this.Address = 0;
            this.Revision = string.Empty;
            //this.CS = false;
            this.PODs = new List<POD>();
            this.ID = Guid.Empty;
        }
        public long Type { get; set; }

        public bool Open { get; set; }

        public  List<POD> PODs { get; set; }
    }
}
