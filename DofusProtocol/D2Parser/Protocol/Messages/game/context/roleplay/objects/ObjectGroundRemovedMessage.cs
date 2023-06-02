

// Generated on 06/02/2023 19:00:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectGroundRemovedMessage : NetworkMessage
    {
        public const uint Id = 4405;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cell;
        
        public ObjectGroundRemovedMessage()
        {
        }
        
        public ObjectGroundRemovedMessage(uint cell)
        {
            this.cell = cell;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)cell);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cell = reader.ReadVarUShort();
        }
        
    }
    
}