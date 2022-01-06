

// Generated on 01/01/2022 14:39:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InteractiveUseEndedMessage : NetworkMessage
    {
        public const uint Id = 4234;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint elemId;
        public uint skillId;
        
        public InteractiveUseEndedMessage()
        {
        }
        
        public InteractiveUseEndedMessage(uint elemId, uint skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((short)skillId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            elemId = reader.ReadVarUInt();
            skillId = reader.ReadVarUShort();
        }
        
    }
    
}