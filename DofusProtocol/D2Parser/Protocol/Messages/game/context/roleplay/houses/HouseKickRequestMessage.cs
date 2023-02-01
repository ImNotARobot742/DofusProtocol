

// Generated on 02/01/2023 12:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseKickRequestMessage : NetworkMessage
    {
        public const uint Id = 6760;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        
        public HouseKickRequestMessage()
        {
        }
        
        public HouseKickRequestMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarULong();
        }
        
    }
    
}