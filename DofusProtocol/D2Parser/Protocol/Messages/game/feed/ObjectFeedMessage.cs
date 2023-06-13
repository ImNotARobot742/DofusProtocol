

// Generated on 06/13/2023 16:59:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectFeedMessage : NetworkMessage
    {
        public const uint Id = 4248;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        public Types.ObjectItemQuantity[] meal;
        
        public ObjectFeedMessage()
        {
        }
        
        public ObjectFeedMessage(uint objectUID, Types.ObjectItemQuantity[] meal)
        {
            this.objectUID = objectUID;
            this.meal = meal;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteShort((short)meal.Length);
            foreach (var entry in meal)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUInt();
            var limit = (ushort)reader.ReadUShort();
            meal = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 meal[i] = new Types.ObjectItemQuantity();
                 meal[i].Deserialize(reader);
            }
        }
        
    }
    
}