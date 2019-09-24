using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public class POD : Inventory
    {
        public POD()
        {
            this.ID = Guid.Empty;
            this.SeqID = 0;
            this.Address = 0;
            this.Size = 0;
            this.Revision = string.Empty;
            this.Open = false;
            this.Eject = false;
            this.Assigned = false;
        } 
        public int Size { get; set; }
 
        public bool Open { get; set; }
 
        public bool Eject { get; set; }
 
        public bool Assigned { get; set; }
    }
}
