

// Generated on 06/13/2023 16:59:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
    {
        public const uint Id = 1463;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectGID;
        public int objectType;
        public Types.BidExchangerObjectInfo[] itemTypeDescriptions;
        
        public ExchangeTypesItemsExchangerDescriptionForUserMessage()
        {
        }
        
        public ExchangeTypesItemsExchangerDescriptionForUserMessage(uint objectGID, int objectType, Types.BidExchangerObjectInfo[] itemTypeDescriptions)
        {
            this.objectGID = objectGID;
            this.objectType = objectType;
            this.itemTypeDescriptions = itemTypeDescriptions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            writer.WriteShort((short)itemTypeDescriptions.Length);
            foreach (var entry in itemTypeDescriptions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectGID = reader.ReadVarUInt();
            objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            itemTypeDescriptions = new Types.BidExchangerObjectInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 itemTypeDescriptions[i] = new Types.BidExchangerObjectInfo();
                 itemTypeDescriptions[i].Deserialize(reader);
            }
        }
        
    }
    
}