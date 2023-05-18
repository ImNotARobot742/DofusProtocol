

// Generated on 05/18/2023 15:10:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseToSellFilterMessage : NetworkMessage
    {
        public const uint Id = 4538;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int areaId;
        public sbyte atLeastNbRoom;
        public sbyte atLeastNbChest;
        public uint skillRequested;
        public double maxPrice;
        public sbyte orderBy;
        
        public HouseToSellFilterMessage()
        {
        }
        
        public HouseToSellFilterMessage(int areaId, sbyte atLeastNbRoom, sbyte atLeastNbChest, uint skillRequested, double maxPrice, sbyte orderBy)
        {
            this.areaId = areaId;
            this.atLeastNbRoom = atLeastNbRoom;
            this.atLeastNbChest = atLeastNbChest;
            this.skillRequested = skillRequested;
            this.maxPrice = maxPrice;
            this.orderBy = orderBy;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(areaId);
            writer.WriteSbyte(atLeastNbRoom);
            writer.WriteSbyte(atLeastNbChest);
            writer.WriteVarShort((short)skillRequested);
            writer.WriteVarLong(maxPrice);
            writer.WriteSbyte(orderBy);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            areaId = reader.ReadInt();
            atLeastNbRoom = reader.ReadSbyte();
            atLeastNbChest = reader.ReadSbyte();
            skillRequested = reader.ReadVarUShort();
            maxPrice = reader.ReadVarULong();
            orderBy = reader.ReadSbyte();
        }
        
    }
    
}