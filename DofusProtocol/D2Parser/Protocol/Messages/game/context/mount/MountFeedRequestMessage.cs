

// Generated on 06/13/2023 16:59:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountFeedRequestMessage : NetworkMessage
    {
        public const uint Id = 5261;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint mountUid;
        public sbyte mountLocation;
        public uint mountFoodUid;
        public uint quantity;
        
        public MountFeedRequestMessage()
        {
        }
        
        public MountFeedRequestMessage(uint mountUid, sbyte mountLocation, uint mountFoodUid, uint quantity)
        {
            this.mountUid = mountUid;
            this.mountLocation = mountLocation;
            this.mountFoodUid = mountFoodUid;
            this.quantity = quantity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)mountUid);
            writer.WriteSbyte(mountLocation);
            writer.WriteVarInt((int)mountFoodUid);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mountUid = reader.ReadVarUInt();
            mountLocation = reader.ReadSbyte();
            mountFoodUid = reader.ReadVarUInt();
            quantity = reader.ReadVarUInt();
        }
        
    }
    
}