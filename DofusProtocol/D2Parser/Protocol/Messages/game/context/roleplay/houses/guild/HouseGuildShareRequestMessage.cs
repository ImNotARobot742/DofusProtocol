

// Generated on 01/01/2022 14:39:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseGuildShareRequestMessage : NetworkMessage
    {
        public const uint Id = 5595;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint houseId;
        public int instanceId;
        public bool enable;
        public uint rights;
        
        public HouseGuildShareRequestMessage()
        {
        }
        
        public HouseGuildShareRequestMessage(uint houseId, int instanceId, bool enable, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.enable = enable;
            this.rights = rights;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(enable);
            writer.WriteVarInt((int)rights);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            houseId = reader.ReadVarUInt();
            instanceId = reader.ReadInt();
            enable = reader.ReadBoolean();
            rights = reader.ReadVarUInt();
        }
        
    }
    
}