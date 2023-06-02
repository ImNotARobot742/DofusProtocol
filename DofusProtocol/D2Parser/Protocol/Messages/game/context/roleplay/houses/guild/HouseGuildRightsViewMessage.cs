

// Generated on 06/02/2023 19:00:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseGuildRightsViewMessage : NetworkMessage
    {
        public const uint Id = 5524;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint houseId;
        public int instanceId;
        
        public HouseGuildRightsViewMessage()
        {
        }
        
        public HouseGuildRightsViewMessage(uint houseId, int instanceId)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            houseId = reader.ReadVarUInt();
            instanceId = reader.ReadInt();
        }
        
    }
    
}