

// Generated on 03/23/2022 09:50:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismFightRemovedMessage : NetworkMessage
    {
        public const uint Id = 4052;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        
        public PrismFightRemovedMessage()
        {
        }
        
        public PrismFightRemovedMessage(uint subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
        }
        
    }
    
}