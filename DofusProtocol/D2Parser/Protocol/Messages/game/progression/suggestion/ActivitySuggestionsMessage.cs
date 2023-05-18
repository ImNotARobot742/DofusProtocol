

// Generated on 05/18/2023 16:29:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ActivitySuggestionsMessage : NetworkMessage
    {
        public const uint Id = 509;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] lockedActivitiesIds;
        public uint[] unlockedActivitiesIds;
        
        public ActivitySuggestionsMessage()
        {
        }
        
        public ActivitySuggestionsMessage(uint[] lockedActivitiesIds, uint[] unlockedActivitiesIds)
        {
            this.lockedActivitiesIds = lockedActivitiesIds;
            this.unlockedActivitiesIds = unlockedActivitiesIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)lockedActivitiesIds.Length);
            foreach (var entry in lockedActivitiesIds)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)unlockedActivitiesIds.Length);
            foreach (var entry in unlockedActivitiesIds)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            lockedActivitiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 lockedActivitiesIds[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            unlockedActivitiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unlockedActivitiesIds[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}