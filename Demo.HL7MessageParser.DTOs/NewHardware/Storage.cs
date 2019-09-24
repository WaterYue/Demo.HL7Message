using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public class Storage
    {

        public Guid ID { get; set; }
        public Storage()
        {
            this.ID = Guid.Empty;
            this.Revision = string.Empty;
            this.LED = null;
            this.Locks = new List<Lock>();
        }

        //  Firmware revision of the Storage controller  

        public string Revision { get; set; }

        //  LED lighting control
        //  null: it is not present
        //  false: it is present and off
        //  true: it is present and on

        public bool? LED { get; set; }

        //  
        //  List of Locks

        public List<Lock> Locks { get; set; }
    }
}
