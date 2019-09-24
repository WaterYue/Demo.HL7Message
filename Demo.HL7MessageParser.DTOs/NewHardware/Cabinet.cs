using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public class Cabinet : Inventory
    {
        public Cabinet()
        {
            this.ID = Guid.Empty;
            this.Address = 0;
            this.Revision = string.Empty;
            this.Storage = null;
            this.Tiers = new List<Tier>();
            this.SeqID = 0;
        }


        public int StationID { get; set; }

        //  Storage Controller

        public Storage Storage { get; set; }

        //  List of Tiers
        //[DataMember]

        public List<Tier> Tiers { get; set; }
    }
}
