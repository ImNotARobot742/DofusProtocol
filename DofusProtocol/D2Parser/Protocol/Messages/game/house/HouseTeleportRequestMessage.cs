

// Generated on 05/18/2023 15:10:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseTeleportRequestMessage : NetworkMessage
    {
        public const uint Id = 6980;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint houseId;
        public int houseInstanceId;
        
        public HouseTeleportRequestMessage()
        {
        }
        
        public HouseTeleportRequestMessage(uint houseId, int houseInstanceId)
        {
            this.houseId = houseId;
            this.houseInstanceId = houseInstanceId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(houseInstanceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            houseId = reader.ReadVarUInt();
            houseInstanceId = reader.ReadInt();
        }
        
    }
    
}