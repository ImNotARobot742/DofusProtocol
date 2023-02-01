

// Generated on 02/01/2023 12:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceKickRequestMessage : NetworkMessage
    {
        public const uint Id = 2717;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint kickedId;
        
        public AllianceKickRequestMessage()
        {
        }
        
        public AllianceKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)kickedId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            kickedId = reader.ReadVarUInt();
        }
        
    }
    
}