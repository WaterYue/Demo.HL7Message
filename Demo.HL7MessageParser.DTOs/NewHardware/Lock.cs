using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.HL7MessageParser.DTOs
{
    [Serializable]
    public class Lock
    {
        public Guid ID { get; set; }
        public Lock()
        {
            this.Position = 0;
            this.ID = Guid.Empty;
        }
        //  For a storage controller will have a value from 1 to 8
        //  For a tier controller will have a value from 1 to 6
        public int Position { get; set; }
    }
}
